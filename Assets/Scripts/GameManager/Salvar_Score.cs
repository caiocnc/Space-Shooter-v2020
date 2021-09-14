using System.IO;

using UnityEngine;

using TMPro;

[System.Serializable]

public class Score
{

    public float bestScore;

}
public class Salvar_Score : MonoBehaviour
{

    private Score load;

    private float novo;

    void Start()
    {

        if (File.Exists(Application.persistentDataPath + "/" + "saveFile.json"))
        {

            string getJsonFile = File.ReadAllText(Application.persistentDataPath + "/" + "saveFile.json");

            load = JsonUtility.FromJson<Score>(getJsonFile);

            novo = Pontos.score;

            Salvar();

        }
        else
        {

            Score save = new Score();

            save.bestScore = Pontos.score;

            string toJsonFile = JsonUtility.ToJson(save);

            File.WriteAllText(Application.persistentDataPath + "/" + "saveFile.json", toJsonFile);



        }

    }

    public void Salvar()
    {

        float velho = load.bestScore;

        if (novo > velho)
        {

            Score save = new Score();

            save.bestScore = novo;

            string toJsonFile = JsonUtility.ToJson(save);

            File.WriteAllText(Application.persistentDataPath + "/" + "saveFile.json", toJsonFile);

        }

    }

}