using Events;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    private void OnEnable()
    {
        TestEvents.Jump += Jumping;
        TestEvents.DamageTaken += TookDamage;
    }

    private void OnDisable()
    {
        TestEvents.Jump -= Jumping;
        TestEvents.DamageTaken -= TookDamage;
    }

    private void Jumping()
    {
        Debug.Log("Esfera Pulou");
    }

    private void TookDamage(int damageAmount)
    {
        Debug.Log("Tomou " + damageAmount + " de dano");
    }
}
