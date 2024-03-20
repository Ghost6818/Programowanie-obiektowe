using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PanelContlorer : MonoBehaviour

{
    [SerializeField] private int mapindex = 0;

    void Awake()
    {
        gameObject.SetActive(false);
    }

    public void SceneChange()
    {
        SceneChanger.Change(mapindex);
    }
    public void SceneChange(int mapindex)
    {
        SceneChanger.Change(mapindex);

    }
    public void BackToManu()
    {
        SceneChanger.Change(0);
    }
    public void Restart()
    {
        SceneChanger.Reload();
    }
}
