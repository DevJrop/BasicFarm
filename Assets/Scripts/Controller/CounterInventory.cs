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

        public void OnEnable()
        {
            fruitRecollection.ChangeUI += ShowList;
            
            Debug.Log("suscrito");
        }

        public void OnDisable()
        {
            fruitRecollection.ChangeUI -= ShowList;
            Debug.Log("Desuscrito");
        }


        private void ShowList()
        {
            int appleValue = fruitRecollection.FruitCount(FruitType.Manzana);
            appleText.text = appleValue.ToString();

            int bananaValue = fruitRecollection.FruitCount(FruitType.Banano);
            bananoText.text = bananaValue.ToString();

            int mangoValue = fruitRecollection.FruitCount(FruitType.Mango);
            mangoText.text = mangoValue.ToString();
        }
    }

}
