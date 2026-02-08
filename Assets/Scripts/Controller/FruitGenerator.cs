using System;
using System.Collections;
using UnityEngine;

namespace Controller
{
    public class FruitGenerator : MonoBehaviour
    {
        public event Action<int, int> OnFruitChanged;

        [SerializeField] public Tree tree;

        private int currentFruit;
        private Coroutine fruitRoutine;

        public int CurrentFruit
        {
            get => currentFruit;
            set
            {
                currentFruit = Mathf.Clamp(value, 0, tree.maxFruits);
                OnFruitChanged?.Invoke(currentFruit, tree.maxFruits);
                
                TryStartGenerating();
            }
        }

        private void Awake()
        {
            OnFruitChanged?.Invoke(currentFruit, tree.maxFruits);
            TryStartGenerating();
        }

        private void TryStartGenerating()
        {
            if (tree == null) return;
            
            if (currentFruit >= tree.maxFruits) return;
            
            if (fruitRoutine != null) return;

            fruitRoutine = StartCoroutine(GetFruit());
        }
        private IEnumerator GetFruit()
        {
            while (CurrentFruit < tree.maxFruits)
            {
                yield return new WaitForSeconds(tree.timeBetweenFruits);
                
                if (CurrentFruit >= tree.maxFruits)
                    break;

                CurrentFruit++;
            }
            fruitRoutine = null;
        }
    }
}