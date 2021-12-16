using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireAndWater : MonoBehaviour
{


    public Transform fire;
    public Transform water;
    public Transform steam;

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
            Debug.Log("steam");
            Destroy(gameObject);
            Destroy(collision.gameObject);
            Instantiate(steam, water.transform.position, water.transform.rotation);
            // Destroy(gameObject);

        }
    }
}
