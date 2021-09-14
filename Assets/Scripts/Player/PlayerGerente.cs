using UnityEngine; //Declaração de biblioteca.
[System.Serializable]//Determinada classe será serializada pelo sistema.
public class LimiteTela { public float xMin, xMax, yMin, yMax; }//São os valores de
// limite da tela, de onde a nave não poderá passar.

public class PlayerGerente : MonoBehaviour
{
    //PlayerGerente: Nome da classe
    // MonoBehaviour: é a classe base que todos os Scripts Unity derivam.
    public float velocidade;//Cria variável pública que aparecerá como novo campo
                            // no Script
    public LimiteTela limite;//Para usar as variáveis criadas na classe acima
    public GameObject botão;

    void FixedUpdate()
    { //Método da Unity que cria uma atualização fixa
        float horizontal = Input.GetAxis("Horizontal");//Recebe valores vindos das
                                                       //teclas A,D e setas a direita e esquerda.
        float vertical = Input.GetAxis("Vertical");//Recebe valores vindos das
                                                   //teclas W,S e setas para cima e baixo.

        Vector3 mover = new Vector3(horizontal, vertical, 0); //Cria novo vetor com os
                                                              // valores recebidos do teclado como Inputs do jogador.
        gameObject.GetComponent<Rigidbody2D>().velocity = mover * velocidade;
        //Componente Rigidbody 2D e velocidade recebe variável mover *  variável  
        // velocidade;
        gameObject.GetComponent<Rigidbody2D>().position = new Vector3(
            Mathf.Clamp(gameObject.GetComponent<Rigidbody2D>().position.x,
            limite.xMin, limite.xMax),
            Mathf.Clamp(gameObject.GetComponent<Rigidbody2D>().position.y,
            limite.yMin, limite.yMax), 0); //Não permite que a nave vá além dos limites estipulados pelos valores de xMin, xMax, yMin, yMax;

    }
    void OnDestroy()
    {

        botão.GetComponent<Restart>().setRestart(true);

    }

}
