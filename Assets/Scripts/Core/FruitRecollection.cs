using System;
using System.Collections.Generic;
using UnityEngine;

namespace Core
{
    public class FruitRecollection : MonoBehaviour
    {
        [SerializeField] private int fruitAmount;

        public Dictionary<FruitType, int> fruitCounter = new Dictionary<FruitType, int>();

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
        public void AddFruit(FruitType type )
        {
            fruitCounter.TryAdd(type, -1);
            fruitCounter[type]++;
            PlayerPrefs.SetInt("FruitCounter", fruitCounter[type]);
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                Debug.Log(PlayerPrefs.GetInt("FruitCounter"));
            }
        }
    }
}
