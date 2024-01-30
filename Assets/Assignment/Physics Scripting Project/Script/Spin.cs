using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    public float speed = 360f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,0, -speed * Time.deltaTime);
    }

    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.name == "RaceCar")
        {
            transform.Translate(Vector2.up * Time.deltaTime * speed);
        }
    }
}
