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

    //I tried to make it so that once the car touches the barrier it starts rotating
    //the barrier wasn't detecting the car making contact by using the debug.log
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("RaceCar touched barrier 2");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Trigger barrier 2");
        transform.Rotate(0, 0, -speed * Time.deltaTime);
    }
}
