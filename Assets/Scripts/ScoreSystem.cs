using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreSystem : MonoBehaviour
{
   public GameObject scoreText;
   public GameObject levelName;
   public static int scoreLv1;
   public static int scoreLv2 = 0;
   int combinedScore = 0;

    private void Start() {
        // scoreLv1 = 0; // FIXME: Uncommenting this line WILL break the score system.
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        if ((SceneManager.GetActiveScene().name).ToString() == "Level1") {
            levelName.GetComponent<Text>().text = "Level 1";
        }
        else if ((SceneManager.GetActiveScene().name).ToString() == "Level2") {
            levelName.GetComponent<Text>().text = "Level 2";
        }
        else {
            Debug.Log("Error: Scene not found");
        }
    }
    // Update is called once per frame
    void Update()
    {
        // Checks which level is loaded
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        if ((SceneManager.GetActiveScene().name).ToString() == "Level1") {
            scoreText.GetComponent<Text>().text = "Score: " + scoreLv1;
        }
        else if ((SceneManager.GetActiveScene().name).ToString() == "Level2") {
            combinedScore = scoreLv1 + scoreLv2;
            scoreText.GetComponent<Text>().text = "Score: " + combinedScore;
        }
        else {
            Debug.Log("Error: Scene not found");
        }
        // scoreText.GetComponent<Text>().text = "Score: " + scoreLv1;
    }
}
