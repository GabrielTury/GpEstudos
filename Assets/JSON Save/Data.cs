using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data
{
    public string playerName;
    public int playerHealth;
    public List<int> playerNumbers;

    public Data(string name, int health, List<int> numbers) 
    {
        playerName = name;
        playerHealth = health;
        playerNumbers = numbers;
    }
}
