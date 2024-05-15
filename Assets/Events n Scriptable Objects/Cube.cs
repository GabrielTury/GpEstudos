using Events;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField] ScriptableObjectDemo sObj;

    public int health {  get; private set; }

    private void Start()
    {
        gameObject.name = sObj.objectName;
        health = sObj.health;

    }
    private void OnEnable()
    {
        TestEvents.Jump += Jumping;
        TestEvents.DamageTaken += _ => TookDamage();
    }

    private void OnDisable()
    {
        TestEvents.Jump -= Jumping;
        TestEvents.DamageTaken -= _ => TookDamage();
    }

    private void Jumping()
    {
        Debug.Log("Esfera Pulou");
    }

    private void TookDamage()
    {
        Debug.Log("Funcionou");
    }
}
