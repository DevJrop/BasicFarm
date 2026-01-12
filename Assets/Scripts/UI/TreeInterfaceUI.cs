using Controller;
using TMPro;
using UnityEngine;

namespace UI
{
    public class TreeInterfaceUI : MonoBehaviour
    {
        [SerializeField] private ShowInventory showPanel;
        [SerializeField] private TMP_Text titleText;
        [SerializeField] private TMP_Text infoText;
        [SerializeField] private FruitCounterUI fruitCounterUI;
        public void Open(FruitGenerator generator)
        {
            if (showPanel == null)
            {
                Debug.LogError("TreeInterfaceUI: ShowPanel NO asignado (ShowInventory).");
                return;
            }
            if (generator == null || generator.tree == null)
            {
                Debug.LogError("TreeInterfaceUI: FruitGenerator o Tree es null.");
                return;
            }

            showPanel.OpenInventory(generator);

            titleText.text = generator.tree.name;
            infoText.text = $"Max: {generator.tree.maxFruits} | Time: {generator.tree.timeBetweenFruits}s";

            if (fruitCounterUI != null)
                fruitCounterUI.SetTarget(generator);
        }

        public void Close()
        {
            if (showPanel == null) return;
            showPanel.CloseInventory();
        }
    }
}
