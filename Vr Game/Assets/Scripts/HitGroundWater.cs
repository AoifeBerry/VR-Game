using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitGroundWater : MonoBehaviour
{
    public Transform bullet;
    public Rigidbody rb;
    public Transform water;
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
        if (collision.gameObject.CompareTag("Ground"))
        {
            Debug.Log("Ground");
            Destroy(gameObject);
            // rb.constraints = RigidbodyConstraints.FreezeAll;
            Instantiate(water, bullet.transform.position, bullet.transform.rotation);
            Destroy(gameObject);

        }
        if (collision.gameObject.CompareTag("River"))
        {
            //Debug.Log("Ground");
            Destroy(gameObject);
            // rb.constraints = RigidbodyConstraints.FreezeAll;
            Instantiate(water, bullet.transform.position, bullet.transform.rotation);
            Destroy(gameObject);

        }
    }
}
