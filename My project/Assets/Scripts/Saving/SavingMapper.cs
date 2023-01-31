using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Mapper", menuName = "ScriptableObjects/MapperScriptableObject")]
public class SavingMapper : ScriptableObject
{
    [SerializeField] private GameObject[] allHeroes;
    public Dictionary<int, GameObject> dict = new Dictionary<int, GameObject>();

    public void RemapHeroes()
    {
        dict.Clear();
        for (int i = 0; i < allHeroes.Length; i++)
        {
                dict.Add(i, allHeroes[i]);
        }
    }

    public int GetNumberOfHeroes()
    {
        RemapHeroes();
        return dict.Count;
    }

    // TODO: Write a method to convert a hero to a HeroSelectionCard
}
