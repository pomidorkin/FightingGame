using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MakeAutomaticButton : MonoBehaviour
{
    [SerializeField] private AllButtonsManager allButtonsManager;
    private PlayerResourceManager playerResourceManager;
    private int buttonPrice = 100;
    private Button thisButton;
    public bool interactable = false;
    public bool nonAutomaticArePresent = true;

    private void OnEnable()
    {
        playerResourceManager = FindObjectOfType<PlayerResourceManager>();
    }

    private void Start()
    {
        thisButton = GetComponent<Button>();
        thisButton.interactable = false;
    }

    public void MakeAutomatic()
    {
        if ((playerResourceManager.resourceAmount - buttonPrice) > 0)
        {
            playerResourceManager.DecreaseResource(buttonPrice);
            allButtonsManager.MakeButtonAutomatic();
        }
    }

    private void Update()
    {
        if ((buttonPrice < playerResourceManager.resourceAmount) && !interactable && nonAutomaticArePresent == true)
        {
            interactable = true;
            thisButton.interactable = true;
        }
        else if (interactable && (buttonPrice > playerResourceManager.resourceAmount))
        {
            interactable = false;
            thisButton.interactable = false;
        }
        else if (interactable && !nonAutomaticArePresent)
        {
            interactable = false;
            thisButton.interactable = false;
        }
    }
}