using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnCollisionEnter(Collider collision)
    {
        foreach (ContactPoint contact in collision.contacts)
        {
            if (collision.gameObject.CompareTag("FireAmmo"))
            {
                Debug.DrawRay(contact.point, contact.normal, Color.white);
            }
        }
    }
}
