using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScript : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnEnable()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.up * 10, ForceMode.Impulse);

        StartCoroutine(Deactivate());
    }

    
    private IEnumerator Deactivate()
    {
        yield return new WaitForSeconds(2.5f);
        this.gameObject.SetActive(false);
    }
    private void OnDisable()
    {
        
    }

}
