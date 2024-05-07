using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooling : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    private GameObject sphere;

    [SerializeField]
    private int spheresToSpawn;

    public List<GameObject> sphereList = new List<GameObject>();

    [SerializeField]
    private Transform spawnPoint;

    private void Awake()
    {
        for (int i = 0; i < spheresToSpawn; i++)
        {
            GameObject obj = Instantiate(sphere);
            sphereList.Add(obj);
            obj.name = "Sphere: " + i.ToString();
            obj.SetActive(false);
        }
    }
    void Start()
    {


        //StartCoroutine(Spawn());


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject GetFromList()
    {
        for(int i = 0; i < sphereList.Count; i++)
        {
            if (sphereList[i].activeInHierarchy == false)
            {
                Debug.Log("Pegou o objeto");
                return sphereList[i];
            }
        }

        GameObject newObj = Instantiate(sphere);
        sphereList.Add(newObj);
        newObj.SetActive(false);

        return newObj;
    }

    //private IEnumerator Spawn()
    //{
    //    while (true)
    //    {
    //
    //        Instantiate(sphere, spawnPoint);
    //
    //        yield return new WaitForEndOfFrame();
    //    }
    //}
}
