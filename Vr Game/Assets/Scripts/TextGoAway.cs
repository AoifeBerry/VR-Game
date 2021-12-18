using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextGoAway : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        StartCoroutine(textAwake());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator textAwake()
    {
        yield return new WaitForSeconds(10);
        Destroy(gameObject);
    }
}
