using System.IO;

using UnityEngine;

using TMPro;

public class Carrega_Score : MonoBehaviour
{

    void Start()
    {

        string getJsonFile = File.ReadAllText(Application.persistentDataPath + "/" + "saveFile.json");

        Score load = JsonUtility.FromJson<Score>(getJsonFile);

        gameObject.GetComponent<TextMeshProUGUI>().SetText("" + load.bestScore);

    }

}