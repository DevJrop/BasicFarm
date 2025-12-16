using System;
using Core;
using TMPro;
using UnityEngine;

namespace Controller
{
    public class CounterInventory : MonoBehaviour
    {
        [SerializeField] private FruitRecollection fruitRecollection;
        [SerializeField] private TMP_Text appleText;
        [SerializeField] private TMP_Text bananoText;
        [SerializeField] private TMP_Text mangoText;
        
        private void Update()
        {
            ShowList();
        }

        private void ShowList()
        {
            int appleValue = fruitRecollection.FruitCount(FruitType.Manzana);
            appleText.text = appleValue.ToString();
            
            int bananaValue = fruitRecollection.FruitCount(FruitType.Banano);
            bananoText.text = appleValue.ToString();
            
            int mangoValue = fruitRecollection.FruitCount(FruitType.Mango);
            mangoText.text = appleValue.ToString();
        }

        
    }
}
