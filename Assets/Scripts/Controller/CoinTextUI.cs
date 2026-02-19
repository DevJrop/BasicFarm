using UnityEngine;
using TMPro;
using Quests;

namespace UI
{
    public class CoinTextUI : MonoBehaviour
    {
        [SerializeField] private Wallet wallet;
        [SerializeField] private TextMeshProUGUI coinText;

        private void OnEnable()
        {
            if (wallet != null)
                wallet.OnCoinsChanged += UpdateUI;

            UpdateUI();
        }

        private void OnDisable()
        {
            if (wallet != null)
                wallet.OnCoinsChanged -= UpdateUI;
        }

        private void UpdateUI()
        {
            if (wallet == null || coinText == null) return;
            coinText.text = wallet.Coins.ToString();
        }
    }
}