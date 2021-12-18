using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EnemyHealth : MonoBehaviour
{
    public float health = 100;
    public float Score = 0;
    private string tag;
    //public GameObject THETEXT;
    public TMP_Text scoreT;
   // public TMP_Text scoreT2;
    // Start is called before the first frame update
    void Start()
    {
        tag = gameObject.tag;
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            GameObject.Find("Scoreing").GetComponent<Score>().AddScore();
            //THETEXT.SendMessage("AddScore");
            Debug.Log(Score);
            Destroy(gameObject);
            
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "WaterProjectile" || other.tag == "EarthProjectile" || other.tag == "FireProjectile" || other.tag == "WindProjectile" ) {
            if (((other.tag == "WaterProjectile") && (tag == "EnemyFire")) || ((other.tag == "FireProjectile") && (tag == "EnemyWater")) || ((other.tag == "EarthProjectile") && (tag == "EnemyAir")) || ((other.tag == "WindProjectile") && (tag == "EnemyEarth")))
            {
                health -= 50;
            }
            else
            if (((other.tag == "WaterProjectile") && (tag == "EnemyWater")) || ((other.tag == "FireProjectile") && (tag == "EnemyFire")) || ((other.tag == "WindProjectile") && (tag == "EnemyAir")) || ((other.tag == "EarthProjectile") && (tag == "EnemyEarth")))
            {
                health += 25;
            }
            else
            {
                health -= 25;
            }
            
        }
        if ((other.tag == "FireMud" && tag == "EnemyWater") || (other.tag == "FireMud" && tag == "EnemyAir"))
            health -= 50;
    }
}
