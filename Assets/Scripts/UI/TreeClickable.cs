using Controller;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UI
{
    public class TreeClickable : MonoBehaviour, IPointerClickHandler
    {
        private FruitGenerator fruitGenerator;
        private static TreeInterfaceUI ui;
        private void Awake()
        {
            fruitGenerator = GetComponent<FruitGenerator>();
            if (ui == null)
                ui = FindFirstObjectByType<TreeInterfaceUI>(FindObjectsInactive.Include);
        }
        public void OnPointerClick(PointerEventData eventData)
        {
            if (eventData.button != PointerEventData.InputButton.Left) return;

            if (ui == null || fruitGenerator == null) return;
            ui.Open(fruitGenerator);
        }
    }
}