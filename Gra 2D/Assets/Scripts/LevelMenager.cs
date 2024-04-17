using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMenager : MonoBehaviour

{
    public LevelObject[] levelObject;
    public Sprite goldenStars;
    public static int currLevel;
    public static int UnlockedLevels;
    public void OnClickLevel(int levelNum)
    {
        currLevel = levelNum;
        SceneManager.LoadScene("GameScene");
    }

    
    public void OnCLickBlock()
    {
        this.gameObject.SetActive(false);
    }

    void Start()
    {
        UnlockedLevels = PlayerPrefs.GetInt("UnlockedLevels", 0);
        for (int i = 0; i < levelObject.Length; i++)
        {
            if (UnlockedLevels >= i)
            {
                levelObject[i].levelButton.interactable=(true);
                int stars = PlayerPrefs.GetInt("stars" + i.ToString(), 0);
                for (int j = 0; j < stars; j++)
                {
                    levelObject[i].stars[j].sprite = goldenStars;
                }
            }
        }
    }
}
