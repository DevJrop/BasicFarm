using Controller;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UI
{
    public class TreeClickableUI : MonoBehaviour, IPointerClickHandler
    {
        [SerializeField] private FruitGenerator fruitGenerator;
        private TreeInterfaceUI ui;

        private void Awake()
        {
            if (fruitGenerator == null)
                fruitGenerator = GetComponent<FruitGenerator>();

            ui = FindFirstObjectByType<TreeInterfaceUI>(FindObjectsInactive.Include);
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            if (eventData.button != PointerEventData.InputButton.Left) return;

            if (ui == null)
            {
                Debug.LogError("No encontré TreeInterfaceUI en la escena.");
                return;
            }

            if (fruitGenerator == null)
            {
                Debug.LogError("Este árbol no tiene FruitGenerator.");
                return;
            }

            ui.Open(fruitGenerator);
        }
    }
}