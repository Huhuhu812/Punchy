﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultyManager : MonoBehaviour
{
    [SerializeField] SpawnManager spawnManager;
    [SerializeField] EnemyAttackTokenPool tokenPool;
    [SerializeField] ScoreTracker scoreTracker;
    float difficulty;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        difficulty = (scoreTracker.Score + Time.timeSinceLevelLoad)/100;
    }

    public float Difficulty
    {
        get
        {
            return difficulty;
        }
    }
}