using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurnPlant : MonoBehaviour
{
    public GameObject fireParticle;
    public GameObject burnt;
    public GameObject notburnt;
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


            fireParticle.SetActive(true);
            burnt.SetActive(true);
            notburnt.SetActive(false);



        }
    }
}
