using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circlespawner : MonoBehaviour
{
    public GameObject circle;
    public bool startspawn;
    private BoxCollider2D br;
    public static circlespawner instance;
    private void Awake()
    {
        if(instance==null)
        {
            instance = this;
        }
        br = GetComponent<BoxCollider2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawn",0.5f,2f);
    }

    // Update is called once per frame
    void Update()
    {
        if (startspawn&&transform.position.x<729f)
        {
            transform.Translate(5.5f * Time.deltaTime, 0, 0);
        }
     
    }
    public void spawn()
    {
        if (startspawn)
        {
            float x1 = transform.position.x - br.bounds.size.x / 2f;
            float x2 = transform.position.x + br.bounds.size.x / 2f;
            Instantiate(circle, new Vector3(Random.Range(x1,x2) ,transform.position.y,0),Quaternion.identity);
        }
    }
}
