using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    public Rigidbody2D rb;
    public LayerMask ground;
    public float mindistance;
    public bool isgrounded;
    public Transform feetpos;
    private Image fill;
    public int speed;
    public GameObject pause;
    public bool _ispaused=false;
    public static player instance;
    public bool isdead;

    public void Awake()
    {
        if(instance==null)
        {
            instance = this;
        }
    }
    // Start is called before the first frame update
    private void Start()
    {
        fill = GameObject.Find("charge").GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        isgrounded = Physics2D.OverlapCircle(feetpos.position, mindistance, ground);
        
        if(Input.GetKey(KeyCode.Space)&&isgrounded&&!_ispaused)
        {
            rb.velocity = Vector2.right * speed;
            
        }
        if(Input.GetMouseButtonDown(0)&&isgrounded&&!_ispaused)
        {
            if (fill.fillAmount > 0.5f)
            {
                fill.fillAmount -= 0.55f;
                Vector2 mouseposition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
                Vector2 v = Camera.main.ScreenToWorldPoint(mouseposition);
                transform.position = v;
                rb.velocity = Vector2.right * 0f;
            }
        }
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0f;
            pause.SetActive(true);
            _ispaused = true;
        }
        fill.fillAmount += 0.35f * Time.deltaTime;
      }
}
