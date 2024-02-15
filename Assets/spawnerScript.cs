using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerScript : MonoBehaviour
{

    public float fruitRate = 3.0f;
    private float nextFruit = 0.0f;
    public int fruitCounter = 0;
    private int scoreMilestone = 5;

    private SpawnFromList fruitSpawner;
    [SerializeField]
    public scoreDisplay scoreTracker;

    // Start is called before the first frame update
    void Start()
    {
        fruitSpawner = GetComponent<SpawnFromList>(); // Jackson helped me with this line, which probably explains why it is actually a rare instance of good coding practice.
        fruitCounter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > nextFruit)
        {
            nextFruit = Time.time + fruitRate;
            fruitSpawner.SpawnRandom();
            fruitCounter++;
            if(scoreTracker.score == scoreMilestone && fruitRate > 1f) // speed up the fruit rate every 5 points, up to a limit
            {
                scoreMilestone += 5;
                fruitRate = fruitRate - 0.5f;
            }
        }
    }
}
