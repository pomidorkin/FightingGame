using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossParent : MonoBehaviour
{
    [SerializeField] BossAbilities bossAbilities;
    private BossAlgorithm bossAlgorithm;
    [SerializeField] int bossHealth = 1000;

    private void OnEnable()
    {
        bossAlgorithm = FindObjectOfType<BossAlgorithm>();
        bossAlgorithm.OnAttackedAction += AttackHandler;
    }

    private void OnDisable()
    {
        bossAlgorithm.OnAttackedAction -= AttackHandler;
    }

    private void AttackHandler(object source, BossAlgorithm.BattleProgressActionEventArgs args)
    {
        bossAbilities.UseBossAbility(args.BattleTime);
    }

    public void DecreaseBossHealth(int amount)
    {
        if (bossHealth > amount)
        {

                bossHealth -= amount;
        }
        else
        {
            // Win
            bossHealth = 0;
        }
    }
}
