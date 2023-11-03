
using UnityEngine;

public class Tree : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Bullet bullet = collision.gameObject.GetComponent<Bullet>();
        if (bullet != null)
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
