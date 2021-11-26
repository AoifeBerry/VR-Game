using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireAmmo : MonoBehaviour
{

    public GameObject FireAmmo1;
    public GameObject WaterAmmo;
    public GameObject BasicAmmo; 

    // Start is called before the first frame update
    void Start()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "FireAmmo")
        {
            FireAmmo1.SetActive(true);
            WaterAmmo.SetActive(false);
            BasicAmmo.SetActive(false);
        }

        if (other.gameObject.tag == "WaterAmmo")
        {
            WaterAmmo.SetActive(true);
            FireAmmo1.SetActive(false);
            BasicAmmo.SetActive(false);
        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
