using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject panelMenu;
    public GameObject panelCreditos;

    public void StartGame()
    {
        SceneManager.LoadScene("EscenaCiudad");
    }

    public void ShowCredits()
    {
        panelMenu.SetActive(false);
        panelCreditos.SetActive(true);
    }

    public void BackToMenu()
    {
        panelCreditos.SetActive(false);
        panelMenu.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
