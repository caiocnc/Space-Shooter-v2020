using UnityEngine;

public class Iniciar : MonoBehaviour
{

    public GameObject Ondas;

    public GameObject Pontos;

    private bool inicio = false;

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Q) && !inicio)
        {

            Pontos.SetActive(true);

            gameObject.SetActive(false);

            Instantiate(Ondas);

            inicio = true;

        }

    }

}
