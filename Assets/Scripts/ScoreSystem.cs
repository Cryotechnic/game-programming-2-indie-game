using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
   public GameObject scoreText;
   public static int score;

    private void Start() {
        score = 0; // FIXME: Will this be reset every time the scene is loaded
    }
    // Update is called once per frame
    void Update()
    {
        scoreText.GetComponent<Text>().text = "Score: " + score;
    }
}
