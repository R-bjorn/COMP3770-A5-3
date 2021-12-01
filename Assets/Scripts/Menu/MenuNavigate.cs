using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuNavigate : MonoBehaviour
{
    public void Play()
    {
        // SceneManager.LoadScene("Scenes/Level1");
    }

    public void Menu()
    {
        SceneManager.LoadScene("Scenes/Menu");
    }

    public void Controls()
    {
        SceneManager.LoadScene("Scenes/UI/Controls");
    }

    public void Score()
    {
        SceneManager.LoadScene("Scenes/UI/Score");
    }

    public void Exit()
    {
        SceneManager.LoadScene("Scenes/UI/Exit");
    }
}
