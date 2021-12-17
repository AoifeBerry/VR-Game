using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitGroundAir : MonoBehaviour
{
    public Transform bullet;
    public Rigidbody rb;
    public Transform Steam;
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
            Instantiate(Steam, bullet.transform.position, bullet.transform.rotation);
            Destroy(gameObject);

        }
        if (collision.gameObject.CompareTag("River"))
        {

            Destroy(gameObject);
            Instantiate(Steam, bullet.transform.position, bullet.transform.rotation);

            Destroy(gameObject);

        }
    }
}
