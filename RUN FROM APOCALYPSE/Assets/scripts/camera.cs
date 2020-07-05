using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class camera : MonoBehaviour
{
    // Start is called before the first frame update

    public int speed;
    void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed*Time.deltaTime, 0, 0);
    }
}
