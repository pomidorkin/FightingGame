using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroSpawner : MonoBehaviour
{
    private CharacterSelection characterSelection;
    //[SerializeField] HeroParent hero;
    private HeroParent hero;

    private void Start()
    {
        characterSelection = FindObjectOfType<CharacterSelection>();
        Instantiate(characterSelection.GetSelectedHero());
    }
}
