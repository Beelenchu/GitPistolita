using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    int score;
    public Text scoreText;

  
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        UpdateScore();

        
    }

    // Update is called once per frame
    void UpdateScore()
    {
        scoreText.text = "Puntaje: " + score;
        Debug.Log("score " + score);
    }
    public void AddScore(int valor)
    {
        score += valor;
        UpdateScore();
        
    }

  
   

}
