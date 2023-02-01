using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

abstract public class HeroParent : MonoBehaviour
{
    [SerializeField] AbilityBar myAbilityBar;
    Canvas canvas;
    [SerializeField] int stars;
    [SerializeField] int price;
    [SerializeField] string characterName;
    [SerializeField] SpriteRenderer characterImage;
    [SerializeField] Image heroImage;

    // Start is called before the first frame update
    void Start()
    {
        canvas = FindObjectOfType<Canvas>();
        var abilityBar = Instantiate(myAbilityBar);
        abilityBar.transform.SetParent(canvas.transform, false);
    }

    public int GetStars()
    {
        return stars;
    }

    public int GetPrice()
    {
        return price;
    }

    public Sprite GetHeroSprite()
    {
        return GetComponent<Sprite>();
    }

    public string GetCharacterName()
    {
        return characterName;
    }

    public Sprite GetCharacterImage()
    {
        return characterImage.sprite;
    }
}
