using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUIHandler : MonoBehaviour
{
    public Button StartButton;
    public TMP_InputField NameInputField;
    public Button ExitButton;

    private Text NameText;

    // Start is called before the first frame update
    void Start()
    {
        NameInputField.Select();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(NameInputField.text == "")
        {
            StartButton.interactable= false;
        }
        else
        {
            StartButton.interactable = true;
            DataManager.Instance.PlayerName= NameInputField.text;
        }

    }

    public void StartNewScene()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif

    }
}
