﻿using System;
using System.Collections;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using WowJamMessages.MobileClientJSON;
using WowStatConstants;
using WowStaticData;

public class WorldQuestTooltip : MonoBehaviour
{
	private void Start()
	{
		this.m_rewardsLabel.font = GeneralHelpers.LoadStandardFont();
		this.m_rewardsLabel.text = StaticDB.GetString("REWARDS", "Rewards");
		this.m_timeLeftString = StaticDB.GetString("TIME_LEFT", "Time Left: PH");
	}

	public void OnEnable()
	{
		Main.instance.m_canvasBlurManager.AddBlurRef_MainCanvas();
		Main.instance.m_backButtonManager.PushBackAction(BackAction.hideAllPopups, null);
	}

	private void OnDisable()
	{
		Main.instance.m_canvasBlurManager.RemoveBlurRef_MainCanvas();
		Main.instance.m_backButtonManager.PopBackAction();
	}

	private void EnableAdditionalRewardDisplays(int highestActiveIndex)
	{
		this.m_rewardInfo[1].gameObject.SetActive(highestActiveIndex >= 1);
		this.m_rewardInfo[2].gameObject.SetActive(highestActiveIndex >= 2);
	}

	private void InitRewardInfoDisplay(MobileWorldQuest worldQuest)
	{
		int num = 0;
		this.m_rewardInfo[0].gameObject.SetActive(true);
		this.m_rewardInfo[1].gameObject.SetActive(false);
		this.m_rewardInfo[2].gameObject.SetActive(false);
		if (worldQuest.Item != null && worldQuest.Item.Count<MobileWorldQuestReward>() > 0)
		{
			foreach (MobileWorldQuestReward mobileWorldQuestReward in worldQuest.Item)
			{
				Sprite rewardSprite = GeneralHelpers.LoadIconAsset(AssetBundleType.Icons, mobileWorldQuestReward.FileDataID);
				this.m_rewardInfo[num].SetReward(MissionRewardDisplay.RewardType.item, mobileWorldQuestReward.RecordID, mobileWorldQuestReward.Quantity, rewardSprite, mobileWorldQuestReward.ItemContext);
				this.EnableAdditionalRewardDisplays(num++);
				if (num >= 3)
				{
					return;
				}
			}
		}
		else if (worldQuest.Currency.Count<MobileWorldQuestReward>() > 0)
		{
			foreach (MobileWorldQuestReward mobileWorldQuestReward2 in worldQuest.Currency)
			{
				Sprite iconSprite = GeneralHelpers.LoadCurrencyIcon(mobileWorldQuestReward2.RecordID);
				CurrencyTypesRec record = StaticDB.currencyTypesDB.GetRecord(mobileWorldQuestReward2.RecordID);
				int quantity = mobileWorldQuestReward2.Quantity / (((record.Flags & 8u) == 0u) ? 1 : 100);
				this.m_rewardInfo[num].SetCurrency(mobileWorldQuestReward2.RecordID, quantity, iconSprite);
				this.EnableAdditionalRewardDisplays(num++);
				if (num >= 3)
				{
					return;
				}
			}
		}
		else if (worldQuest.Money > 0)
		{
			Sprite iconSprite2 = Resources.Load<Sprite>("MiscIcons/INV_Misc_Coin_01");
			this.m_rewardInfo[num].SetGold(worldQuest.Money / 10000, iconSprite2);
			this.EnableAdditionalRewardDisplays(num++);
			if (num >= 3)
			{
				return;
			}
		}
		else if (worldQuest.Experience > 0)
		{
			Sprite localizedFollowerXpIcon = GeneralHelpers.GetLocalizedFollowerXpIcon();
			this.m_rewardInfo[num].SetFollowerXP(worldQuest.Experience, localizedFollowerXpIcon);
			this.EnableAdditionalRewardDisplays(num++);
			if (num >= 3)
			{
				return;
			}
		}
	}

