using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tunel : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        var player = collision.gameObject.GetComponent<playerContlorer>();

        if (player != null && player.points != false)
        {
            SceneManager.LoadScene("SecendLevel");
        }
        Debug.Log("tunel");
    }
}
