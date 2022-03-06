using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class itemCollector : MonoBehaviour
{
    public AudioClip collectSound;
    public static int gemCountLevel1;
    public static int gemCountLevel2;

    private void Start() {
        gemCountLevel1 = 8;
        gemCountLevel2 = 8;
    }

    private void Update() {
        if (gemCountLevel1 == 0) {
            SceneManager.LoadScene("Level2");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            AudioSource.PlayClipAtPoint(collectSound, transform.position);
            ScoreSystem.score += 50;
            Destroy(gameObject);
            Scene currentScene = SceneManager.GetActiveScene();
            string sceneName = currentScene.name;   
            if ((SceneManager.GetActiveScene().name).ToString() == "Level1") {
                gemCountLevel1--;
            }
            else if ((SceneManager.GetActiveScene().name).ToString() == "Level2") {
                gemCountLevel2--;
            }
            else {
                Debug.Log("Error: Scene not found");
            }
        }
    }
}
