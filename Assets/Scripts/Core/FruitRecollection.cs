using System;
using System.Collections.Generic;
using UnityEngine;

namespace Core
{
    public class FruitRecollection : MonoBehaviour
    {
        [SerializeField] private int fruitAmount;

        public Dictionary<FruitType, int> fruitCounter = new Dictionary<FruitType, int>();
        
        public event Action ChangeUI;

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (!other.CompareTag("Fruit")) return;
        
            FruitHolder fruitHolder = other.GetComponent<FruitHolder>();
        
            if (fruitHolder == null) return;
        
            FruitReader(other, fruitHolder);
        }

        private void FruitReader(Collider2D other, FruitHolder fruitHolder)
        {
            Fruit fruit = fruitHolder.FruitData;
        
            FruitType type = fruit.Type;
            
            AddFruit(type);
            ChangeUI?.Invoke();
            Destroy(other.gameObject);
        }

        public void AddFruit(FruitType type)
        {
            fruitCounter.TryGetValue(type, out int count);
            fruitCounter[type] = count + 1;
            
        }

        public int FruitCount(FruitType type)
        {
            if (fruitCounter.TryGetValue(type, out int count))
                return count;
            
            return 0;
        }
       
    }
}
