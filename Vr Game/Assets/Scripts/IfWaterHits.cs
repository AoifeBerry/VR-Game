using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfWaterHits : MonoBehaviour
{

    public GameObject WaterParticle;
    public GameObject Healing;
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
        if ((other.tag == "WaterProjectile") || (other.tag == "GroundWater"))
        {

            //Debug.Log("HittingWater");
            WaterParticle.SetActive(true);
            StartCoroutine(WaterAwake());

        }
        if ((other.tag == "FireProjectile") || (other.tag == "GroundFire"))
        {

           // Debug.Log("healing");
            Healing.SetActive(true);
            StartCoroutine(HealingAwake());

        }
    }
    IEnumerator WaterAwake()
    {
        yield return new WaitForSeconds(4);
        WaterParticle.SetActive(false);
    }
    IEnumerator HealingAwake()
    {
        yield return new WaitForSeconds(4);
        Healing.SetActive(false);
    }
}
