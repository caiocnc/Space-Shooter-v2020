
using UnityEngine;
public class MoverTiro : MonoBehaviour
{
    public float velocidade; // Determina velocidade do Tiro
    void Start()
    {
        gameObject.GetComponent<Rigidbody2D>().velocity = transform.up * velocidade;
        //Muda a posi��o do Tiro em rela��o a velocidade e a posi��o que est�.
    }
}
