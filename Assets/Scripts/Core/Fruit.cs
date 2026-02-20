using UnityEngine;
namespace Core
{
    [CreateAssetMenu(fileName = "Fruit", menuName = "Scriptable Objects/Fruit")]
    public class Fruit : ScriptableObject
    {
        [SerializeField] FruitType type;
        public FruitType Type => type;
    }
}
