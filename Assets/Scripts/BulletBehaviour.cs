using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    [SerializeField] private float speed;
    private float xMax, yMax;
    private Rigidbody2D rb;
    void Start()
    {
        yMax = Camera.main.orthographicSize;
        xMax = yMax / 9 * 16;
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if ((transform.position.x > xMax + 5 || transform.position.x < -xMax - 5) || (transform.position.y > yMax + 5 || transform.position.y < -yMax - 5)) Destroy(gameObject);
    }
    private void FixedUpdate()
    {
        rb.velocity = transform.right * speed;
    }
}