using UnityEditor.PackageManager;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float bulletSpeed = 50f;
    public Rigidbody2D rb;

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
