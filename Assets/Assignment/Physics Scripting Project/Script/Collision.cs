using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public GameObject barrier;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
        private void OnCollisionEnter2D(Collision2D collision)
        //once a collision occurs, barrier is set to inactive in scene hierarchy 
        //the car must hit the barrier to continue racing
        {
            if (barrier.activeInHierarchy)
             {
                barrier.SetActive(false);
             }
                else
                {
                    barrier.SetActive(true);
                }
         }
}
