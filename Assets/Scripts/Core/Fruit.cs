using System.Collections.Generic;
using Core;
using UnityEngine;

[CreateAssetMenu(fileName = "Fruit", menuName = "Scriptable Objects/Fruit")]
public class Fruit : ScriptableObject
{
    [SerializeField] FruitType type;
    public FruitType Type => type;
}
