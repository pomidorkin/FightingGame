using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectionUnit : MonoBehaviour
{
    [SerializeField] HeroParent heroPrefab;
    private CharacterSelection characterSelection;
    [SerializeField] Image frameFocusImage;
    [SerializeField] Button readyButton;

    private void Start()
    {
        characterSelection = FindObjectOfType<CharacterSelection>();
    }

    public void SelectHero()
    {
        characterSelection.SetSelectedHero(heroPrefab);
        ChangeFrameFocusColor(new Color(0, 255, 61));
        readyButton.interactable = true;
    }

    private void ChangeFrameFocusColor(Color color)
    {
        frameFocusImage.color = color;
    }
}
