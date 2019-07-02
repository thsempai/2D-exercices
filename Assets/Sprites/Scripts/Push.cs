using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Push : MonoBehaviour
{
    public float forceUp = 100f;
    // Start is called before the first frame update
    void Start()
    {
        Vector2 force2D = new Vector2(0f, forceUp);
        GetComponent<Rigidbody2D>().AddForce(force2D);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
