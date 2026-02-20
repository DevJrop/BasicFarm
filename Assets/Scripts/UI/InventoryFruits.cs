using UnityEngine;
namespace UI
{
    public class InventoryFruit : MonoBehaviour
    {
        [SerializeField] private GameObject showPanel;
        public void Open( )
        {
            showPanel.SetActive(true);
        }
        public void CloseInventory()
        {
            showPanel.SetActive(false);
        }
    }
}
