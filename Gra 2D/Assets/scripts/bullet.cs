
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float bulletSpeed = 50f;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private SpriteRenderer spriteRenderer;


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
    public void initBulletSide(bool right)
    {
        Debug.Log("Hello position");
        rb.velocity =  right? transform.right * bulletSpeed : -transform.right * bulletSpeed;
        spriteRenderer.flipX = !right;
        Destroy(gameObject, 3);
    }

}
