using UnityEngine;

public class Restart : MonoBehaviour
{

    public GameObject button;//Bot�o que criamos
    public GameObject buttonMenu;//Bot�o que criamos
    public GameObject GameOver; //Objeto Imagem GameOver

    void Start()
    {

        GameOver.SetActive(false); //Faz o objeto ficar invis�vel na tela
        
        buttonMenu.SetActive(false);
        
        button.SetActive(false); //Faz o objeto ficar invis�vel na tela

        Pontos.score = 00000;//Zera os pontos da tela

    }

    public void Reiniciar()
    { // Ativado pelo bot�o

        UnityEngine.SceneManagement.SceneManager.LoadScene("SpaceShooter");

        //Aqui chamamos nossa �Scene� que se chama SpaceShooter

        //Desta forma ele � reiniciada.

    }

    public void setRestart(bool r)
    {//Ativa com a destrui��o da nave do jogador

        GameOver.SetActive(r); // Faz o objeto ficar vis�vel
        
        buttonMenu.SetActive(r);

        button.SetActive(r);  // Faz o objeto ficar vis�vel

    }

}
