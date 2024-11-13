using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Archer : PlayerStats
{


    [SerializeField] Mercenary mercenary;

    protected override private void attack()
    {

        Debug.Log("Strike!");
        mercenary.Health -= Attack;


        if (mercenary.Health < 0)
        {
            mercenary.Health = 0;
            Debug.Log("Damage hit: " +  mercenary.Health);
        }
        else
        {
            Debug.Log("Damage hit: " + mercenary.Health);
        }

        Debug.Log("------------");
    }


    private void Start()
    {
        attack();
    }

}
