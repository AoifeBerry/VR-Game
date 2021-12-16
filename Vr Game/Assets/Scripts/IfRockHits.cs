using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfRockHits : MonoBehaviour
{
    public Transform LavaRock;
    public Transform rock;
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
        if (collision.gameObject.CompareTag("GroundFire"))
        {

            Destroy(gameObject);
            Destroy(collision.gameObject);
            Instantiate(LavaRock, rock.transform.position, rock.transform.rotation);


        }
    }
}
