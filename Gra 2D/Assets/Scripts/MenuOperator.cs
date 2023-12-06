using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuOperator : MonoBehaviour
{
    [SerializeField] private int mapindex = 0;

    void Awake()
    {
        gameObject.SetActive(false);
    }

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
        SceneChanger.Change(0);
    }
}
