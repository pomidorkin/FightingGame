using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerResourceManager : MonoBehaviour
{
    public long resourceAmount = 0;
    private int resourceAddAmount = 1;
    [SerializeField] private TMP_Text resourceText;

    public delegate void ResourceAdded();
    public event ResourceAdded resourcedded;

    public void AddResource()
    {

        resourcedded();
        resourceAmount += resourceAddAmount;
        UpdateResourceText();
        Debug.Log("resourceAmount: " + resourceAmount);
    }

    private void UpdateResourceText()
    {
        // TODO: Do smt like 1mil instead of 1.000.000 (regular expression)
        resourceText.text = MoneyConverter.ConvertMoneyToText(resourceAmount);
        //resourceText.text = resourceAmount.ToString();
    }

    public void IncreaseAddAmount(int amount)
    {
        resourceAddAmount += amount;
    }

    public void DecreaseResource(int amount)
    {
        resourcedded();
        if ((resourceAmount - amount) >= 0)
        {
            resourceAmount -= amount;
            UpdateResourceText();
        }
    }

    public long GerResourceAmount()
    {
        return resourceAmount;
    }
}