using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Stats myStats;

    private GameObject GameManager;

    public enum EnemyTypes
    {
        small,
        medium,
        large
    }

    public EnemyTypes myType;

    void Start()
    {
        //Find our GameManager
        GameManager = GameObject.FindGameObjectWithTag("GameManager");
        myStats = GetComponent<Stats>();
        switch (myType)
        {
            case EnemyTypes.small:
                //do setup
                break;
            case EnemyTypes.medium:
                //do thing
                break;
            case EnemyTypes.large:
                //do thing
                break;
        }
        //StartCoroutine(randomDelay());
    }

    public void Defeated()
    {
        GameManager.GetComponent<GameManager>().RemoveEnemy(gameObject);
    }
}
