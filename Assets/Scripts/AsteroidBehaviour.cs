using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidBehaviour : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private GameLogic score;
    private sfxController sfxController;
    private Rigidbody2D rb;

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
        Destroy(gameObject);
        score.ScoreUp();
        sfxController.DestroySFX();
    }

    public void SetSFXControllerAndGameLogic(sfxController sfxController, GameLogic gameLogic)
    {
        this.sfxController = sfxController;
        score = gameLogic;
    }
}
