using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAbilities : MonoBehaviour
{
    [SerializeField] BossAbility[] bossAbilities;
    private HeroAndBossManager heroAndBossManager;

    private void Start()
    {
        heroAndBossManager = FindObjectOfType<HeroAndBossManager>();
    }

    public void UseBossAbility(int i)
    {
        Debug.Log("Using Boss ability N: " + i);
        heroAndBossManager.BossAttack(bossAbilities[i].damageAmount);
    }
}
