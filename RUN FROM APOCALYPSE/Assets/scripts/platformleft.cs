using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using UnityEngine;

public class platformleft : MonoBehaviour
{
    // Start is called before the first frame update
     bool ismoved = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ismoved&&transform.position.x<730f)
        {
            transform.Translate(5.5f * Time.deltaTime, 0, 0);
        }
        else
        {
            transform.Translate(0, 0, 0);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            ismoved = true;
            circlespawner.instance.startspawn = true;
        }
    }
}
