using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuOperator : MonoBehaviour
{
    [SerializeField] private int mapindex = 0;


    public void StartGame()
    {
        SceneChanger.Change(mapindex);
    }
    public void SceneChange(int mapindex)
    {
        SceneChanger.Change(mapindex);
    }

    public void ExitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
      Application.Quit();
#endif

    }

}

