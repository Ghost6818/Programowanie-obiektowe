using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class SceneChanger
{
    public static void Change(int mapindex)
    {
        SceneManager.LoadScene(mapindex);
    }
}
