using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float health = 100;
    private string tag;
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
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
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
            health -= 25;


    }
}
