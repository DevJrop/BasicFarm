using UnityEngine;

[CreateAssetMenu(fileName = "Seed", menuName = "Scriptable Objects/Seed")]
public class Seed : ScriptableObject
{

     public GameObject seed;
     public float timeAfterGrowth;
     public Tree growsInto;

}
