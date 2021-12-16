using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public float Scores;
    public Text scoreT;
    public GameObject fire;
    public GameObject water;
    public GameObject earth;
    public GameObject air;


    // Start is called before the first frame update
    void Start()
    {
       //Scores = GetComponent<EnemyHealth>().Score;
    }

    void update()
    {
        Scores = fire.GetComponent<EnemyHealth>().Score;
        Scores = water.GetComponent<EnemyHealth>().Score;
        Scores = earth.GetComponent<EnemyHealth>().Score;
        Scores = air.GetComponent<EnemyHealth>().Score;
        scoreT.text = Scores.ToString();
    }

   
  
}
