using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;

    private void Start(){
        var score = PlayerPrefs.GetInt("score");
        scoreText.text = score.ToString();
    }

    public void RestartGame(){
        SceneManager.LoadScene(1);
    }
    public void mainMenu(){
        SceneManager.LoadScene(0);
    }
}
