using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySetter : MonoBehaviour
{
    public EnemyData enemy;

    private void Start()
    {
        GetComponent<SpriteRenderer>().sprite = enemy.sprite;
        this.gameObject.name = enemy.enemyName;
    }
}
