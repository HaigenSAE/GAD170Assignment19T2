using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{
    public int fruit;
    public int apples;
    public int bananas;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        fruit += 3 - bananas;
        apples += 2;
        //Debug.Log("There is " + fruit + " fruit");
        //Debug.Log("There are " + apples + " apples");

        //If our fruit exceeds 100
        if (fruit > 100)
        {
            Debug.Log("Greater than 100");
        }
        else
        {
            Debug.Log("Less than 100");
        }
    }
}




//Player script (i.e. named something like PlayerScript.cs

//Variables for stats, start with Health
//Add things like Strength, Speed, Defense, Luck
/*

    Level Up {
    Strength++; or Strength += 1; or Strength = Strength + 1;
    Strength--;

    Strength = Level*10;
    //Only increase Speed stat, every second level

}
*/