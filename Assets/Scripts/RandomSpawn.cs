using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    private float x;
    private float y;
    private Transform trans;
    // Use this for initialization
    void Start()
    {
        //sätter random nr för x och y variabeln 
        x = (Random.Range(-5f, 5));
        y = (Random.Range(-5f, 5));
        //och sedan flyttar spelaren till de värderna som bästämdes tidigare
        transform.position = new Vector2(x, y);
    }

    // Update is called once per frame
    void Update()
    {

    }

}
