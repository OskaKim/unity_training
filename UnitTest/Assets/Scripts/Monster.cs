using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Monster : MonoBehaviour
{
    [SerializeField] private int hp = 100;
    [SerializeField] private Text text;
    public void Damaged(int damage){
        hp = Math.Max(0, hp - damage);
        text.text = hp == 0 ? "died!" : $"I'm monster\nhp is {hp}";
    }
}
