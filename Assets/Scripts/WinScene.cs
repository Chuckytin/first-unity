using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScene : MonoBehaviour
{

    void Start()
    {
        Invoke("LoadMainMenu", 3); //invoca el método a los 3 segundos
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MenuPrincipal");   
    }
    
}
