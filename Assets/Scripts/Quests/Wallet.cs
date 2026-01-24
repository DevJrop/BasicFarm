using System;
using UnityEngine;

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

    private bool TrySpendCoins(int price)
    {
        if (price <= 0) return false;
        if(coins >= price) return false;
        
        coins -= price;
        OnCoinsChanged?.Invoke();
        return true;
    }
}
