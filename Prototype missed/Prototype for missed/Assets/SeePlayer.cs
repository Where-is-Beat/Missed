﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeePlayer : MonoBehaviour
{

    public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (enemy.CompareTag("EnemyShooter"))
                enemy.GetComponent<Enemyshhoterboi>().canSeePlayer = 1;
            else
                enemy.GetComponent<Enemymovement>().canSeePlayer = 1;
           

        }
    }
}
