using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    public GameObject rockPrefab;
    public Transform RockLocation;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //testing out prefab to instantiate 
    //When the player crosses the finish line, a rock prefab will appear on the top lane 
    //so it will look like two rocks are together 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == ("RaceCar"))
        {
            Instantiate(rockPrefab, RockLocation.position, RockLocation.rotation);
        }
    }
}