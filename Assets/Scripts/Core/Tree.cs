using Core;
using UnityEngine;
using UnityEngine.Serialization;

[CreateAssetMenu(fileName = "Tree", menuName = "Scriptable Objects/Tree")]
public class Tree : ScriptableObject
{
    public GameObject treeSprite;
    public FruitType type;
    public int maxFruits;
    public float timeBetweenFruits;

}
