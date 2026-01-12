using Core;
using TMPro;
using UnityEngine;

namespace UI
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
        }

        public void OnDisable()
        {
            fruitRecollection.ChangeUI -= ShowList;
        }


        private void ShowList()
        {
            if (appleText == null) { Debug.LogError("appleText NULL", this); return; }
            int appleValue = fruitRecollection.FruitCount(FruitType.Manzana);
            appleText.text = appleValue.ToString();

            int bananaValue = fruitRecollection.FruitCount(FruitType.Banano);
            bananoText.text = bananaValue.ToString();

            int mangoValue = fruitRecollection.FruitCount(FruitType.Mango);
            mangoText.text = mangoValue.ToString();
        }
    }

}
