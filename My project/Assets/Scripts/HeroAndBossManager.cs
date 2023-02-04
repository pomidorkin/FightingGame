using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroAndBossManager : MonoBehaviour
{
    [SerializeField] HeroHealthSlider heroHealthSlider;
    public HeroParent hero;
    public BossParent boss;
    // Start is called before the first frame update
    void Start()
    {
        hero = FindObjectOfType<HeroParent>();
        boss = FindObjectOfType<BossParent>();
        heroHealthSlider.InitializeHealthSlider(hero);
    }

    public void BossAttack(int damage)
    {
        Debug.Log("Boss Atacks dealing " + damage + " damage!");
        hero.DecreasePlayerHealth(damage);
    }

    public void HeroAttack(int damage)
    {
        Debug.Log("Boss Atacks dealing " + damage + " damage!");
        hero.DecreasePlayerHealth(damage);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
