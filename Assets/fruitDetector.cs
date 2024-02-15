using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruitDetector : MonoBehaviour
{

    [SerializeField]
    private string bucketType = ""; // what type of fruit the bucket flags as "correct".  fill this in on the inspector panel.

    public int fruitCounter = 0; // number of correct fruits.  public because I need to access this variable to display the score and getter methods are for chumps.

    
    private void OnTriggerEnter(Collider fruit)
    {
        Debug.Log(fruit.tag + " in da bucket");
        if(fruit.CompareTag(bucketType))
        {
            Debug.Log(bucketType + " detected, +1 points!");
            fruitCounter++;
        }
        else
        {
            Debug.Log("Hey, that's not a(n) " + bucketType + "!");
        }
        Destroy(fruit);
    }
}
