
using UnityEngine;
public class DestroiTiro : MonoBehaviour
{
    void FixedUpdate()
    {
        if (transform.position.y > 9)
        {//Verifica se a posi��o do Tiro � maior que 9
            Destroy(gameObject);// Caso seja destr�i o Tiro
        }
    }
}
