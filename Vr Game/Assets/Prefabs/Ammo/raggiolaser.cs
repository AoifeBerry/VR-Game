using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raggiolaser : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Ray ray = new Ray(transform.position, transform.forward);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
