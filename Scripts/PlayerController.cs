using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private int score;
    [SerializeField] private TextMeshProUGUI scoreText;

    private void Awake(){
        score=0;
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.CompareTag("bonus"))
        {
            score++;
            scoreText.text = score.ToString();
            Destroy(collision.gameObject);
        }

        if(collision.gameObject.CompareTag("enemy")){
            PlayerPrefs.SetInt("score",score);
            score=0;
            SceneManager.LoadScene(2);
        }


    }
}
