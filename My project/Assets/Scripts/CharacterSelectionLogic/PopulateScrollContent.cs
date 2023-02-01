using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopulateScrollContent : MonoBehaviour
{
    [SerializeField] SavingMapper savingMapper;
    [SerializeField] GameObject characterSelectionPrefab;
    [SerializeField] GameObject parentContentObject;
    [SerializeField] Button readyButton;
    private SaveManager saveManager;

    private void Awake()
    {
        saveManager = FindObjectOfType<SaveManager>();
    }
    private void Start()
    {
        savingMapper.RemapHeroes();
        for (int i = 0; i < savingMapper.dict.Count; i++)
        {
            if (saveManager.State.purchased[i])
            {
                var purchasedChar = Instantiate(characterSelectionPrefab); // Instantiate(savingMapper.dict[i])
                purchasedChar.transform.SetParent(parentContentObject.transform, false);
                //purchasedChar.transform.parent = parentContentObject.transform;
            }
        }
    }

    public Button GetReadyButton()
    {
        return readyButton;
    }
}
