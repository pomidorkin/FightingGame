using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAlgorithm : MonoBehaviour
{
    private float battleLength;
    [SerializeField] private float maxAtackTimer = 1.2f;
    private float currentAtackTimer;

    public class BattleProgressActionEventArgs : EventArgs
    {
        public int BattleTime { get; set; }
    }

    public delegate void AttackAction(object source, BattleProgressActionEventArgs args);
    public event AttackAction OnAttackedAction;

    // Update is called once per frame
    void Update()
    {
        battleLength += Time.deltaTime;

        if (currentAtackTimer < maxAtackTimer)
        {
            currentAtackTimer += Time.deltaTime;
        }
        else
        {
            /*
             * Every $maxAtackTimer (1.2) seconds a boss attacks
             * The boss chooses attacks based onhow much time has passed since
             * the beggining of the battle: i.e. First 10 seconds the boss attacks
             * with the first attack/ability, 10 to 30 seconds - second attack etc.
             * TODO: These numbers need to be tested, balacnced and fixed
             */
            currentAtackTimer = 0;
            if (battleLength < 15)
            {
                Attack(0);
            } else if (battleLength < 75)
            {
                Attack(1);
            }
            else if (battleLength < 165)
            {
                Attack(2);
            }
            else if (battleLength < 255)
            {
                Attack(3);
            }
            else
            {
                Attack(4);
            }

        }
    }

    public void Attack(int i)
    {
        OnAttackedAction(this, new BattleProgressActionEventArgs() { BattleTime = i });
        Debug.Log("Attacking with attack N " + i);
    }
}
