using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CharacterLockedCard : MonoBehaviour
{
    private HeroParent heroPrefab;
    private CharacterSelection characterSelection;
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
        //characterSelection.GetSelectionUnitManager().AddSelectionUnit(this);

        populateScrollContent = characterSelection.GetPopulateScrollContent();
        savingMapper = populateScrollContent.GetSavingMapper();
        //heroPrefab = savingMapper.dict[populateScrollContent.currentId];
        //Debug.Log(populateScrollContent.currentId);
        //heroPrefab = savingMapper.GetHeroById(populateScrollContent.currentId);
        heroPrefab = savingMapper.GetHeroById(id);
        SetCharacterSelectionCard();
    }

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
        characterImage.color = new Color32(50, 50, 50, 255);
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
