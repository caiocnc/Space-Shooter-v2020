using UnityEngine;
public class Nave_Inimigo : MonoBehaviour
{
    public int vida;//Variável vida
    public float velocidade; //Variável velocidade
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
        {//Gerência o fim da tela
            Destroy(gameObject);//Retira a nave do jogo
                                //Com o jogo rodando podemos ver a nave sair da aba “Hierarchy”
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {//Verifica colisão
        if (other.gameObject.CompareTag("Player"))
        {//Busca a colisão com a nave do
         // jogador
            Destroy(other.gameObject);//Other é a nave do jogador, aqui ela é retirada do
                                      // jogo
            Instantiate(Explosao, other.gameObject.transform.position, other.gameObject.transform.rotation);
            Destroy(gameObject);// Aqui retiramos a nave do inimigo
        }
        if (other.gameObject.CompareTag("Tiro"))
        { //Gerência se o tiro acertou o inimigo
            Destroy(other.gameObject);//Other é o tiro, retira o tiro da nave do jogador
                                      // quando ela acerta a nave do inimigo
            Instantiate(Efeito_tiro, other.gameObject.transform.position, other.gameObject.transform.rotation);
            vida -= PlayerTiros.dano;// Diminui a vida da nave do inimigo em relação ao valor do // tiro do jogador. Aqui fazemos referência a variável da classe do Player
            if (vida <= 0)
            {//Gerência para saber se a nave do inimigo tem vida acima de zero
                Pontos.score += 10;
                Destroy(gameObject);// Caso não tenha vida acima de zero retira a nave
                Instantiate(Explosao, other.gameObject.transform.position, other.gameObject.transform.rotation);
            }
        }
    }
}
