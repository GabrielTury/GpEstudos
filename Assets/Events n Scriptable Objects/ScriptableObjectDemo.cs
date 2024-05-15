using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DemoScriptableObject")]
public class ScriptableObjectDemo : ScriptableObject
{
    [TextArea(2,2)]
    public string objectName;
    [Range(0, 10)]
    public int health;
}
