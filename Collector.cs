using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Collector : MonoBehaviour
{   
    public TextMeshProUGUI scoreText;
    public int Score = 0;
    void IncreaseScore(){
        Score = Score + 1;
        scoreText.text = "Score: " + Score;
    }

    void OnTriggerEnter2D(Collider2D Target){

        if(Target.tag == "Bomb"){
            Target.gameObject.SetActive(false);
            IncreaseScore() ;
        }
    }
    
}
