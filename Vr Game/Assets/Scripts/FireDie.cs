using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireDie : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        StartCoroutine(FireAwake());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator FireAwake()
    {
        yield return new WaitForSeconds(6);
        Destroy(gameObject);
    }
}
