using UnityEngine;
public class PlayerTiros : MonoBehaviour
{
    public GameObject shot;// Neste campo colocaremos o Tiro.
    public Transform shotSpaw;//Neste campo o SpawnShoot.
    public float tempo_Entre_Tiros;// Valor determina o tempo entre os tiros.
    private float proximoTiro; // Variável privada não aparece na Unity
    public int tiroDano;// Variável que será usada para vermos através do Script seu
                        // valor mudar.
    public static int dano = 5;//Variável que será usada para receber os PowerUps
                               //Por ser Static ou estática, esta variável pode ser acessada por outras classes, // sem ser instanciada.
    private float tempoPowerUp; // Tempo que o PowerUp vai funcionar.
    private bool timesUp = false; // Gerencia se o PowerUp foi usado. Pode ser
                                  // verdadeira ou falsa.
    void Update()
    {//Este tipo de Update é feito antes do FixedUpdate.
        if (Time.time > proximoTiro)
        {//Verifica se já é tempo de dar o próximo tiro.
            proximoTiro = Time.time + tempo_Entre_Tiros;//Recebe o valor do tempo
                                                        //agora com uma adição de tempo para o próximo tiro.
            Instantiate(shot, shotSpaw.position, shotSpaw.rotation);//Instancia shot que // é nosso tiro com a posição do SpawnShoot, e rotação do mesmo, como // nossa rotação é zero o objeto não tem rotação.
            tiroDano = dano;//Recebe valor que aparecerá no Script        

            if (dano > 5 && !timesUp)
            { // Se o dano for maior que 5 e timesUp for falsa
              // ele entra no If
                tempoPowerUp = Time.time + 30;// tempoPowerUp recebe o tempo atual
                                              // mais 30
                timesUp = true; // timesUp recebe verdadeiro
            }
            if (Time.time > tempoPowerUp)
            { //Se tempoPowerUp menor que o tempo
              //atual ele volta o valor do dano para 5  
                timesUp = false;
                dano = 5;
            }
        }
    }
}