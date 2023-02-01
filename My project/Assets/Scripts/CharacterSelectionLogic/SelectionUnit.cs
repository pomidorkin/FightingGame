using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SelectionUnit : MonoBehaviour
{
    //[SerializeField] HeroParent heroPrefab;
    private HeroParent heroPrefab;
    private CharacterSelection characterSelection;
    [SerializeField] Image frameFocusImage;
    [SerializeField] Button readyButton;
    //[SerializeField] Color selectedColor;
    //[SerializeField] Color defaultColor;
    private PopulateScrollContent populateScrollContent;
    private SavingMapper savingMapper;

    // Selection Unit Card Setting Variables
    [SerializeField] RawImage characterImage;
    [SerializeField] TMP_Text characterName;
    [SerializeField] GameObject[] stars;

    public int id;

    private void Start()
    {
        characterSelection = FindObjectOfType<CharacterSelection>();
        characterSelection.GetSelectionUnitManager().AddSelectionUnit(this);
        readyButton = FindObjectOfType<PopulateScrollContent>().GetReadyButton();

        populateScrollContent = characterSelection.GetPopulateScrollContent();
        savingMapper = populateScrollContent.GetSavingMapper();
        //heroPrefab = savingMapper.dict[populateScrollContent.currentId];
        //heroPrefab = savingMapper.GetHeroById(populateScrollContent.currentId);
        heroPrefab = savingMapper.GetHeroById(id);
        SetCharacterSelectionCard();
    }

    public void SelectHero()
    {
        // TODO: Add image saying "Selected"
        characterSelection.GetSelectionUnitManager().DeselectAllUnits();
        characterSelection.SetSelectedHero(heroPrefab);
        ChangeFrameFocusColor(new Color(26, 255, 0));
        readyButton.interactable = true;
    }

    public void DeselectUnit()
    {
        // TODO: Remove image saying "Selected"
        ChangeFrameFocusColor(new Color(255, 255, 255));
    }

    private void ChangeFrameFocusColor(Color color)
    {
        frameFocusImage.color = color;
    }

    // Selection Unit Card Setting Logic

    private void SetCharacterSelectionCard()
    {
        SetStars();
        SetCharacterImage();
        SetCharacterName();
    }

    private void SetCharacterImage()
    {
        //characterImage = heroPrefab.GetCharacterImage();
        characterImage.texture = heroPrefab.GetCharacterImage().texture;
    }

    private void SetCharacterName()
    {
        characterName.SetText(heroPrefab.GetCharacterName());
    }

    private void SetStars()
    {
        for (int i = 0; i < heroPrefab.GetStars(); i++)
        {
            stars[i].SetActive(true);
        }
    }
}