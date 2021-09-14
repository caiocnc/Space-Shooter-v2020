using System.Collections;
using UnityEngine;
public class Controle : MonoBehaviour
{
    public GameObject inimigos1;//Inimigo 1
    public GameObject inimigos2;//Inimigo 2
    public GameObject inimigos3;//Inimigo 3
    private GameObject inimigos;//Seleciona inimigo
    public Vector3 posInimigos; //Posi��o de in�cio da onda
    public int waveCount;// Quantidade de inimigos por onda
    public float startWave;// Tempo de espera para o in�cio do jogo
    public float esperaWave;//Tempo de espera entre ondas
    public float tempoNaves;//Tempo de espera entre Spawn de naves
    public float tempoWave;
    public GameObject powerUps;//Objeto PowerUp
    public Vector3 posPowerUps;//Posi��o do PowerUp
    private int proxInimigo = 0;//Quantidade total de inimigos at� pr�ximo inimigo
    void Start()
    {
        StartCoroutine(CriaInimigos());
    }//Inicia rotina secund�ria
    IEnumerator CriaInimigos()
    {//Possibilita ao programa criar pausas entre as
     // ondas
        yield return new WaitForSeconds(startWave); //Gera a Pausa
        while (true)
        { //Cria um la�o infinito enquanto for true=verdadeiro
            if (proxInimigo >= 0 && proxInimigo <= 6) { inimigos = inimigos1; }
            //Gernecia quantos loops ou voltas este inimigo ser� chamado
            if (proxInimigo >= 6 && proxInimigo <= 10) { inimigos = inimigos2; }
            if (proxInimigo >= 10 && proxInimigo <= 15) { inimigos = inimigos3; }
            if (proxInimigo <= 15)
            {//Informa que quando for maior que 15 n�o ser� mais
             // executado
                for (int i = 0; i < waveCount; i++)
                { // Contador de ondas
                    Vector3 spawInimigos = new Vector3(Random.Range(-posInimigos.x, posInimigos.x), posInimigos.y, inimigos.transform.position.z);//Cria posi��o para inimigo em
                                                                                                                                                  // posi��o rand�mica  na tela, dentro de um espa�o pr�-determinado.
                    Instantiate(inimigos, spawInimigos, inimigos.transform.rotation);//Inst�ncia
                                                                                     // inimigo
                    yield return new WaitForSeconds(tempoWave);
                }
            }else { proxInimigo = 0; }

        yield return new WaitForSeconds(esperaWave);//Gera a Pausa
            Vector3 spawPopwerUp = new Vector3(Random.Range(-posPowerUps.x, posPowerUps.x), posPowerUps.y, posPowerUps.z);//Gera posi��o
                                                                                                                          // rand�mica/aleat�ria para a posi��o do PowerUp
            Instantiate(powerUps, spawPopwerUp, powerUps.transform.rotation);//Inst�ncia PowerUp
            proxInimigo++;
        }
    }
}//Incrementa valor que gerencia a cria��o dos
 // inimigos