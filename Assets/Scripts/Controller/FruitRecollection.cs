using System;
using System.Collections.Generic;
using Controller;
using UnityEngine;
namespace Core
{
    public class FruitRecollection : MonoBehaviour
    {
       
        private Dictionary<FruitType, int> fruitCounter = new Dictionary<FruitType, int>();
        public event Action ChangeUI;
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (!other.CompareTag("HarvestZone")) return;
            
            AddFruit(other);
            ChangeUI?.Invoke();
        }
        public void AddFruit(Collider2D other)
        {
            FruitGenerator fruitGenerator = other.GetComponent<FruitGenerator>();
            if (fruitGenerator == null) return;
            
            Tree tree = fruitGenerator.tree;
            FruitType type = tree.type;
            
            int amount = fruitGenerator.CurrentFruit;
            fruitCounter.TryGetValue(type, out int count);
            fruitCounter[type] = count + amount;
            fruitGenerator.CurrentFruit = 0;

        }
        public int FruitCount(FruitType type)
        {
            if (fruitCounter.TryGetValue(type, out int count))
                return count;
            
            return 0;
        }
    }
}
