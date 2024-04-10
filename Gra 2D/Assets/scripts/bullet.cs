
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float bulletSpeed = 50f;
    [SerializeField] private Rigidbody2D rb;

    void Start()
    {
        rb.velocity = transform.right * bulletSpeed;
        Destroy(gameObject, 3);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
        PlayerContlorer playerContlorer = collision.gameObject.GetComponent<PlayerContlorer>();
        BossBehaviour bossBehaviour = collision.gameObject.GetComponent<BossBehaviour>();
        if(playerContlorer != null || bossBehaviour != null)
        {
            Destroy(collision.gameObject);
        }
        Destroy(gameObject);

    }

}
