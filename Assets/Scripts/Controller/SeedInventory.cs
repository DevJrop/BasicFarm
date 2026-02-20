using System.Collections.Generic;
using Core;
using UnityEngine;
namespace Controller
{
    public class SeedInventory : MonoBehaviour
    {
        private readonly Dictionary<Seed, int> _seeds = new();
        public int GetCount(Seed seed)
        {
            if (seed == null) return 0;
            return _seeds.TryGetValue(seed, out int count) ? count : 0;
        }
        public void Add(Seed seed, int amount = 1)
        {
            if (seed == null || amount <= 0) return;
            if (_seeds.ContainsKey(seed)) _seeds[seed] += amount;
            else _seeds.Add(seed, amount);
        }
        public bool TryUse(Seed seed, int amount = 1)
        {
            if (seed == null || amount <= 0) return false;
            if (!_seeds.TryGetValue(seed, out int count)) return false;
            if (count < amount) return false;
            count -= amount;
            if (count <= 0) _seeds.Remove(seed);
            else _seeds[seed] = count;
            return true;
        }
    }
}