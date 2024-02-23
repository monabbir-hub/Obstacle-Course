using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{    
    public float yValue = 0;
    public float moveSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        PrintInstruction();
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        
    }


    void PrintInstruction() 
    {
        Debug.Log("Welcome to the Obstacle Course");
        Debug.Log("Press WASD to move the player.");
        Debug.Log("Don't hit the walls");

    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal")*Time.deltaTime*moveSpeed;
        float zValue = Input.GetAxis("Vertical")*Time.deltaTime*moveSpeed;

        transform.Translate(xValue, yValue, zValue);

    }

}
