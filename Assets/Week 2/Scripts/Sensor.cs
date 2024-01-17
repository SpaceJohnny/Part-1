using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.UIElements.UxmlAttributeDescription;
using UnityEngine.U2D;

public class Sensor : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
            spriteRenderer.color = Color.green;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject + " is in the trigger");
        spriteRenderer.color = Color.red;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        spriteRenderer.color = Color.green;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
