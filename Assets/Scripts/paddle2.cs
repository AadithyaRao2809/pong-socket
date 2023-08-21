using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int hello = 2;
        if(Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(-10*Vector3.up * Time.deltaTime, Space.World);
        }
        if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(10*Vector3.up * Time.deltaTime, Space.World);
        }
    }
}
