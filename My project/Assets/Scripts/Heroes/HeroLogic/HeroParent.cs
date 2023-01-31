using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class HeroParent : MonoBehaviour
{
    [SerializeField] AbilityBar myAbilityBar;
    Canvas canvas;
    [SerializeField] int stars;
    [SerializeField] int price;

    // Start is called before the first frame update
    void Start()
    {
        canvas = FindObjectOfType<Canvas>();
        var abilityBar = Instantiate(myAbilityBar);
        abilityBar.transform.SetParent(canvas.transform, false);
    }
}
