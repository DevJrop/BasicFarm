using UnityEngine;
namespace Core
{
    [CreateAssetMenu(fileName = "Tree", menuName = "Scriptable Objects/Tree")]
    public class Tree : ScriptableObject
    {
        public GameObject treeSprite;
        public FruitType type;
        public int maxFruits;
        public float timeBetweenFruits;
    }
}
