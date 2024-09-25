using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreController : MonoBehaviour {

    private int ScorePlayer1 = 0;
    private int ScorePlayer2 = 0;

    public GameObject scoreTextPlayer1;
    public GameObject scoreTextPlayer2;

    

    public int goalToWin;

    private void Update()
    {
        if (ScorePlayer1 >= goalToWin || ScorePlayer2 >= goalToWin)
        {
            Debug.Log("Game Won");
            SceneManager.LoadScene("GameOver");
        }

    }

    private void FixedUpdate()
    {
        //eğer bu bileşeni dinamik olarak oluşturuyorsanız veya değiştirecekseniz, GetComponent kullanmak daha uygun olabilir.
        Text uiScorePlayer1 = scoreTextPlayer1.GetComponent<Text>();
        uiScorePlayer1.text = ScorePlayer1.ToString();
        Text uiScorePlayer2 = scoreTextPlayer2.GetComponent<Text>();
        uiScorePlayer2.text = ScorePlayer2.ToString();
    }

    public void GoalPlayer1()
    {
        this.ScorePlayer1++;
    }
    public void GoalPlayer2()
    {
        this.ScorePlayer2++;
    }
}
