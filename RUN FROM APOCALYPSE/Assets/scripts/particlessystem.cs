using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particlessystem : MonoBehaviour
{
    // Start is called before the first frame update
   
    void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(6f*Time.deltaTime, 0, 0);    
     }
}
