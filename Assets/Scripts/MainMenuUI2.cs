using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuUI2 : MonoBehaviour
{
    [SerializeField] private Button backButton;

    private void Awake() {

        backButton.onClick.AddListener(() => {
            SceneManager.LoadScene("MainMenu");

        });

        Time.timeScale = 1f;
    }
}
