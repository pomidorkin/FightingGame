using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmountModifierButton : MonoBehaviour
{
    private PlayerResourceManager playerResourceManager;
    private int buttonPrice = 10;
    private Button thisButton;
    private bool interactable = false;
    private void OnEnable()
    {
        playerResourceManager = FindObjectOfType<PlayerResourceManager>();
    }
    private void Start()
    {
        thisButton = GetComponent<Button>();
        thisButton.interactable = false;
    }

    public void IncreaseAddAmount(int amount)
    {
        if ((playerResourceManager.resourceAmount - buttonPrice) > 0)
        {
            playerResourceManager.DecreaseResource(buttonPrice);
            playerResourceManager.IncreaseAddAmount(amount);
        }
    }

    private void Update()
    {
        if (buttonPrice < playerResourceManager.resourceAmount && !interactable)
        {
            interactable = true;
            thisButton.interactable = true;
        }
        else if (interactable && buttonPrice > playerResourceManager.resourceAmount)
        {
            interactable = false;
            thisButton.interactable = false;
        }
    }
}