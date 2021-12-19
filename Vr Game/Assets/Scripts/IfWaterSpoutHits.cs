using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfWaterSpoutHits : MonoBehaviour
{

    public Transform water;
    public Transform steam;
    public Transform rock;
    public Transform mud;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("GroundFire"))
        {

            Destroy(gameObject);
            Destroy(collision.gameObject);
            Instantiate(steam, water.transform.position, water.transform.rotation);


        }
        if (collision.gameObject.CompareTag("GroundRock"))
        {

            Destroy(gameObject);
            Destroy(collision.gameObject);
            Instantiate(mud, water.transform.position, Quaternion.identity);


        }
    }
}
