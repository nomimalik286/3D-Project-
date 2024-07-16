using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorekeeper : MonoBehaviour
{
      int hits = 0;


    private void OnCollisionEnter(Collision other)

    {
        if (other.gameObject.tag != "Hit")
        { 
        hits++;
        Debug.Log("You are bumped into a thing this many time : " + hits);
       }

      }
}
