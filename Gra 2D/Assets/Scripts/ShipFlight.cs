using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipFlight : MonoBehaviour
{
    [SerializeField] private float upwardForce = 10f;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerContlorer playerContlorerCollised = collision.gameObject.GetComponent<PlayerContlorer>();
        if (playerContlorerCollised != null)
        {
            Destroy(collision.gameObject);

            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            if (rb == null)
            {
                rb = gameObject.AddComponent<Rigidbody2D>();
            }

            rb.velocity = new Vector2(0f, rb.velocity.y);

            rb.AddForce(Vector2.up * upwardForce, ForceMode2D.Impulse);
        }
    }

}
