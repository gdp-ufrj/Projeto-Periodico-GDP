using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControllerScript : MonoBehaviour
{
    public GameObject MainMenu, CreditsDisplay, ControlsDisplay;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //funcao usada no botao de comecar
    public void StartButtonFunction()
    {
        SceneManager.LoadScene(1);
    }

    //funcao usada no botao de mostrar controles
    public void ControlsButtonFunction()
    {
        MainMenu.SetActive(false);
        ControlsDisplay.SetActive(true);
    }

    //funcao usada no botao de mostrar creditos
    public void CreditsButtonFunction()
    {
        MainMenu.SetActive(false);
        CreditsDisplay.SetActive(true);
    }

    //funcao usada no botao de sair do jogo
    public void ExitButtonFunction()
    {
        Application.Quit();
    }

    //funcao usada no botao de retornar pro menu principal
    public void ReturnButtonFunction()
    {
        MainMenu.SetActive(true);
        CreditsDisplay.SetActive(false);
        ControlsDisplay.SetActive(false);
    }
}