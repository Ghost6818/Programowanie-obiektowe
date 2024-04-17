using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CompleteLevel : MonoBehaviour

{
    public void OnLevelComplete(int startsAquired)
    {
        if(LevelMenager.currLevel == LevelMenager.UnlockedLevels)
        {
            LevelMenager.UnlockedLevels++;
            PlayerPrefs.SetInt("UnlockedLevels", LevelMenager.UnlockedLevels);
        }
        if (startsAquired > PlayerPrefs.GetInt("stars" + LevelMenager.currLevel.ToString()))
            PlayerPrefs.SetInt("stars" + LevelMenager.currLevel.ToString(), startsAquired);
            SceneManager.LoadScene("Map");
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
