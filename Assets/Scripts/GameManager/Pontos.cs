using UnityEngine;

using TMPro;

public class Pontos : MonoBehaviour
{

    public static int score; //Vari�vel que ser� usada

    // no �Script� Nave_Inimigo dentro do  if (vida <= 0)

    //  Adicione este comando: Pontos.score += 10;

    void Update()
    {

        gameObject.GetComponent<TextMeshPro>().SetText(" " + score);

        //Aqui o valor vai para a tela.

    }
}