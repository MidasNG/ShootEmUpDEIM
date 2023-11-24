using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed, rotateSpeed;
    [SerializeField] private BulletBehaviour bullet;
    [SerializeField] private Transform bulletParent;
    private float yMax, xMax;
    void Start()
    {
        yMax = Camera.main.orthographicSize;
        xMax = yMax / 9 * 16;
    }
    void Update()
    {
        if (Input.GetAxis("Vertical") != 0) transform.Translate(Input.GetAxis("Vertical") * speed * Time.deltaTime, 0, 0);
        if (Input.GetAxis("Horizontal") != 0) transform.Rotate(0, 0, -Input.GetAxis("Horizontal") * Time.deltaTime * rotateSpeed);

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -xMax, xMax), Mathf.Clamp(transform.position.y, -yMax, yMax), 0);
    }
    private void FixedUpdate()
    {
        if (Input.GetAxis("Fire") > 0) Instantiate(bullet, transform.right / 2 + transform.position, Quaternion.Euler(transform.eulerAngles / 2), bulletParent);
    }
}
