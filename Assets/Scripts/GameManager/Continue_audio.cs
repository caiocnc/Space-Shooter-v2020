using UnityEngine;

public class Continue_audio : MonoBehaviour
{

    private static Continue_audio audio = null;

    public static Continue_audio Instance
    {

        get { return audio; }

    }

    private void Awake()
    {

        if (audio != null && audio != this)
        {

            Destroy(this.gameObject);

        }
        else
        {

            audio = this;

        }

        DontDestroyOnLoad(this.gameObject);

    }

}
