using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Red : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    //Rocks change colour when rock prefab collides with the car
    private void OnTriggerEnter2D(Collider2D other)
    {
        spriteRenderer.color = Color.red;
    }
}
