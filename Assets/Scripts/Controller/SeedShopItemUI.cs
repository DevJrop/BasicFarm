using UnityEngine;
using TMPro;
using Core;
namespace Controller
{
    public class SeedShopItemUI : MonoBehaviour
    {
        [Header("Price Texts (UI)")]
        [SerializeField] private TextMeshProUGUI costAppleText;
        [SerializeField] private TextMeshProUGUI costBananaText;
        [SerializeField] private TextMeshProUGUI costMangoText;
        [Header("Seeds (ScriptableObjects)")]
        [SerializeField] private Seed appleSeed;
        [SerializeField] private Seed bananaSeed;
        [SerializeField] private Seed mangoSeed;
        private void OnEnable()
        {
            RefreshPrices();
        }
        private void RefreshPrices()
        {
            if (costAppleText != null && appleSeed != null)
                costAppleText.text = appleSeed.seedCost.ToString();

            if (costBananaText != null && bananaSeed != null)
                costBananaText.text = bananaSeed.seedCost.ToString();

            if (costMangoText != null && mangoSeed != null)
                costMangoText.text = mangoSeed.seedCost.ToString();
        }
    }
}