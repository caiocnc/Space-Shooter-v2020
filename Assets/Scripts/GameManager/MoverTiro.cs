
using UnityEngine;
public class MoverTiro : MonoBehaviour
{
    public float velocidade; // Determina velocidade do Tiro
    void Start()
    {
        gameObject.GetComponent<Rigidbody2D>().velocity = transform.up * velocidade;
        //Muda a posição do Tiro em relação a velocidade e a posição que está.
    }
}
