using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    public float speed= 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v =  Input.GetAxis("Vertical");
        Vector2 pos = transform.position;
        pos.x += h* speed * Time.deltaTime;
        pos.y += v* speed * Time.deltaTime;
        transform.position = pos;
    }
}
