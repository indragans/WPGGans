
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public float Hitpoints;
    public float MaxHitPoints = 5;
    //public HealthbarBehaviour Healthbar;

    void Start()
    {
        Hitpoints = MaxHitPoints;
        //Healthbar.SetHealthbar(Hitpoints, MaxHitpoints);
    }

    public void TakeHit(float damage)
    {
        Hitpoints -= damage;

        if (Hitpoints <= 0)
        {
            Destroy(gameObject);
        }
    }

}
