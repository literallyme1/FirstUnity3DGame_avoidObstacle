using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArenaToMove : MonoBehaviour
{
    [SerializeField] float xAngle = 0f;
    [SerializeField] float yAngle = 0f;
    [SerializeField] float zAngle = 0f;
    [SerializeField] float waitToMove = 0f;
    [SerializeField] int angleThreshold = 0;




    private void Start()
    {
        xAngle = 0.01f;
        //zAngle = 0.01f;
    }

    void Update()
    {

        if (Time.time > waitToMove)
        {

            if(angleThreshold > 3000) 
            {
                xAngle *= -1;
                angleThreshold = 0;
            }
            transform.Rotate(xAngle, yAngle, zAngle);
            angleThreshold++;
        }
    }
}


