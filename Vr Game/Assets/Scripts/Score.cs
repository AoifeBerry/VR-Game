using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{

    public float Scores;
    public TMP_Text ScoreText;
    public TextMeshProUGUI scoreT;
    public Text otherScore;
   

    // Start is called before the first frame update
    void Start()
    {
      
    }

    void update()
    {
        //Debug.Log(Scores);
        //scoreT.text = Scores.ToString();
        //otherScore.text = otherScore.ToString();
        //scoreT.ForceMeshUpdate(true);

    }

    public void AddScore()
    {
        Scores++;
        ScoreText.text = "Score = " + Scores.ToString();
    }

  
}
