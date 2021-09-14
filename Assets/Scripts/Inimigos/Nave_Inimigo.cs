using UnityEngine;
public class Nave_Inimigo : MonoBehaviour
{
    public int vida;//Vari�vel vida
    public float velocidade; //Vari�vel velocidade
    public GameObject Efeito_tiro;
    public GameObject Explosao;
    void Start()
    {
        gameObject.GetComponent<Rigidbody2D>().velocity = transform.up * velocidade;
        //Movimenta a nave para frente
    }
    void FixedUpdate()
    {
        if (transform.position.y < -5)
        {//Ger�ncia o fim da tela
            Destroy(gameObject);//Retira a nave do jogo
                                //Com o jogo rodando podemos ver a nave sair da aba �Hierarchy�
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {//Verifica colis�o
        if (other.gameObject.CompareTag("Player"))
        {//Busca a colis�o com a nave do
         // jogador
            Destroy(other.gameObject);//Other � a nave do jogador, aqui ela � retirada do
                                      // jogo
            Instantiate(Explosao, other.gameObject.transform.position, other.gameObject.transform.rotation);
            Destroy(gameObject);// Aqui retiramos a nave do inimigo
        }
        if (other.gameObject.CompareTag("Tiro"))
        { //Ger�ncia se o tiro acertou o inimigo
            Destroy(other.gameObject);//Other � o tiro, retira o tiro da nave do jogador
                                      // quando ela acerta a nave do inimigo
            Instantiate(Efeito_tiro, other.gameObject.transform.position, other.gameObject.transform.rotation);
            vida -= PlayerTiros.dano;// Diminui a vida da nave do inimigo em rela��o ao valor do // tiro do jogador. Aqui fazemos refer�ncia a vari�vel da classe do Player
            if (vida <= 0)
            {//Ger�ncia para saber se a nave do inimigo tem vida acima de zero
                Pontos.score += 10;
                Destroy(gameObject);// Caso n�o tenha vida acima de zero retira a nave
                Instantiate(Explosao, other.gameObject.transform.position, other.gameObject.transform.rotation);
            }
        }
    }
}
