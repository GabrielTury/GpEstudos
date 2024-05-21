using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GettingInfo : MonoBehaviour
{
    private int starsP;

    private int cloudsP;

    private int planetsP;

    private void Start()
    {
        starsP = SingletonExample.instance.stars;
        cloudsP = SingletonExample.instance.clouds;
        planetsP = SingletonExample.instance.planets;

        Debug.Log("Info stars: " +  starsP + " clouds: " + cloudsP + " planets: "+ planetsP);
    }
}
