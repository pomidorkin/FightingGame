using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AbilityBar : MonoBehaviour
{
    private PlayerResourceManager playerResourceManager;
    [SerializeField] AbilityButton[] abilityButtons;

    private void OnEnable()
    {
        playerResourceManager = FindObjectOfType<PlayerResourceManager>();
        playerResourceManager.resourcedded += UpdateButtons;
    }

    private void OnDisable()
    {
        playerResourceManager.resourcedded -= UpdateButtons;
    }

    private void UpdateButtons()
    {

        foreach (AbilityButton abilityButton in abilityButtons)
        {
            if (abilityButton.GetAbilityManaPrice() > playerResourceManager.GerResourceAmount())
            {
                abilityButton.SetMyButtonInteractible(false);
            }
            else
            {
                abilityButton.SetMyButtonInteractible(true);
            }
        }
    }

    public void Attack(int damage, int manaPrice)
    {
        if (playerResourceManager.GerResourceAmount() >= manaPrice)
        {
            playerResourceManager.DecreaseResource(manaPrice);
            // Deal $damage to boss
        }
        
    }
}
