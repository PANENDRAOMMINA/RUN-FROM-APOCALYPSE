using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorialcomplete : MonoBehaviour
{
    public GameObject goback;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="player")
        {
            Time.timeScale = 0f;
            goback.SetActive(true);
        }
    }
}
