using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoreDisplay : MonoBehaviour
{ 

    public int score = 0;

    public TMP_Text scoreTextMesh; // The TextMeshPro object to display, drag it in on the inspector

    public fruitDetector appleFruitDetector; // reference and name each bucket.  Public because I need to match each one in the inspector and [SerializeField] is for chumps.
    public fruitDetector orangeFruitDetector;
    public fruitDetector bananaFruitDetector;
    public fruitDetector cherryFruitDetector;
    public fruitDetector watermelonFruitDetector;


    // Update is called once per frame
    void Update()
    {
        // I know it's odd, but doing it this way allows score to be used for spawn rate
        int tempScore = 0;

        tempScore += appleFruitDetector.fruitCounter;
        tempScore += orangeFruitDetector.fruitCounter;
        tempScore += bananaFruitDetector.fruitCounter;
        tempScore += cherryFruitDetector.fruitCounter;
        tempScore += watermelonFruitDetector.fruitCounter;

        score = tempScore;


        scoreTextMesh.SetText("Score: " + score);
    }


}