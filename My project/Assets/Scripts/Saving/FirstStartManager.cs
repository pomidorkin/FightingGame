using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstStartManager : MonoBehaviour
{
    private SaveManager saveManager;
    [SerializeField] SavingMapper savingMapper;

    private void OnEnable()
    {
        saveManager = SaveManager.Instance;
    }
    private void Start()
    {
        SaveManager.Instance.Load(saveManager.GetSaveFileName());
        if (saveManager.State.firstStart)
        {
            saveManager.State.purchased = new bool[savingMapper.GetNumberOfHeroes()];
            for (int i = 0; i < savingMapper.GetNumberOfHeroes(); i++)
            {
                saveManager.State.purchased[i] = false;
            }
            saveManager.State.purchased[0] = true;
            saveManager.State.firstStart = false;
            saveManager.Save();
        }
    }
}