using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;
using Unity.VisualScripting;


public class test_Q : MonoBehaviour
{
    public GameObject agent;
    public string environment;
    private object console;

    public void OnCollisionEnter(Collision collision)
    {
        double lr = 0.05;
        double df = 0.95;

        double[,] qtable ;
        qtable = new double[4, 9];
        
        Debug.Log(environment);
        

        environment = collision.gameObject.name;


    }
    void Start()
    {
    }


    void Update()
    {
        
    }
}
