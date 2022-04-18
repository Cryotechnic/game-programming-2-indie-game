using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountdownTimer : MonoBehaviour
{
   public int countdownTime;
   public Text countdownText;

   private void Start() {
       StartCoroutine(countdownTimeLeft());   
   }
   
   IEnumerator countdownTimeLeft(){
         while(countdownTime > 0){
             countdownText.text = countdownTime.ToString();
             yield return new WaitForSeconds(1f);
             countdownTime--;
    }
    countdownText.text = "Time's Up!";
    yield return new WaitForSeconds(1f);
    countdownText.text = "Restarting level...";
    // Sleep for 3 seconds
    yield return new WaitForSeconds(3f);
    SceneManager.LoadScene("Level1");
   }
}
