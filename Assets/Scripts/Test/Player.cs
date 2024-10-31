using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : IAttack
{
    public int Damage {  get; set; }

    public void Attack()
    {
        Damage = 2;
        Debug.Log("Player: " + Damage);
    }
    //camelCase: lowerUpper
    //PascalCase: UpperAll
    //snake_case: lower_underscore

    //private int playerHP;
    //private string playerName;
    //public int PlayerHP
    //{
    //    get { return playerHP; }
    //    set { playerHP = value; }
    //}
    //public string PlayerName { get; set; }
}
