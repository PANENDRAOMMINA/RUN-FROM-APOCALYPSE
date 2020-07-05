using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingverticalplatform : MonoBehaviour
{
    // Start is called before the first frame update

    private float _y;
    private float amplitude = 2.5f;
    void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _y = Mathf.Sin(Time.time)*amplitude;
        transform.position =new Vector3(transform.position.x, _y, transform.position.y);
    }
}
