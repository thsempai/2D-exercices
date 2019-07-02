using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    public float ForceUp = 500f;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Vector2 force = new Vector2(0f, ForceUp);
        collision.GetComponent<Rigidbody2D>().AddForce(force);
    }

}
