using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HittingAir : MonoBehaviour
{

    public GameObject fireParticle;
    public GameObject Healing;
    public GameObject WaterParticle;
    public GameObject EarthParticle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
 
    void OnTriggerEnter(Collider other)
    {
        if ((other.tag == "FireProjectile") || (other.tag == "GroundFire"))
        {

           // Debug.Log("HittingFire");
            fireParticle.SetActive(true);
            StartCoroutine(FireAwake());

        }
        if ((other.tag == "WaterProjectile") || (other.tag == "GroundWater"))
        {

            // Debug.Log("healing");
            WaterParticle.SetActive(true);
            StartCoroutine(WaterAwake());

        }
        if ((other.tag == "EarthProjectile") || (other.tag == "GroundMud"))
        {

            // Debug.Log("healing");
            EarthParticle.SetActive(true);
            StartCoroutine(EarthAwake());

        }
        if (other.tag == "AirProjectile")
        {

            // Debug.Log("healing");
            Healing.SetActive(true);
            StartCoroutine(HealingAwake());

        }
    }
    IEnumerator FireAwake()
    {
        yield return new WaitForSeconds(4);
        fireParticle.SetActive(false);
    }
    IEnumerator HealingAwake()
    {
        yield return new WaitForSeconds(4);
        Healing.SetActive(false);
    }
    IEnumerator WaterAwake()
    {
        yield return new WaitForSeconds(4);
        WaterParticle.SetActive(false);
    }
    IEnumerator EarthAwake()
    {
        yield return new WaitForSeconds(4);
        EarthParticle.SetActive(false);
    }
}


