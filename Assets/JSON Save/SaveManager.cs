using System.Collections;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    private string savePath;
    private void Awake()
    {
        savePath = Path.Combine("Assets/JSON Save", "save.json");
        
    }

    public void SaveGame(Data data)
    {        
        string jsonData = JsonConvert.SerializeObject(data);
        File.WriteAllText(savePath, jsonData);
    }

    public Data LoadGame()
    {
        if (File.Exists(savePath))
        {
            string jsonData = File.ReadAllText(savePath);
            return JsonConvert.DeserializeObject<Data>(jsonData);
        }
        else
        {
            Debug.LogWarning("Save file not found.");
            return null;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
