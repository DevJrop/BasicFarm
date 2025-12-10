using UnityEngine;

public class FruitHolder : MonoBehaviour
{
    [SerializeField] private Fruit fruitData;
    
    public Fruit FruitData => fruitData;
}
