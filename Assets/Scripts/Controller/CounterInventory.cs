using System;
using Core;
using UnityEngine;

namespace Controller
{
    public class CounterInventory : MonoBehaviour
    {
        FruitRecollection fruitRecollection;
        

        private void Awake()
        {
            fruitRecollection = GetComponent<FruitRecollection>();
        }

        public void ShowList()
        {
            if (fruitRecollection.fruitCounter.TryGetValue(FruitType.Manzana, out int count))
            {
                
            
            }
        }
    }
}
