using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float force = 5, torque = 5;
    [SerializeField] private BulletBehaviour bullet;
    [SerializeField] private Transform bulletParent;
    [SerializeField] private sfxController sfxController;
    [SerializeField] private GameLogic gameLogic;
    private float yMax, xMax, reload, reloadMod;
    private Rigidbody2D rb;

    void Start()
    {
        yMax = Camera.main.orthographicSize;
        xMax = yMax / 9 * 16;
        reload = 0;
        reloadMod = 4;
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        reload = Mathf.Clamp(reload + Time.deltaTime * reloadMod, 0, 1);
        if (Input.GetAxis("Fire") > 0 && reload == 1)
        {
            Instantiate(bullet, transform.right / 2 + transform.position, transform.rotation, bulletParent);
            reload = 0;
            sfxController.ShootSFX();
        }
    }

    private void FixedUpdate()
    {
        rb.AddForce(transform.right * Input.GetAxis("Vertical") * force);
        rb.AddTorque(-Input.GetAxis("Horizontal") * torque);

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -xMax, xMax), Mathf.Clamp(transform.position.y, -yMax, yMax), 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        gameLogic.GameOver();
    }
}
