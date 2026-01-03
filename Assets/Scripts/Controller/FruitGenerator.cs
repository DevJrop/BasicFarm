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
        [SerializeField] private Tree tree;
    
        void Start()
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
