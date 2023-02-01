using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelection : MonoBehaviour
{
    [SerializeField] private HeroParent selectedHero;
    [SerializeField] private SelectionUnitManager selectionUnitManager;
    public static CharacterSelection Instance { get; private set; }
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    public void SetSelectedHero(HeroParent selectedHero)
    {
        this.selectedHero = selectedHero;
    }

    public HeroParent GetSelectedHero()
    {
        if (selectedHero != null)
        {
            return selectedHero;
        }
        else
        {
            throw new System.Exception("No heroes selected");
        }
    }

    public SelectionUnitManager GetSelectionUnitManager()
    {
        return selectionUnitManager;
    }
}
