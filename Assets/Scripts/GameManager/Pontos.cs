using UnityEngine;

using TMPro;

public class Pontos : MonoBehaviour
{

    public static int score; //Variável que será usada

    // no “Script” Nave_Inimigo dentro do  if (vida <= 0)

    //  Adicione este comando: Pontos.score += 10;

    void Update()
    {

        gameObject.GetComponent<TextMeshPro>().SetText(" " + score);

        //Aqui o valor vai para a tela.

    }
}