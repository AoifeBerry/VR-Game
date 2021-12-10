using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireAmmo : MonoBehaviour
{

    public GameObject FireAmmo1;
    public GameObject WaterAmmo;
    public GameObject BasicAmmo;
    public GameObject EarthAmmo;
    public GameObject WindAmmo;

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
            EarthAmmo.SetActive(false);
            WindAmmo.SetActive(false);
        }

        if (other.gameObject.tag == "WaterAmmo")
        {
            WaterAmmo.SetActive(true);
            FireAmmo1.SetActive(false);
            BasicAmmo.SetActive(false);
            EarthAmmo.SetActive(false);
            WindAmmo.SetActive(false);
        }
        if (other.gameObject.tag == "EarthAmmo")
        {
            WaterAmmo.SetActive(false);
            FireAmmo1.SetActive(false);
            BasicAmmo.SetActive(false);
            EarthAmmo.SetActive(true);
            WindAmmo.SetActive(false);
        }
        if(other.gameObject.tag == "WindAmmo")
        {
            WaterAmmo.SetActive(false);
            FireAmmo1.SetActive(false);
            BasicAmmo.SetActive(false);
            EarthAmmo.SetActive(false);
            WindAmmo.SetActive(true);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
