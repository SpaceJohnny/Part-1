using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    Rigidbody2D rigidbody;
    float acceleration;
    float steering;
    public float forwardSpeed = 300;
    public float steeringSpeed = 30;
    public float maxSpeed = 250;
    
    //additional thruster key 
    //used to give a boost for the player
    //thrusterForce is at 500 to allow the player to feel the change between regular speed
    public float thrusterForce = 500;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        acceleration = Input.GetAxis("Vertical");
        steering = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        rigidbody.AddTorque(steering * -steeringSpeed * Time.deltaTime);
        Vector2 force = transform.up * acceleration * forwardSpeed * Time.deltaTime;
        if (rigidbody.velocity.magnitude < maxSpeed)
        {
            rigidbody.AddForce(force);
        }

        //if space key is pressed the thruster is engaged
        //.AddRelativeForce is used to push the car upwards by multiplying value of force (500) with time
        if (Input.GetKey(KeyCode.Space))
        {
            rigidbody.AddRelativeForce(Vector2.up * thrusterForce * Time.deltaTime);
        }
    }
}
