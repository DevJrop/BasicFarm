using UnityEngine;
namespace Core
{
     [CreateAssetMenu(fileName = "Seed", menuName = "Scriptable Objects/Seed")]
     public class Seed : ScriptableObject
     {
          public GameObject seed;
          public float timeAfterGrowth;
          public Tree growsInto;
          public int seedCost;
     }
}
