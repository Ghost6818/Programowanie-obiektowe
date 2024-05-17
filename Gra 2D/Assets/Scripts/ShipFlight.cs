using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipFlight : MonoBehaviour
{
    [SerializeField] private float upwardForce = 16f;
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

            //rb.constraints = RigidbodyConstraints2D.FreezeRotation | RigidbodyConstraints2D.FreezePositionX;

            //rb.AddForce(Vector2.up * upwardForce, ForceMode2D.Impulse);
            rb.velocity = new Vector2(rb.velocity.y, upwardForce);
        }
    }

}
