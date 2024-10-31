using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestInterface : MonoBehaviour
{
    void Start()
    {
        //Polymorphism
        //Player newPlayer = new();
        //IAttack player = new Player();
        //IAttack enemy = new Enemy();
        //player.Attack();
        //enemy.Attack();
        //Debug.Log("Player damage: " + player.Damage);
        AttackObject(new Player());
        AttackObject(new Enemy());
    }
    void AttackObject(IAttack iattack)
    {
        iattack.Attack();
    }
}
