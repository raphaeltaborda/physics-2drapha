using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoLinear : MonoBehaviour
{
    private Rigidbody2D Rb2d;
    public float force;

    private void Awake()
    {
        Rb2d = GetComponent<Rigidbody2D>();
    }

    private void OnMouseDown()
    {
        Rb2d.AddForce(transform.right * force);
    }
}
