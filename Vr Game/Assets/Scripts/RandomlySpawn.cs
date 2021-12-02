using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomlySpawn : MonoBehaviour
{
    public GameObject spawn1;
    public GameObject spawn2;
    public GameObject spawn3;
    public GameObject Enemy1;
    public GameObject Enemy2;
    public float Rand = 0;
    public float whichEnemy = 0;
    public float Rand1 = 0;
    public float whichEnemy1 = 0;
    public float Rand2 = 0;
    public float whichEnemy2 = 0;

    // Start is called before the first frame update
    void Start()
    {
        Rand = 0;
        whichEnemy = 0;
        Rand1 = 0;
        whichEnemy1 = 0;
        Rand2 = 0;
        whichEnemy2 = 0;
        InvokeRepeating("randomSpawn1", 1, 1);
        InvokeRepeating("randomSpawn2", 1, 1);
        InvokeRepeating("randomSpawn3", 1, 1);
    }
    void Update()
    {
        Rand = 0;
        whichEnemy = 0;
        Rand1 = 0;
        whichEnemy1 = 0;
        Rand2 = 0;
        whichEnemy2 = 0;
    }

    // Update is called once per frame
    void Awake()
    {
        // StartCoroutine(randomSpawn());
    }

    void randomSpawn1()

    {

        Rand = Random.Range(0.01f, 100);


        if (Rand >= 90)
        {
           // Debug.Log("random" + Rand);
            Rand = 0;
            whichEnemy = Random.Range(0.01f, 100);


            if (whichEnemy <= 100 && whichEnemy >= 51)
            {

               // Debug.Log("Which enemy" + whichEnemy);
                Enemy1 = Instantiate(Enemy1, spawn1.transform.position, spawn1.transform.rotation);
                Rand = 0;
                whichEnemy = 0;
            }
            if (whichEnemy <= 100 && whichEnemy >= 51)
            {
               // Debug.Log("Which enemy" + whichEnemy);
                Enemy2 = Instantiate(Enemy2, spawn1.transform.position, spawn1.transform.rotation);
                Rand = 0;
                whichEnemy = 0;
            }
        }

    }
    void randomSpawn2()

    {

        Rand1 = Random.Range(0.01f, 100);


        if (Rand1 >= 90)
        {
            Rand1 = 0;
           // Debug.Log("random 2" + Rand1);
            whichEnemy1 = Random.Range(0.01f, 100);


            if (whichEnemy1 <= 100 && whichEnemy1 >= 51)
            {
              //  Debug.Log("Which enemy 1" + whichEnemy1);
                Enemy1 = Instantiate(Enemy1, spawn2.transform.position, spawn2.transform.rotation);
                Rand1 = 0;
                whichEnemy1 = 0;
            }
            else
            if (whichEnemy1 <= 50 && whichEnemy1 >= 1)
            {
               // Debug.Log("Which enemy 1 " + whichEnemy);
                Enemy2 = Instantiate(Enemy2, spawn2.transform.position, spawn2.transform.rotation);
                Rand1 = 0;
                whichEnemy1 = 0;
            }
        }

    }

    void randomSpawn3()

    {

        Rand2 = Random.Range(0.01f, 100);


        if (Rand2 >= 90)
        {
            Rand2 = 0;
           // Debug.Log("random 2" + Rand2);
            whichEnemy2 = Random.Range(0.01f, 100);


            if (whichEnemy2 <= 100 && whichEnemy2 >= 60)
            {
               // Debug.Log("Which enemy 1" + whichEnemy2);
                Enemy1 = Instantiate(Enemy1, spawn3.transform.position, spawn3.transform.rotation);
                Rand2 = 0;
                whichEnemy2 = 0;
            }
            else
            if (whichEnemy2 <= 59 && whichEnemy2 >= 1)
            {
                //Debug.Log("Which enemy 1 " + whichEnemy);
                Enemy2 = Instantiate(Enemy2, spawn3.transform.position, spawn3.transform.rotation);
                Rand2 = 0;
                whichEnemy2 = 0;
            }
        }

    }
}
