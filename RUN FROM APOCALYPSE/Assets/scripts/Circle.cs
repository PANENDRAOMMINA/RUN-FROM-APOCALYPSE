using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{

    public static Circle instance;
    public bool slowdown;

    public void Awake()
    {
        if(instance==null)
        {
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!slowdown)
        {
            transform.Translate(5.5f * Time.deltaTime, -3f * Time.deltaTime, 0);
        }
        else
        {
            transform.Translate(0, -3f * Time.deltaTime, 0);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            Destroy(collision.gameObject);
            player.instance.isdead = true;
        }
        
       if(collision.gameObject.tag=="platform")
        {
            Destroy(gameObject);
        }
    }
}
