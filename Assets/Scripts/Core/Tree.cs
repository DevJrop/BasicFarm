using UnityEngine;

[CreateAssetMenu(fileName = "Tree", menuName = "Scriptable Objects/Tree")]
public class Tree : ScriptableObject
{
    public GameObject tree;
    public int numFruits;
    public float timeBetweenFruits;

}
