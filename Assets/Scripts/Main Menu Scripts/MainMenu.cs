using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Text playerNameField;
    public Text bestScoreText;

    private void Start()
    {
        bestScoreText.text = "Best Score : " + Manager.instance.bestPlayerName + " : " + Manager.instance.bestScore;
    }

    public void StartNew()
    {
        Manager.instance.playerName = playerNameField.text;
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        Manager.instance.SaveBestScore();
        //Manager.Instance.SaveColor();
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }
}
