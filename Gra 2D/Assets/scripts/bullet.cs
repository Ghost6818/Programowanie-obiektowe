
using UnityEngine;

public enum CharacterType
{
    player,
    boss
}
public class Bullet : MonoBehaviour
{
    [SerializeField] private float bulletSpeed = 50f;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private CharacterType booletOwner;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
        PlayerContlorer playerContlorer = collision.gameObject.GetComponent<PlayerContlorer>();
        BossBehaviour bossBehaviour = collision.gameObject.GetComponent<BossBehaviour>();
        if((playerContlorer != null && booletOwner == CharacterType.boss) ||
            (bossBehaviour != null && booletOwner == CharacterType.player))
        {
           Destroy(collision.gameObject);
        }
        Destroy(gameObject);

    }
    public void initBulletSide(bool right = true)
    {
        rb.velocity =  right? transform.right * bulletSpeed : -transform.right * bulletSpeed;
        spriteRenderer.flipX = !right;
        Destroy(gameObject, 3);
    }

}
