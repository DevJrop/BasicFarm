using System;
using UnityEngine;
namespace Quests
{
    public class Wallet : MonoBehaviour
    {
        [SerializeField] private int coins;
        public int Coins => coins;
        public event Action OnCoinsChanged;
        public void AddCoins(int amount)
        {
            if (amount <= 0) return;
            coins += amount;
            OnCoinsChanged?.Invoke();
        }
        public bool TrySpendCoins(int price)
        {
            if (price <= 0) return false;
            if (coins < price) return false;
            coins -= price;
            OnCoinsChanged?.Invoke();
            return true;
        }
    }
}
