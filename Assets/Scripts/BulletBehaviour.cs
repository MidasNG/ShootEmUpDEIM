using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    [SerializeField] private float speed;
    private float xMax, yMax;
    private void Start()
    {
        yMax = Camera.main.orthographicSize;
        xMax = yMax / 9 * 16;
    }
    void Update()
    {
        transform.Translate(transform.right * speed * Time.deltaTime);
        if ((transform.position.x > xMax + 5 || transform.position.x < -xMax - 5) || (transform.position.y > yMax + 5 || transform.position.y < -yMax - 5)) Destroy(gameObject);
    }
}
