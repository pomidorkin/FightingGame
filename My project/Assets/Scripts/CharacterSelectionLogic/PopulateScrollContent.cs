using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopulateScrollContent : MonoBehaviour
{
    [SerializeField] SavingMapper savingMapper;
    [SerializeField] SelectionUnit characterSelectionPrefab;
    [SerializeField] CharacterLockedCard characterLockedPrefab;
    [SerializeField] GameObject parentContentObject;
    [SerializeField] Button readyButton;
    private SaveManager saveManager;

    //public int currentId = 0;

    private void Awake()
    {
        saveManager = FindObjectOfType<SaveManager>();
    }
    private void Start()
    {
        savingMapper.RemapHeroes();
        for (int i = 0; i < savingMapper.dict.Count; i++)
        {
            //currentId = i;
            if (saveManager.State.purchased[i])
            {
                /*var purchasedChar = Instantiate(characterSelectionPrefab); // Instantiate(savingMapper.dict[i])
                purchasedChar.transform.SetParent(parentContentObject.transform, false);*/
                SelectionUnit purchasedChar = Instantiate<SelectionUnit>(characterSelectionPrefab); // Instantiate(savingMapper.dict[i])
                purchasedChar.transform.SetParent(parentContentObject.transform, false);
                purchasedChar.id = i;
            }
            else
            {
                /*var lockedChar = Instantiate(characterLockedPrefab); // Instantiate(savingMapper.dict[i])
                lockedChar.transform.SetParent(parentContentObject.transform, false);*/
                CharacterLockedCard lockedChar = Instantiate<CharacterLockedCard>(characterLockedPrefab);
                lockedChar.transform.SetParent(parentContentObject.transform, false);
                lockedChar.id = i;
            }
        }
    }

    public Button GetReadyButton()
    {
        return readyButton;
    }

    /*public int GetCurrentId()
    {
        return currentId;
    }*/

    public SavingMapper GetSavingMapper()
    {
        return savingMapper;
    }
}
