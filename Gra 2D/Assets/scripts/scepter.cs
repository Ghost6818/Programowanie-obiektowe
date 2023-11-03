using UnityEngine;
using System.Collections;


public class Scepter : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        var player = collision.gameObject.GetComponent<PlayerContlorer>();
        if (player != null)
        {
            player.AddPoint();
            Destroy(gameObject);
        }
    }
}

