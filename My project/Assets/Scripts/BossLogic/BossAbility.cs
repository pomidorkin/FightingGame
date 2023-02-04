using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "NewBossAbility", menuName = "BossAbilities/BossAAbility")]
public class BossAbility : ScriptableObject
{
    [SerializeField] public int manaPrice;
    [SerializeField] public int damageAmount;
    [SerializeField] public ParticleSystem attackParticleEffect;
}
