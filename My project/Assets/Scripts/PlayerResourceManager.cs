using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerResourceManager : MonoBehaviour
{
    public long resourceAmount = 0;
    private int resourceAddAmount = 1;
    [SerializeField] private TMP_Text resourceText;

    public void AddResource()
    {
        resourceAmount += resourceAddAmount;
        UpdateResourceText();
        Debug.Log("resourceAmount: " + resourceAmount);
    }

    private void UpdateResourceText()
    {
        // TODO: Do smt like 1mil instead of 1.000.000 (regular expression)
        resourceText.text = resourceAmount.ToString();
    }

    public void IncreaseAddAmount(int amount)
    {
        resourceAddAmount += amount;
    }

    public void DecreaseResource(int amount)
    {
        if ((resourceAmount - amount) >= 0)
        {
            resourceAmount -= amount;
            UpdateResourceText();
        }
    }
}