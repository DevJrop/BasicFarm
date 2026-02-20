using System;
using System.Collections.Generic;
using Core;
using UnityEngine;
using Tree = Core.Tree;

namespace Controller
{
    public class FruitRecollection : MonoBehaviour
    {
        private readonly Dictionary<FruitType, int> fruitCounter = new Dictionary<FruitType, int>();
        public event Action ChangeUI;
        public event Action<FruitType, int, Vector3> FruitCollected;
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (!other.CompareTag("HarvestZone"))
            {
                return;
            }
            bool collected = AddFruit(other);
            if (collected)
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
        private bool AddFruit(Collider2D other)
        {
            FruitGenerator fruitGenerator = other.GetComponent<FruitGenerator>();
            if (fruitGenerator == null)
            {
                return false;
            }
            Tree tree = fruitGenerator.tree;
            if (tree == null)
            {
                return false;
            }
            FruitType type = tree.type;
            int amount = fruitGenerator.CurrentFruit;
            if (amount <= 0) return false;
            SetCount(type, GetCount(type) + amount);
            FruitCollected?.Invoke(type, amount, fruitGenerator.transform.position);
            fruitGenerator.CurrentFruit = 0;
            return true;
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