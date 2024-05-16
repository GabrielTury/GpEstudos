using Events;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    private void OnEnable()
    {
        TestEvents.Jump += JumpingS;
        TestEvents.DamageTaken += TookDamage;
    }

    private void OnDisable()
    {
        TestEvents.Jump -= JumpingS;
        TestEvents.DamageTaken -= TookDamage;
    }

    private void JumpingS()
    {
        Debug.Log("Esfera Pulou");
    }

    private void TookDamage(int damageAmount)
    {
        Debug.Log("Tomou " + damageAmount + " de dano");
    }
}
