using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tunel : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        var player = other.gameObject.GetComponent<playerContlorer>();
        if (player != null)
        {
            SceneManager.LoadScene("SecendLevel");
        }
        Debug.Log("tunel");
    }
}
