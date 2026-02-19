using UnityEngine;
using UnityEngine.UI;
using Core;
using Quests;

namespace Controller
{
    public class BuySeedButton : MonoBehaviour
    {
        [Header("Data")]
        [SerializeField] private Seed seedToBuy;

        [Header("Systems")]
        [SerializeField] private Wallet wallet;
        [SerializeField] private SeedInventory seedInventory;

        [Header("Plant (Optional Auto-Plant)")]
        [SerializeField] private PlantingController plantingController;
        [SerializeField] private bool autoPlantAfterBuy = true;

        private Button _button;

        private void Awake()
        {
            _button = GetComponent<Button>();
            if (_button != null) _button.onClick.AddListener(TryBuy);
        }

        public void TryBuy()
        {
            if (seedToBuy == null || wallet == null || seedInventory == null)
            {
                Debug.LogWarning("[BuySeedButton] Missing references.", this);
                return;
            }

            if (!wallet.TrySpendCoins(seedToBuy.seedCost))
                return;

            seedInventory.Add(seedToBuy, 1);

            if (autoPlantAfterBuy && plantingController != null)
            {
                plantingController.Plant(seedToBuy);
            }
        }
    }
}