using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipPivot : MonoBehaviour
{
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    public void Rotate(float rotation)
    {
        rb.AddTorque(rotation);
    }
}
