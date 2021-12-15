using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfFireHits : MonoBehaviour
{

    public GameObject fireParticle;
    public GameObject Healing;
    public GameObject EarthParticle;
    public GameObject AirParticle;
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
        if (other.tag == "FireProjectile")
        {
        
        Debug.Log("HittingFire");
            AirParticle.SetActive(true);
            StartCoroutine(AirAwake());

        }
        if (other.tag == "WaterProjectile")
        {

           // Debug.Log("healing");
            Healing.SetActive(true);
            StartCoroutine(HealingAwake());

        }
        if (other.tag == "EarthProjectile")
        {

            // Debug.Log("healing");
            EarthParticle.SetActive(true);
            StartCoroutine(EarthAwake());

        }
        if (other.tag == "AirProjectile")
        {

            // Debug.Log("healing");
            AirParticle.SetActive(true);
            StartCoroutine(AirAwake());

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
    IEnumerator AirAwake()
    {
        yield return new WaitForSeconds(4);
        AirParticle.SetActive(false);
    }
    IEnumerator EarthAwake()
    {
        yield return new WaitForSeconds(4);
        EarthParticle.SetActive(false);
    }
}
