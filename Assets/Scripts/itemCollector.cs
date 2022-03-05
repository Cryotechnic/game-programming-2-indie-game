using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemCollector : MonoBehaviour
{
    public AudioClip collectSound;

    void OnTriggerEnter(Collider other)
    {
        // Debug.Log("Collision");
        // if (other.gameObject.tag == "Player")
        // {
        //     AudioSource.PlayClipAtPoint(collectSound, transform.position);
        //     ScoreSystem.score += 50;
        //     Destroy(other.gameObject);
        //     Debug.Log("Item Collected");
        // }
        // if player collides with item, destroy item, add points to score, and play sound
        if (other.gameObject.tag == "Player")
        {
            AudioSource.PlayClipAtPoint(collectSound, transform.position);
            ScoreSystem.score += 50;
            Destroy(gameObject);
            Debug.Log("Item Collected");
        }
    }
}
