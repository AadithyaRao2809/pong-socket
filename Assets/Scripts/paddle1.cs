using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(-10*Vector3.up * Time.deltaTime, Space.World);
        }
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(10*Vector3.up * Time.deltaTime, Space.World);
        }
    }
}
