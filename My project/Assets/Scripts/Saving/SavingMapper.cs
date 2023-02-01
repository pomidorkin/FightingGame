using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Mapper", menuName = "ScriptableObjects/MapperScriptableObject")]
public class SavingMapper : ScriptableObject
{
    [SerializeField] private HeroParent[] allHeroes;
    public Dictionary<int, HeroParent> dict = new Dictionary<int, HeroParent>();

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

    public HeroParent GetHeroById(int id)
    {
        RemapHeroes();
        return dict[id];
    }

    // TODO: Write a method to convert a hero to a HeroSelectionCard
}
