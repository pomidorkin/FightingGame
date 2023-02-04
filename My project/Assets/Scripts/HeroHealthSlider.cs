using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class HeroHealthSlider : MonoBehaviour
{
    [SerializeField] Slider heroHealthSlider;
    [SerializeField] TMP_Text healthText;
    private HeroParent hero;
    private int initialHealth;

    public void InitializeHealthSlider(HeroParent hero)
    {
        this.hero = hero;
        hero.OnHealthDecreased += UpdateHeroHealthBar;
        initialHealth = hero.GetInitialHeroHealth();
        heroHealthSlider.value = 1f;
        healthText.text = MoneyConverter.ConvertMoneyToText(initialHealth) + "/" + MoneyConverter.ConvertMoneyToText(initialHealth);
    }

    private void OnDisable()
    {
        hero.OnHealthDecreased -= UpdateHeroHealthBar;
    }

    private void UpdateHeroHealthBar(object source, HeroParent.HeroHealthDecreasedActionEventArgs args)
    {
        heroHealthSlider.value = (float)args.NewHealth / initialHealth;
        healthText.text = MoneyConverter.ConvertMoneyToText(args.NewHealth) + "/" + MoneyConverter.ConvertMoneyToText(initialHealth);
    }
}
