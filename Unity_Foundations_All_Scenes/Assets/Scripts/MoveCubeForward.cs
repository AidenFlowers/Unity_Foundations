using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCubeForward : MonoBehaviour
{   
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
    
        transform.position = transform.position + Vector3.forward * Time.deltaTime * speed;
    }
}
