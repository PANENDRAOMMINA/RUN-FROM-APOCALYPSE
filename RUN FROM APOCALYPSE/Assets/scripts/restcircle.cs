using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class restcircle : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="player")
        {
            Destroy(collision.gameObject);
            player.instance.isdead = true;
        }
    }
}
