
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float bulletSpeed = 50f;
    [SerializeField] private Rigidbody2D rb;

    void Start()
    {
        rb.velocity = transform.right * bulletSpeed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
        Destroy(gameObject);
    }

}
