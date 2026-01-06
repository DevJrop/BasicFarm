using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Controller
{
    public class FruitGenerator : MonoBehaviour
    {
      
        [SerializeField] TMP_Text fruitvalue;
        private int currentFruit;
        [SerializeField] public Tree tree;

        public int CurrentFruit
        {
            get => currentFruit;
            set => currentFruit = value;
        }

        void Awake()
        {
            StartCoroutine(GetFruit());
        }

        IEnumerator GetFruit()
        {
            while (currentFruit < tree.maxFruits)
            {
                yield return new WaitForSeconds(tree.timeBetweenFruits);
                currentFruit++;
                fruitvalue.text = $"{tree.maxFruits}/{currentFruit}";
            }
        }
    }
}
