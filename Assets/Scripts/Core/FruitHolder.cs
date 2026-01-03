using UnityEngine;

namespace Core
{
    public class FruitHolder : MonoBehaviour
    {
        [SerializeField] private Fruit fruitData;
    
        public Fruit FruitData => fruitData;
    }
}
