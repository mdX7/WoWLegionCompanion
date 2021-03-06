﻿using System;
using UnityEngine;
using UnityEngine.UI;

public class ResourcesDisplay : MonoBehaviour
{
	private void OnEnable()
	{
		this.UpdateCurrencyDisplayAmount();
		Main instance = Main.instance;
		instance.GarrisonDataResetFinishedAction = (Action)Delegate.Combine(instance.GarrisonDataResetFinishedAction, new Action(this.UpdateCurrencyDisplayAmount));
	}

	private void OnDisable()
	{
		Main instance = Main.instance;
		instance.GarrisonDataResetFinishedAction = (Action)Delegate.Remove(instance.GarrisonDataResetFinishedAction, new Action(this.UpdateCurrencyDisplayAmount));
	}

	private void Start()
	{
		this.UpdateCurrencyDisplayAmount();
		Sprite sprite = GeneralHelpers.LoadCurrencyIcon(1220);
		if (sprite != null)
		{
			this.m_currencyIcon.sprite = sprite;
		}
		this.m_yourResourcesLabel.text = StaticDB.GetString("YOUR_RESOURCES", null);
		if (this.m_researchText != null)
		{
			this.m_researchText.text = StaticDB.GetString("RESEARCH_TIME", null);
		}
		if (this.m_costText != null)
		{
			this.m_costText.text = StaticDB.GetString("COST", null);
		}
	}

	private void UpdateCurrencyDisplayAmount()
	{
		this.m_currencyAmountText.text = GarrisonStatus.Resources().ToString("N0");
	}

	public Text m_yourResourcesLabel;

	public Image m_currencyIcon;

	private int m_currencyAmount;

	public Text m_currencyAmountText;

	public Text m_researchText;

	public Text m_costText;
}
