using TMPro;
using UnityEngine;
namespace Controller
{
    public class FruitCounterUI : MonoBehaviour
    {
        [SerializeField] private TMP_Text text;
        private FruitGenerator target;
        public void SetTarget(FruitGenerator newTarget)
        {
            if (target != null)
                target.OnFruitChanged -= UpdateText;
            target = newTarget;
            if (target != null)
            {
                target.OnFruitChanged += UpdateText;
                UpdateText(target.CurrentFruit, target.tree.maxFruits);
            }
            else
            {
                text.text = "-";
            }
        }
        private void OnDisable()
        {
            if (target != null)
                target.OnFruitChanged -= UpdateText;
        }
        private void UpdateText(int current, int max)
        {
            text.text = $"{current}/{max}";
        }
    }
}