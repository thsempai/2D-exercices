using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    public float forceUp = 500f;
    public float forceRight = 100f; 
    public float abc;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Vector2 force = new Vector2(forceRight, forceUp);
        collision.GetComponent<Rigidbody2D>().AddForce(farce);
    }

}
