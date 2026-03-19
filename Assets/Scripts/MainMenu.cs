using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject menuUI;

    void Start()
    {
        Time.timeScale = 0f; // Freeze game
        menuUI.SetActive(true);
    }

    public void StartGame()
    {
        menuUI.SetActive(false);
        Time.timeScale = 1f; // Resume game
    }
}