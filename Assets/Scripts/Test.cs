using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class Test : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    private SpriteRenderer spriteRenderer;
    [SerializeField] private float force = 5f;
    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        if(Input.GetKey(KeyCode.Space)) 
        {
            rigidBody.AddForce(new Vector2(0, force));
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        spriteRenderer.color = new Color(1, 0, 0);
    }
    private void OnTriggerStay2D(Collider2D collision)
    {

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        spriteRenderer.color = new Color(1, 1, 1);
    }

}
