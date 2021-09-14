using UnityEngine;

public class Restart : MonoBehaviour
{

    public GameObject button;//Botão que criamos
    public GameObject buttonMenu;//Botão que criamos
    public GameObject GameOver; //Objeto Imagem GameOver

    void Start()
    {

        GameOver.SetActive(false); //Faz o objeto ficar invisível na tela
        
        buttonMenu.SetActive(false);
        
        button.SetActive(false); //Faz o objeto ficar invisível na tela

        Pontos.score = 00000;//Zera os pontos da tela

    }

    public void Reiniciar()
    { // Ativado pelo botão

        UnityEngine.SceneManagement.SceneManager.LoadScene("SpaceShooter");

        //Aqui chamamos nossa “Scene” que se chama SpaceShooter

        //Desta forma ele é reiniciada.

    }

    public void setRestart(bool r)
    {//Ativa com a destruição da nave do jogador

        GameOver.SetActive(r); // Faz o objeto ficar visível
        
        buttonMenu.SetActive(r);

        button.SetActive(r);  // Faz o objeto ficar visível

    }

}