	public void SetQuest(int questID)
	{
		this.m_expiringSoon.gameObject.SetActive(false);
		this.m_questID = questID;
		Transform[] componentsInChildren = this.m_worldQuestObjectiveRoot.GetComponentsInChildren<Transform>(true);
		foreach (Transform transform in componentsInChildren)
		{
			if (transform != null && transform != this.m_worldQuestObjectiveRoot.transform)
			{
				Object.DestroyImmediate(transform.gameObject);
			}
		}
		MobileWorldQuest mobileWorldQuest = (MobileWorldQuest)WorldQuestData.worldQuestDictionary[this.m_questID];
		GameObject gameObject = Object.Instantiate<GameObject>(this.m_worldQuestObjectiveDisplayPrefab);
		gameObject.transform.SetParent(this.m_worldQuestObjectiveRoot.transform, false);
		Text component = gameObject.GetComponent<Text>();
		component.text = mobileWorldQuest.QuestTitle;
		component.resizeTextMaxSize = 26;
		BountySite[] componentsInChildren2 = this.m_bountyLogoRoot.transform.GetComponentsInChildren<BountySite>(true);
		foreach (BountySite bountySite in componentsInChildren2)
		{
			Object.DestroyImmediate(bountySite.gameObject);
		}
		if (PersistentBountyData.bountiesByWorldQuestDictionary.ContainsKey(mobileWorldQuest.QuestID))
		{
			MobileBountiesByWorldQuest mobileBountiesByWorldQuest = (MobileBountiesByWorldQuest)PersistentBountyData.bountiesByWorldQuestDictionary[mobileWorldQuest.QuestID];
			for (int k = 0; k < mobileBountiesByWorldQuest.BountyQuestID.Length; k++)
			{
				IEnumerator enumerator = PersistentBountyData.bountyDictionary.Values.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						MobileWorldQuestBounty mobileWorldQuestBounty = (MobileWorldQuestBounty)obj;
						if (mobileBountiesByWorldQuest.BountyQuestID[k] == mobileWorldQuestBounty.QuestID)
						{
							QuestV2Rec record = StaticDB.questDB.GetRecord(mobileWorldQuestBounty.QuestID);
							if (record != null)
							{
								GameObject gameObject2 = Object.Instantiate<GameObject>(this.m_worldQuestObjectiveDisplayPrefab);
								gameObject2.transform.SetParent(this.m_worldQuestObjectiveRoot.transform, false);
								Text component2 = gameObject2.GetComponent<Text>();
								component2.text = record.QuestTitle;
								component2.color = new Color(1f, 0.773f, 0f, 1f);
								BountySite bountySite2 = Object.Instantiate<BountySite>(this.m_bountyLogoPrefab);
								bountySite2.SetBounty(mobileWorldQuestBounty);
								bountySite2.transform.SetParent(this.m_bountyLogoRoot.transform, false);
							}
						}
					}
				}
				finally
				{
					IDisposable disposable;
					if ((disposable = (enumerator as IDisposable)) != null)
					{
						disposable.Dispose();
					}
				}
			}
		}
		GameObject gameObject3 = Object.Instantiate<GameObject>(this.m_worldQuestObjectiveDisplayPrefab);
		gameObject3.transform.SetParent(this.m_worldQuestObjectiveRoot.transform, false);
		this.m_worldQuestTimeText = gameObject3.GetComponent<Text>();
		this.m_worldQuestTimeText.text = mobileWorldQuest.QuestTitle;
		this.m_worldQuestTimeText.color = new Color(1f, 0.773f, 0f, 1f);
		foreach (MobileWorldQuestObjective mobileWorldQuestObjective in mobileWorldQuest.Objective.AsEnumerable<MobileWorldQuestObjective>())
		{
			GameObject gameObject4 = Object.Instantiate<GameObject>(this.m_worldQuestObjectiveDisplayPrefab);
			gameObject4.transform.SetParent(this.m_worldQuestObjectiveRoot.transform, false);
			Text component3 = gameObject4.GetComponent<Text>();
			component3.text = "- " + mobileWorldQuestObjective.Text;
		}
		this.InitRewardInfoDisplay(mobileWorldQuest);
		this.m_endTime = (long)mobileWorldQuest.EndTime;
		QuestInfoRec record2 = StaticDB.questInfoDB.GetRecord(mobileWorldQuest.QuestInfoID);
		if (record2 == null)
		{
			return;
		}
		bool active = (record2.Modifiers & 2) != 0;
		this.m_dragonFrame.gameObject.SetActive(active);
		if (record2.Type == 7)
		{
			this.m_background.sprite = Resources.Load<Sprite>("NewWorldQuest/Mobile-NormalQuest");
			this.m_main.sprite = Resources.Load<Sprite>("NewWorldQuest/Map-LegionInvasion-SargerasCrest");
			return;
		}
		this.m_background.sprite = Resources.Load<Sprite>("NewWorldQuest/Mobile-NormalQuest");
		bool flag = (record2.Modifiers & 1) != 0;
		if (flag && record2.Type != 3)
		{
			this.m_background.sprite = Resources.Load<Sprite>("NewWorldQuest/Mobile-RareQuest");
		}
		bool flag2 = (record2.Modifiers & 4) != 0;
		if (flag2 && record2.Type != 3)
		{
			this.m_background.sprite = Resources.Load<Sprite>("NewWorldQuest/Mobile-EpicQuest");
		}
		int uitextureAtlasMemberID;
		string text;
		switch (record2.Type)
		{
		case 1:
		{
			int profession = record2.Profession;
			switch (profession)
			{
			case 182:
				uitextureAtlasMemberID = TextureAtlas.GetUITextureAtlasMemberID("worldquest-icon-herbalism");
				text = "Mobile-Herbalism";
				break;
			default:
				if (profession != 164)
				{
					if (profession != 165)
					{
						if (profession != 129)
						{
							if (profession != 171)
							{
								if (profession != 197)
								{
									if (profession != 202)
									{
										if (profession != 333)
										{
											if (profession != 356)
											{
												if (profession != 393)
												{
													if (profession != 755)
													{
														if (profession != 773)
														{
															if (profession != 794)
															{
																uitextureAtlasMemberID = TextureAtlas.GetUITextureAtlasMemberID("worldquest-questmarker-questbang");
																text = "Mobile-QuestExclamationIcon";
															}
															else
															{
																uitextureAtlasMemberID = TextureAtlas.GetUITextureAtlasMemberID("worldquest-icon-archaeology");
																text = "Mobile-Archaeology";
															}
														}
														else
														{
															uitextureAtlasMemberID = TextureAtlas.GetUITextureAtlasMemberID("worldquest-icon-inscription");
															text = "Mobile-Inscription";
														}
													}
													else
													{
														uitextureAtlasMemberID = TextureAtlas.GetUITextureAtlasMemberID("worldquest-icon-jewelcrafting");
														text = "Mobile-Jewelcrafting";
													}
												}
												else
												{
													uitextureAtlasMemberID = TextureAtlas.GetUITextureAtlasMemberID("worldquest-icon-skinning");
													text = "Mobile-Skinning";
												}
											}
											else
											{
												uitextureAtlasMemberID = TextureAtlas.GetUITextureAtlasMemberID("worldquest-icon-fishing");
												text = "Mobile-Fishing";
											}
										}
										else
										{
											uitextureAtlasMemberID = TextureAtlas.GetUITextureAtlasMemberID("worldquest-icon-enchanting");
											text = "Mobile-Enchanting";
										}
									}
									else
									{
										uitextureAtlasMemberID = TextureAtlas.GetUITextureAtlasMemberID("worldquest-icon-engineering");
										text = "Mobile-Engineering";
									}
								}
								else
								{
									uitextureAtlasMemberID = TextureAtlas.GetUITextureAtlasMemberID("worldquest-icon-tailoring");
									text = "Mobile-Tailoring";
								}
							}
							else
							{
								uitextureAtlasMemberID = TextureAtlas.GetUITextureAtlasMemberID("worldquest-icon-alchemy");
								text = "Mobile-Alchemy";
							}
						}
						else
						{
							uitextureAtlasMemberID = TextureAtlas.GetUITextureAtlasMemberID("worldquest-icon-firstaid");
							text = "Mobile-FirstAid";
						}
					}
					else
					{
						uitextureAtlasMemberID = TextureAtlas.GetUITextureAtlasMemberID("worldquest-icon-leatherworking");
						text = "Mobile-Leatherworking";
					}
				}
				else
				{
					uitextureAtlasMemberID = TextureAtlas.GetUITextureAtlasMemberID("worldquest-icon-blacksmithing");
					text = "Mobile-Blacksmithing";
				}
				break;
			case 185:
				uitextureAtlasMemberID = TextureAtlas.GetUITextureAtlasMemberID("worldquest-icon-cooking");
				text = "Mobile-Cooking";
				break;
			case 186:
				uitextureAtlasMemberID = TextureAtlas.GetUITextureAtlasMemberID("worldquest-icon-mining");
				text = "Mobile-Mining";
				break;
			}
			goto IL_729;
		}
		case 3:
			uitextureAtlasMemberID = TextureAtlas.GetUITextureAtlasMemberID("worldquest-icon-pvp-ffa");
			text = "Mobile-PVP";
			goto IL_729;
		case 4:
			uitextureAtlasMemberID = TextureAtlas.GetUITextureAtlasMemberID("worldquest-icon-petbattle");
			text = "Mobile-Pets";
			goto IL_729;
		}
		uitextureAtlasMemberID = TextureAtlas.GetUITextureAtlasMemberID("worldquest-questmarker-questbang");
		text = "Mobile-QuestExclamationIcon";
		IL_729:
		if (text != null)
		{
			this.m_main.sprite = Resources.Load<Sprite>("NewWorldQuest/" + text);
		}
		else if (uitextureAtlasMemberID > 0)
		{
			this.m_main.sprite = TextureAtlas.instance.GetAtlasSprite(uitextureAtlasMemberID);
			this.m_main.SetNativeSize();
		}
		this.UpdateTimeRemaining();
	}

	private void UpdateTimeRemaining()
	{
		int num = (int)(this.m_endTime - GarrisonStatus.CurrentTime());
		if (num < 0)
		{
			num = 0;
		}
		Duration duration = new Duration(num, false);
		this.m_worldQuestTimeText.text = this.m_timeLeftString + " " + duration.DurationString;
		bool active = num < 4500;
		this.m_expiringSoon.gameObject.SetActive(active);
	}

	private void Update()
	{
		this.UpdateTimeRemaining();
	}

	[Header("World Quest Icon Layers")]
	public Image m_dragonFrame;

	public Image m_background;

	public Image m_main;

	public Image m_expiringSoon;

	[Header("World Quest Info")]
	private Text m_worldQuestTimeText;

	public MissionRewardDisplay m_missionRewardDisplayPrefab;

	public GameObject m_worldQuestObjectiveRoot;

	public GameObject m_worldQuestObjectiveDisplayPrefab;

	public GameObject m_bountyLogoRoot;

	public BountySite m_bountyLogoPrefab;

	[Header("Misc")]
	public RewardInfoPopup[] m_rewardInfo;

	public Text m_rewardsLabel;

	private int m_questID;

	private const int WORLD_QUEST_TIME_LOW_MINUTES = 75;

	private long m_endTime;

	private string m_timeLeftString;
}
