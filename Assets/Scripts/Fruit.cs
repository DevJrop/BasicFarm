using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Fruit", menuName = "Scriptable Objects/Fruit")]
public class Fruit : ScriptableObject
{
    [SerializeField] FruitType type;
    [SerializeField] float timeBetweenFruits;
    [SerializeField] float maxCapacity;
    [SerializeField] float cooldownToAvailable;

    
}
