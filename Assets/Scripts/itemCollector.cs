using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class itemCollector : MonoBehaviour
{
    public AudioClip collectSound;
    public static int gemCount;

    private void Start() {
        gemCount = 1;   
    }

    private void Update() {
        if (gemCount == 0) {
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
            gemCount--;
        }
    }
}
