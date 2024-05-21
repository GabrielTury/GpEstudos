using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonExample : MonoBehaviour
{
    public static SingletonExample instance { get; private set; }

    public int stars { get; private set; }

    public int planets { get; private set; }

    public int clouds { get; private set; }
    private void Awake()
    {
        stars = 10;
        clouds = 15;
        planets = 20;

        if(instance != null)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }
}
