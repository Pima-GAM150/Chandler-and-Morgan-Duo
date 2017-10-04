using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Stuff : MonoBehaviour
{
    string path;
    string jsonString;

    void start()
    {
        path = Application.streamingAssetsPath + "/Entities.json";
        jsonString = File.ReadAllText(path);
        Entities player = JsonUtility.FromJson<Entities>(jsonString);
        Debug.Log(player.name);
    }
}
[System.Serializable]
public class Entities
{
    public string name;
    public int level;

}