using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestWand : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void test()
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = gameObject.transform.position;
        cube.transform.localScale = new Vector3(0.1f,0.1f,0.1f);
    }
}
