using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tunel : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        var player = collision.gameObject.GetComponent<PlayerContlorer>();

        if (player != null && player.points != false)
        {
            panel.SetActive(true);   
        }
        Debug.Log("tunel");
    }
}
