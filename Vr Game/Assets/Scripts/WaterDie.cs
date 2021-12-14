using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterDie : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        StartCoroutine(WaterAwake());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator WaterAwake()
    {
        yield return new WaitForSeconds(2);
        Destroy(gameObject);
    }
}
