using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuUI : MonoBehaviour
{
    [SerializeField] private Button playButton;
    [SerializeField] private Button quitButton;
    [SerializeField] private Button creditsButton;


    private void Awake() {
        playButton.onClick.AddListener(() => {
            SceneManager.LoadScene("FruitNinja");
            
        });

        quitButton.onClick.AddListener(() => {
            Application.Quit();

        });

        creditsButton.onClick.AddListener(() => {

            SceneManager.LoadScene("Credits");

        });


        Time.timeScale = 1f;
    }
}
