using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachMonster : MonoBehaviour
{
    [SerializeField] private int damage;
    [SerializeField] private Monster monster;
    public void OnAttack()
    {
        monster.Damaged(damage);
    }
}
