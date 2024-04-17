using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destrObstacle : MonoBehaviour
{
    [SerializeField] private Transform startPoint;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerContlorer playerContlorerCollised = collision.gameObject.GetComponent<PlayerContlorer>(); 
        if (playerContlorerCollised != null)
        {
            collision.gameObject.transform.position = startPoint.transform.position;

            Rigidbody2D playerRigidbody = collision.gameObject.GetComponent<Rigidbody2D>();
            playerRigidbody.velocity = Vector2.zero;
        }
    }
}
