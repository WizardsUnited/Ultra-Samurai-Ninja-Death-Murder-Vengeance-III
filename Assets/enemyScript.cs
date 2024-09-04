using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript : MonoBehaviour
{


    //prbly need to combine enemy array wth foreach loop 

    GameObject enemy;
    public int enemyIndex; //to select a specific enemy


    private void Start()
    {
        enemy = FindObjectOfType<enemyScript>().gameObject;
       
    }



    private void Update()
    {

        foreach (enemyScript)
        {
            Debug.Log("enemies present " + enemy);
        }

    }



}
