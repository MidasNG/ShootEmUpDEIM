using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidBehaviour : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D rb;
    [SerializeField] private Score score;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        transform.localScale = new Vector2(Random.Range(0.5f, 1.5f), Random.Range(0.5f, 1.5f));
    }

    void FixedUpdate()
    {
        rb.velocity = transform.right * speed;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        score.ScoreUp();
        Destroy(gameObject);
    }
}
