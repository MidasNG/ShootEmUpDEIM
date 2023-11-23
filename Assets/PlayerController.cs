using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 5.0f;
    Vector2 inputVector = Vector2.zero;
    Vector2 movementVector = Vector2.zero;
    private float yMax, xMax;
    void Start()
    {
        yMax = Camera.main.orthographicSize;
        xMax = yMax / 9 * 16;
    }

    // Update is called once per frame
    void Update()
    {
        inputVector = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        if (inputVector.magnitude > 1 ) inputVector.Normalize();
        movementVector = inputVector * speed * Time.deltaTime;
        transform.position = new Vector3(Mathf.Clamp(transform.position.x + movementVector.x, -xMax, xMax), Mathf.Clamp(transform.position.y + movementVector.y, -yMax, yMax), 0);
    }
}
