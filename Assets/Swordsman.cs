using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swordsman : PlayerStats
{


    [SerializeField] Goblin goblin;

    protected override private void attack()
    {

        Debug.Log("Strike!");
        goblin.Health -= Attack;


        if (goblin.Health < 0)
        {
            goblin.Health = 0;
            Debug.Log("Damage hit: " + goblin.Health);
        }
        else
        {
            Debug.Log("Damage hit: " + goblin.Health);
        }

        Debug.Log("------------");
    }


    private void Start()
    {
        attack();
    }


}
