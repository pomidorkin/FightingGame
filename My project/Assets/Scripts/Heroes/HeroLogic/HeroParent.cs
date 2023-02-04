using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;using System;

abstract public class HeroParent : MonoBehaviour
{
    [SerializeField] AbilityBar myAbilityBar;
    Canvas canvas;
    [SerializeField] int stars;
    [SerializeField] int price;
    [SerializeField] string characterName;
    [SerializeField] SpriteRenderer characterImage;
    [SerializeField] Image heroImage;

    [SerializeField] private int heroHealth;
    private int initialHealth;

    public class HeroHealthDecreasedActionEventArgs : EventArgs
    {
        public int NewHealth { get; set; }
    }

    public delegate void HeroDecreaseHealthAction(object source, HeroHealthDecreasedActionEventArgs args);
    public event HeroDecreaseHealthAction OnHealthDecreased;

    private void OnEnable()
    {
        initialHealth = heroHealth;
    }

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

    public void DecreasePlayerHealth(int amount)
    {
        if (heroHealth > amount)
        {
            heroHealth -= amount;
        }
        else
        {
            // Game Over
            heroHealth = 0;
        }
        OnHealthDecreased(this, new HeroHealthDecreasedActionEventArgs() { NewHealth = heroHealth });
    }

    public int GetHeroHealth()
    {
        return heroHealth;
    }

    public int GetInitialHeroHealth()
    {
        return initialHealth;
    }
}
