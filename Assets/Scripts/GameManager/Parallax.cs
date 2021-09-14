using UnityEngine;
public class Parallax : MonoBehaviour
{ //Nome do Script
    public float velocidade;//velocidade das nuvens
    public GameObject fimTela;//Onde as nuvens devem voltar ao gerencia_Inicio
    public GameObject gerencia_Inicio; // Para onde as nuvens devem voltar
    void FixedUpdate()
    {//Todos os fixedUpdate ocorrem depois dos Updates
        Vector3 pos = new Vector3(transform.position.x, transform.position.y - velocidade, transform.position.z);//Movimenta eixo y das nuvens
        transform.position = pos;// Recebe o valor modificado.
        if (transform.position.y < fimTela.transform.position.y)
        { //Verifica se as nuvens  
          //estão na posição de voltarem para cima da tela.
            Vector3 fim = gerencia_Inicio.transform.position; //Recebe o valor para onde as
                                                              //nuvens devem ir.  
            transform.position = fim; //Insere este valor nas nuvens.  
        }
    }
}
