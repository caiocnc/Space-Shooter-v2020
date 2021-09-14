using UnityEngine;
public class PlayerTiros : MonoBehaviour
{
    public GameObject shot;// Neste campo colocaremos o Tiro.
    public Transform shotSpaw;//Neste campo o SpawnShoot.
    public float tempo_Entre_Tiros;// Valor determina o tempo entre os tiros.
    private float proximoTiro; // Vari�vel privada n�o aparece na Unity
    public int tiroDano;// Vari�vel que ser� usada para vermos atrav�s do Script seu
                        // valor mudar.
    public static int dano = 5;//Vari�vel que ser� usada para receber os PowerUps
                               //Por ser Static ou est�tica, esta vari�vel pode ser acessada por outras classes, // sem ser instanciada.
    private float tempoPowerUp; // Tempo que o PowerUp vai funcionar.
    private bool timesUp = false; // Gerencia se o PowerUp foi usado. Pode ser
                                  // verdadeira ou falsa.
    void Update()
    {//Este tipo de Update � feito antes do FixedUpdate.
        if (Time.time > proximoTiro)
        {//Verifica se j� � tempo de dar o pr�ximo tiro.
            proximoTiro = Time.time + tempo_Entre_Tiros;//Recebe o valor do tempo
                                                        //agora com uma adi��o de tempo para o pr�ximo tiro.
            Instantiate(shot, shotSpaw.position, shotSpaw.rotation);//Instancia shot que // � nosso tiro com a posi��o do SpawnShoot, e rota��o do mesmo, como // nossa rota��o � zero o objeto n�o tem rota��o.
            tiroDano = dano;//Recebe valor que aparecer� no Script        

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