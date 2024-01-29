using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{

    public int score = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Hit")
        {
            score++;
            Debug.Log("You've bumped into a thing this many times : " + score);
        }
    }
}
