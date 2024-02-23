using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{

    public float xValue = 0;
    public float yValue = 1;
    public float zValue = 0;

   
    // Update is called once per frame
    void Update()
    {

        transform.Rotate(xValue, yValue, zValue);
        
    }
}
