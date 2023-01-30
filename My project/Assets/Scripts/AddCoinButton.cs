using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddCoinButton : MonoBehaviour
{
    private int buttonPrice = 100;
    private int buttonNumber = 1;
    private int maxButtonNumber = 8;
    [SerializeField] GameObject coinButtonPrefab;
    [SerializeField] GameObject gridLayoutParent;
    [SerializeField] PlayerResourceManager playerResourceManager;

    private Button thisButton;
    private bool interactable = false;

    private void Start()
    {
        thisButton = GetComponent<Button>();
        thisButton.interactable = false;
    }


    public void AddNewCoinButton()
    {
        if ((playerResourceManager.resourceAmount - buttonPrice) > 0)
        {
            if (buttonNumber < maxButtonNumber)
            {
                playerResourceManager.DecreaseResource(buttonPrice);
                buttonNumber++;
                GameObject newButton = Instantiate(coinButtonPrefab) as GameObject;
                newButton.transform.SetParent(gridLayoutParent.transform, false);
            }
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