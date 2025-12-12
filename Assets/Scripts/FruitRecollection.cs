using System;
using System.Collections.Generic;
using UnityEngine;

public class FruitRecollection : MonoBehaviour
{
    [SerializeField] private int fruitAmount;
    
    Dictionary<FruitType, int> fruitCounter = new Dictionary<FruitType, int>();

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Fruit")) return;
        
        FruitHolder fruitHolder = other.GetComponent<FruitHolder>();
        
        if (fruitHolder == null) return;
        
            Fruit fruit = fruitHolder.FruitData;
        
            FruitType type = fruit.Type;
            AddFruit(type);
            Destroy(other.gameObject);
    }

    private void AddFruit(FruitType type )
    {
        fruitCounter.TryAdd(type, 0);

        fruitCounter[type]++;
    }
    
    
}
