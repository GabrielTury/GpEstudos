using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    public ObjectPooling pooling;

    // Start is called before the first frame update
    void Start()
    {
        /*pooling = FindObjectOfType<ObjectPooling>();*/
        StartCoroutine(SpawnObjs());
    }

    // Update is called once per frame
    void Update()
    {

    }
    //[ContextMenu("Spawn")]
    //private void SpawnObj()
    //{
    //    GameObject sphere = pooling.GetFromList();
    //    sphere.SetActive(true);
    //    sphere.transform.position = transform.position;
    //    
    //    Debug.Log(sphere.name);
    //}
    private IEnumerator SpawnObjs()
    {
        while (true)
        {
            GameObject sphere = pooling.GetFromList();
            sphere.transform.position = transform.position;
            sphere.SetActive(true);
            Debug.Log(sphere.name);

            yield return new WaitForSeconds(1);
        }
    }
}
