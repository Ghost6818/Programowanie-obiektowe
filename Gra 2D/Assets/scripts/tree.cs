using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        bullet bullet = collision.gameObject.GetComponent<bullet>();
        if (bullet != null)
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
