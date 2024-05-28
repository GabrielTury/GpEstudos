using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private SaveManager saveManager;

    private List<int> numbersToSave;

    private Data loadedData;

    public string playerName;

    public int health;

    [ContextMenu("Save")]
    public void Save()
    {
        numbersToSave = new List<int>();
        numbersToSave.Add(10);
        numbersToSave.Add(11);

        Data saveData = new Data("Gabriel", 10, numbersToSave);
        saveManager.SaveGame(saveData);
    }

    [ContextMenu("Load")]
    public void Load()
    {
        loadedData = saveManager.LoadGame();

        playerName = loadedData.playerName;
        health = loadedData.playerHealth;
        numbersToSave = loadedData.playerNumbers;

        Debug.Log(numbersToSave[0]);
        Debug.Log(numbersToSave[1]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
