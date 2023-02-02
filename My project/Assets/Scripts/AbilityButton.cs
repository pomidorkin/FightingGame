using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AbilityButton : MonoBehaviour
{
    [SerializeField] private int abilityManaPrice;
    [SerializeField] private Button myButton;
    [SerializeField] AbilityBar abilityBar;
    private int damage;

    public int GetAbilityManaPrice()
    {
        return abilityManaPrice;
    }

    public Button GetMyButton()
    {
        return myButton;
    }

    public void Attack(int damage)
    {
        abilityBar.Attack(damage, abilityManaPrice);
    }

    public void SetMyButtonInteractible(bool value)
    {
        myButton.interactable = value;
    }
}
