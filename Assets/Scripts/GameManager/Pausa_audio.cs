using UnityEngine;

public class Pausa_audio : MonoBehaviour
{

    void Start()
    {

        Continue_audio.Instance.GetComponent<AudioSource>().Pause();

    }

}
