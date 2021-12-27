using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Monster : MonoBehaviour
{
    public int Hp { get; set; } = 100;
    [SerializeField] private Text text;
    public void Damaged(int damage){
        Hp = Math.Max(0, Hp - damage);
        text.text = Hp == 0 ? "died!" : $"I'm monster\nHp is {Hp}";
    }
}
