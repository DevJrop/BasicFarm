using System;
using UnityEngine;

public class FruitRecollection : MonoBehaviour
{
    [SerializeField] private int fruitAmount;
    FruitType fruitType;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Fruit"))
        {
            AddFruit(fruitType);
            Destroy(other.gameObject);
        }
    }

    private void AddFruit(FruitType type)
    {
        fruitAmount ++;
    }
}
