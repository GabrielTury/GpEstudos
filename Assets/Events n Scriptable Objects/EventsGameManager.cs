using Events;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventsGameManager : MonoBehaviour
{
    [ContextMenu("Call Jump")]
    public void CallJump()
    {
        TestEvents.OnJump();
    }

    [ContextMenu("Call Damage")]
    public void CallDamage()
    {
        TestEvents.OnDamageTaken(5);
    }

}
