using System;
using System.Collections;
using UnityEngine;
namespace Controller
{
    public class FruitGenerator : MonoBehaviour
    {
        public event Action<int, int> OnFruitChanged;
        private int currentFruit;
        [SerializeField] public Tree tree;
        public int CurrentFruit
        {
            get => currentFruit;
            set
            {
                currentFruit = value;
                OnFruitChanged?.Invoke(currentFruit, tree.maxFruits); 
            }  
        }
        void Awake()
        {
            StartCoroutine(GetFruit());
            OnFruitChanged?.Invoke(currentFruit, tree.maxFruits);
        }
        IEnumerator GetFruit()
        {
            while (currentFruit < tree.maxFruits)
            {
                yield return new WaitForSeconds(tree.timeBetweenFruits);
                CurrentFruit++;
            }
        }
    }
}
