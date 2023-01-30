using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroSpawner : MonoBehaviour
{
    [SerializeField] HeroParent hero;

    private void Start()
    {
        Instantiate(hero);
    }
}
