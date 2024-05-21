using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GettingInfo2 : MonoBehaviour
{
    private int starsT;

    private int cloudsT;

    private int planetsT;
    void Start()
    {
        starsT = SingletonExample.instance.stars;
        cloudsT = SingletonExample.instance.clouds;
        planetsT = SingletonExample.instance.planets;

        Debug.Log("Info stars: " + starsT + " clouds: " + cloudsT + " planets: " + planetsT);
    }

}
