using UnityEngine;

[CreateAssetMenu(fileName = "Seed", menuName = "Scriptable Objects/Seed")]
public class Seed : ScriptableObject
{

     public GameObject seed;
    [SerializeField] private float timeAfterGrowth;
    [SerializeField] private GameObject tree;

}
