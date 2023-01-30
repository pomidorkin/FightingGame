using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CoinButtonManager : MonoBehaviour
{
    private PlayerResourceManager playerResourceManager;
    private AllButtonsManager allButtonsManager;
    private Button coinButton;
    private int buttonResetTime = 1;
    public bool isAutomatic = false;

    // Automatic timer logic
    private float maxTimer;
    private float currentTimer = 0f;
    private void OnEnable()
    {
        maxTimer = (buttonResetTime + buttonResetTime * 0.1f);
        coinButton = GetComponent<Button>();
        playerResourceManager = FindObjectOfType<PlayerResourceManager>();
    }

    private void Start()
    {
        allButtonsManager = FindObjectOfType<AllButtonsManager>();
        if (!allButtonsManager.coins.Contains(this))
        {
            allButtonsManager.coins.Add(this);
        }
        allButtonsManager.CheckIfAllAreActtive();
    }

    private void Update()
    {
        if (isAutomatic)
        {
            if (currentTimer >= maxTimer)
            {
                currentTimer = 0;
                ButtonPressed();
            }
            else
            {
                currentTimer += Time.deltaTime;
            }
        }
    }
    public void ButtonPressed()
    {
        // Play anim
        coinButton.interactable = false;
        playerResourceManager.AddResource();
        StartCoroutine(ButtonResetter());

    }

    private IEnumerator ButtonResetter()
    {
        yield return new WaitForSeconds(buttonResetTime);
        coinButton.interactable = true;
    }
}