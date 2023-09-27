using UnityEngine;
using System.Collections;


public class scepter : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        var player = collision.gameObject.GetComponent<playerContlorer>();
        if (player != null)
        {
            player.AddPoint();
            Destroy(gameObject);
        }
    }
}

