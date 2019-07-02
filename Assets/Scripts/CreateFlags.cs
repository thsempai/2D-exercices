using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateFlags : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Vector2 position = collision.contacts[0].point;
        GameObject flag = Resources.Load("flag") as GameObject;

        Vector3 position3D = new Vector3(position.x, position.y, 0f);

        Instantiate(flag, position3D, Quaternion.identity);
    }

}
