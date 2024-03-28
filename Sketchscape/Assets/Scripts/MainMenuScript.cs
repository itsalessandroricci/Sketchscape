using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public Text HighScoreText;
    // Start is called before the first frame update
    void Start()
    {
        HighScoreText.text = "High Score : " + PlayerPrefs.GetInt("HighScore").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadGameScene()
    {
        SceneManager.LoadScene("Assets/Scenes/SampleScene.unity");
    }
}
