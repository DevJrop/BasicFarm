using System;
using System.Collections.Generic;
using Core;
using UnityEngine;

namespace Controller
{
    public class FruitRecollection : MonoBehaviour
    {
        private readonly Dictionary<FruitType, int> fruitCounter = new Dictionary<FruitType, int>();
        public event Action ChangeUI;

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (!other.CompareTag("HarvestZone")) return;

            AddFruit(other);
            ChangeUI?.Invoke();
        }

        private int GetCount(FruitType type)
        {
            fruitCounter.TryGetValue(type, out int count);
            return count;
        }

        private void SetCount(FruitType type, int value)
        {
            fruitCounter[type] = Mathf.Max(0, value);
        }
        
        private void AddFruit(Collider2D other)
        {
            FruitGenerator fruitGenerator = other.GetComponent<FruitGenerator>();
            if (fruitGenerator == null) return;

            Tree tree = fruitGenerator.tree;
            FruitType type = tree.type;

            int amount = fruitGenerator.CurrentFruit;
            if (amount <= 0) return;

            SetCount(type, GetCount(type) + amount);
            fruitGenerator.CurrentFruit = 0;
        }

        public int FruitCount(FruitType type) => GetCount(type);

        public bool CanSpendFruit(FruitType type, int amount)
        {
            if (amount <= 0) return false;
            return GetCount(type) >= amount;
        }
        
        public bool TrySpendFruit(FruitType type, int amount)
        {
            if (!CanSpendFruit(type, amount)) return false;

            SetCount(type, GetCount(type) - amount);
            ChangeUI?.Invoke();
            return true;
        }
    }
}
