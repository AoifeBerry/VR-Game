using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfFireHits : MonoBehaviour
{

    public GameObject fireParticle;
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
            fireParticle.SetActive(true);
            StartCoroutine(FireAwake());

        }
    }
    IEnumerator FireAwake()
    {
        yield return new WaitForSeconds(4);
        fireParticle.SetActive(false);
    }
}
