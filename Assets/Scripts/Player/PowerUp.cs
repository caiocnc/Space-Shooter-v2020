using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public float velocidade;
    void Start()
    {
        //Aqui movemos o PowerUp na mesma direção que as nuvens estão se //movendo
        gameObject.GetComponent<Rigidbody2D>().velocity = -transform.up * velocidade;
    }
    void FixedUpdate()
    {
        if (transform.position.y < -5)
        {//Caso o PowerUp não for pego pela nave, ele
         // será destruído ao passar do Y -5.
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {//Verifica colisão 2D
        if (other.tag == "Player")
        {//Reconhece a Tag com nome Player
            PlayerTiros.dano = 10;//Muda o valor do dano da nave
            Destroy(gameObject);// Retira o PowerUp da cena
        }
    }
}
