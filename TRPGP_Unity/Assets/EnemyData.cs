using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Enemy", menuName = "EnemyData", order = 1)]
public class EnemyData : ScriptableObject
{
    public string enemyName;
    public Sprite sprite;

    public int hp;
    public int atk;
    public int dfs;
}
