using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AllButtonsManager : MonoBehaviour
{
    public List<CoinButtonManager> coins = new List<CoinButtonManager>();
    [SerializeField] private MakeAutomaticButton makeAutomaticButton;

    public void MakeButtonAutomatic()
    {
        foreach (CoinButtonManager button in coins)
        {
            if (!button.isAutomatic)
            {
                button.isAutomatic = true;
                makeAutomaticButton.nonAutomaticArePresent = false;
                CheckIfAllAreActtive();
                return;
            }
        }
    }

    public void CheckIfAllAreActtive()
    {
        foreach (CoinButtonManager button in coins)
        {
            if (!button.isAutomatic)
            {
                makeAutomaticButton.nonAutomaticArePresent = true;
                return;
            }
        }
    }
}