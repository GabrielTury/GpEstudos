using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Events
{
    public static class TestEvents
    {
        public static event UnityAction Jump;
        public static void OnJump() => Jump?.Invoke();

        public static event UnityAction<int> DamageTaken;
        public static void OnDamageTaken(int damage) => DamageTaken?.Invoke(damage);
    }
}
