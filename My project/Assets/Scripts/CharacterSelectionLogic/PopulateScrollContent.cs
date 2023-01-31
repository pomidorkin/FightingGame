using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopulateScrollContent : MonoBehaviour
{
    [SerializeField] SavingMapper savingMapper;
    [SerializeField] GameObject characterSelectionPrefab;
    [SerializeField] GameObject parentContentObject;
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
                purchasedChar.transform.parent = parentContentObject.transform;
            }
        }
    }
}
