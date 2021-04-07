using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Enemy
{
    [SerializeField]
    string name;

    [SerializeField]
    List<string> skills;
    public Enemy(string name, List<string> skills)
    {
        this.name = name;
        this.skills = skills;
    }
}

public class EnemyWrap
{
    public List<Enemy> enemies = new List<Enemy>();
    public EnemyWrap()
    {
        
    }
}