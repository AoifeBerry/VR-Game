using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomlySpawn : MonoBehaviour
{
    public GameObject spawn1;
    public GameObject spawn2;
    public GameObject spawn3;
    public GameObject spawn4;
    public GameObject spawn5;
    public GameObject Enemy1;
    public GameObject Enemy2;
    public GameObject Enemy3;
    public GameObject Enemy4;
    public float Rand = 0;
    public float whichEnemy = 0;
    public float Rand1 = 0;
    public float whichEnemy1 = 0;
    public float Rand2 = 0;
    public float whichEnemy2 = 0;
    public float Rand3 = 0;
    public float whichEnemy3 = 0;
    public float Rand4 = 0;
    public float whichEnemy4 = 0;

    // Start is called before the first frame update
    void Start()
    {
        Rand = 0;
        whichEnemy = 0;
        Rand1 = 0;
        whichEnemy1 = 0;
        Rand2 = 0;
        whichEnemy2 = 0;
        Rand3 = 0;
        whichEnemy3 = 0;
        Rand4 = 0;
        whichEnemy4 = 0;
        InvokeRepeating("randomSpawn1", 10, 2);
        InvokeRepeating("randomSpawn2", 10, 2);
        InvokeRepeating("randomSpawn3", 10, 2);
        InvokeRepeating("randomSpawn4", 60, 2);
        InvokeRepeating("randomSpawn5", 60, 2);
    }
    void Update()
    {
        Rand = 0;
        whichEnemy = 0;
        Rand1 = 0;
        whichEnemy1 = 0;
        Rand2 = 0;
        whichEnemy2 = 0;
        Rand3 = 0;
        whichEnemy3 = 0;
        Rand4 = 0;
        whichEnemy4 = 0;
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


            if (whichEnemy <= 100 && whichEnemy >= 76)
            {

               // Debug.Log("Which enemy" + whichEnemy);
                Enemy1 = Instantiate(Enemy1, spawn1.transform.position, spawn1.transform.rotation);
                Rand = 0;
                whichEnemy = 0;
            }
            if (whichEnemy <= 75 && whichEnemy >= 51)
            {
               // Debug.Log("Which enemy" + whichEnemy);
                Enemy2 = Instantiate(Enemy2, spawn1.transform.position, spawn1.transform.rotation);
                Rand = 0;
                whichEnemy = 0;
            }
            if (whichEnemy <= 50 && whichEnemy >= 26)
            {
                // Debug.Log("Which enemy" + whichEnemy);
                Enemy3 = Instantiate(Enemy3, spawn1.transform.position, spawn1.transform.rotation);
                Rand = 0;
                whichEnemy = 0;
            }
            if (whichEnemy <= 25 && whichEnemy >= 1)
            {
                // Debug.Log("Which enemy" + whichEnemy);
                Enemy4 = Instantiate(Enemy4, spawn1.transform.position, spawn1.transform.rotation);
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


            if (whichEnemy1 <= 100 && whichEnemy1 >= 76)
            {
              //  Debug.Log("Which enemy 1" + whichEnemy1);
                Enemy1 = Instantiate(Enemy1, spawn2.transform.position, spawn2.transform.rotation);
                Rand1 = 0;
                whichEnemy1 = 0;
            }
            else
            if (whichEnemy1 <= 75 && whichEnemy1 >= 51)
            {
               // Debug.Log("Which enemy 1 " + whichEnemy);
                Enemy2 = Instantiate(Enemy2, spawn2.transform.position, spawn2.transform.rotation);
                Rand1 = 0;
                whichEnemy1 = 0;
            }
            else
            if (whichEnemy1 <= 50 && whichEnemy1 >= 26)
            {
                // Debug.Log("Which enemy 1 " + whichEnemy);
                Enemy3 = Instantiate(Enemy3, spawn2.transform.position, spawn2.transform.rotation);
                Rand1 = 0;
                whichEnemy1 = 0;
            }
            else
            if (whichEnemy1 <= 25 && whichEnemy1 >= 1)
            {
                // Debug.Log("Which enemy 1 " + whichEnemy);
                Enemy4 = Instantiate(Enemy4, spawn2.transform.position, spawn2.transform.rotation);
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


            if (whichEnemy2 <= 100 && whichEnemy2 >= 76)
            {
               // Debug.Log("Which enemy 1" + whichEnemy2);
                Enemy1 = Instantiate(Enemy1, spawn3.transform.position, spawn3.transform.rotation);
                Rand2 = 0;
                whichEnemy2 = 0;
            }
            else
            if (whichEnemy2 <= 75 && whichEnemy2 >= 51)
            {
                //Debug.Log("Which enemy 1 " + whichEnemy);
                Enemy2 = Instantiate(Enemy2, spawn3.transform.position, spawn3.transform.rotation);
                Rand2 = 0;
                whichEnemy2 = 0;
            }
            else
            if (whichEnemy2 <= 50 && whichEnemy2 >= 26)
            {
                //Debug.Log("Which enemy 1 " + whichEnemy);
                Enemy3 = Instantiate(Enemy3, spawn3.transform.position, spawn3.transform.rotation);
                Rand2 = 0;
                whichEnemy2 = 0;
            }
            else
            if (whichEnemy2 <= 25 && whichEnemy2 >= 1)
            {
                //Debug.Log("Which enemy 1 " + whichEnemy);
                Enemy4 = Instantiate(Enemy4, spawn3.transform.position, spawn3.transform.rotation);
                Rand2 = 0;
                whichEnemy2 = 0;
            }
        }

    }
    void randomSpawn4()

    {

        Rand3 = Random.Range(0.01f, 100);


        if (Rand3 >= 90)
        {
            Rand3 = 0;
            // Debug.Log("random 2" + Rand2);
            whichEnemy3 = Random.Range(0.01f, 100);


            if (whichEnemy3 <= 100 && whichEnemy3 >= 76)
            {
                // Debug.Log("Which enemy 1" + whichEnemy2);
                Enemy1 = Instantiate(Enemy1, spawn4.transform.position, spawn4.transform.rotation);
                Rand3 = 0;
                whichEnemy3 = 0;
            }
            else
            if (whichEnemy3 <= 75 && whichEnemy3 >= 51)
            {
                //Debug.Log("Which enemy 1 " + whichEnemy);
                Enemy2 = Instantiate(Enemy2, spawn4.transform.position, spawn4.transform.rotation);
                Rand3 = 0;
                whichEnemy3 = 0;
            }
            else
            if (whichEnemy3 <= 50 && whichEnemy3 >= 26)
            {
                //Debug.Log("Which enemy 1 " + whichEnemy);
                Enemy3 = Instantiate(Enemy3, spawn4.transform.position, spawn4.transform.rotation);
                Rand3 = 0;
                whichEnemy3 = 0;
            }
            else
            if (whichEnemy3 <= 25 && whichEnemy3 >= 1)
            {
                //Debug.Log("Which enemy 1 " + whichEnemy);
                Enemy4 = Instantiate(Enemy4, spawn4.transform.position, spawn4.transform.rotation);
                Rand3 = 0;
                whichEnemy3 = 0;
            }
        }

    }
    void randomSpawn5()

    {

        Rand4 = Random.Range(0.01f, 100);


        if (Rand4 >= 90)
        {
            Rand4 = 0;
            // Debug.Log("random 2" + Rand2);
            whichEnemy4 = Random.Range(0.01f, 100);


            if (whichEnemy4 <= 100 && whichEnemy4 >= 76)
            {
                // Debug.Log("Which enemy 1" + whichEnemy2);
                Enemy1 = Instantiate(Enemy1, spawn5.transform.position, spawn5.transform.rotation);
                Rand4 = 0;
                whichEnemy4 = 0;
            }
            else
            if (whichEnemy4 <= 75 && whichEnemy4 >= 51)
            {
                //Debug.Log("Which enemy 1 " + whichEnemy);
                Enemy2 = Instantiate(Enemy2, spawn5.transform.position, spawn4.transform.rotation);
                Rand4 = 0;
                whichEnemy4 = 0;
            }
            else
            if (whichEnemy4 <= 50 && whichEnemy4 >= 26)
            {
                //Debug.Log("Which enemy 1 " + whichEnemy);
                Enemy3 = Instantiate(Enemy3, spawn5.transform.position, spawn5.transform.rotation);
                Rand4 = 0;
                whichEnemy4 = 0;
            }
            else
            if (whichEnemy4 <= 25 && whichEnemy4 >= 1)
            {
                //Debug.Log("Which enemy 1 " + whichEnemy);
                Enemy4 = Instantiate(Enemy4, spawn5.transform.position, spawn5.transform.rotation);
                Rand4 = 0;
                whichEnemy4 = 0;
            }
        }

    }
}
