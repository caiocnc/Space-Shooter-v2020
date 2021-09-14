
using UnityEngine;
public class DestroiTiro : MonoBehaviour
{
    void FixedUpdate()
    {
        if (transform.position.y > 9)
        {//Verifica se a posição do Tiro é maior que 9
            Destroy(gameObject);// Caso seja destrói o Tiro
        }
    }
}
