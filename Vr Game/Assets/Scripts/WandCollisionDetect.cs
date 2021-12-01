using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WandCollisionDetect : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.CompareTag("FireAmmo"))
        {
            gameObject.tag = "FireWand";
            //gameObject.GetComponent<Renderer>().material.color = new Color(255, 0, 0);
        }

        if (collision.gameObject.CompareTag("WaterAmmo"))
        {
            gameObject.tag = "WaterWand";
            //gameObject.GetComponent<Renderer>().material.color = new Color(0, 0, 255);
        }
    }
}

