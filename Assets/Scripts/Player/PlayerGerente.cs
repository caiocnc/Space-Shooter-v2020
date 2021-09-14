using UnityEngine; //Declara��o de biblioteca.
[System.Serializable]//Determinada classe ser� serializada pelo sistema.
public class LimiteTela { public float xMin, xMax, yMin, yMax; }//S�o os valores de
// limite da tela, de onde a nave n�o poder� passar.

public class PlayerGerente : MonoBehaviour
{
    //PlayerGerente: Nome da classe
    // MonoBehaviour: � a classe base que todos os Scripts Unity derivam.
    public float velocidade;//Cria vari�vel p�blica que aparecer� como novo campo
                            // no Script
    public LimiteTela limite;//Para usar as vari�veis criadas na classe acima
    public GameObject bot�o;

    void FixedUpdate()
    { //M�todo da Unity que cria uma atualiza��o fixa
        float horizontal = Input.GetAxis("Horizontal");//Recebe valores vindos das
                                                       //teclas A,D e setas a direita e esquerda.
        float vertical = Input.GetAxis("Vertical");//Recebe valores vindos das
                                                   //teclas W,S e setas para cima e baixo.

        Vector3 mover = new Vector3(horizontal, vertical, 0); //Cria novo vetor com os
                                                              // valores recebidos do teclado como Inputs do jogador.
        gameObject.GetComponent<Rigidbody2D>().velocity = mover * velocidade;
        //Componente Rigidbody 2D e velocidade recebe vari�vel mover *  vari�vel  
        // velocidade;
        gameObject.GetComponent<Rigidbody2D>().position = new Vector3(
            Mathf.Clamp(gameObject.GetComponent<Rigidbody2D>().position.x,
            limite.xMin, limite.xMax),
            Mathf.Clamp(gameObject.GetComponent<Rigidbody2D>().position.y,
            limite.yMin, limite.yMax), 0); //N�o permite que a nave v� al�m dos limites estipulados pelos valores de xMin, xMax, yMin, yMax;

    }
    void OnDestroy()
    {

        bot�o.GetComponent<Restart>().setRestart(true);

    }

}
