using System.Collections;
using UnityEngine;
using System.Collections.Generic;

public class Arrays : MonoBehaviour
{
    public GameObject[] players;
    public GameObject enemy;

    void Start()
    {
        players = GameObject.FindGameObjectsWithTag("Player");

        for (int i = 0; i < players.Length; i++)
        {
            Debug.Log($"Player Number {i} in named {players[i].name}");
        }
        //enemy = GameObject.FindGameObjectWithTag("Enemy");
        enemy = GameObject.FindWithTag("Enemy");
            Debug.Log($"Enemy is {enemy.name}");
    }
}
