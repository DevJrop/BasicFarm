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

        public void RefreshPrices()
        {
            // Apple
            if (costAppleText != null && appleSeed != null)
                costAppleText.text = appleSeed.seedCost.ToString();
            else
                Debug.LogWarning("[SeedShopItemUI] Missing Apple text or Apple seed reference.", this);

            // Banana
            if (costBananaText != null && bananaSeed != null)
                costBananaText.text = bananaSeed.seedCost.ToString();
            else
                Debug.LogWarning("[SeedShopItemUI] Missing Banana text or Banana seed reference.", this);

            // Mango
            if (costMangoText != null && mangoSeed != null)
                costMangoText.text = mangoSeed.seedCost.ToString();
            else
                Debug.LogWarning("[SeedShopItemUI] Missing Mango text or Mango seed reference.", this);
        }
    }
}