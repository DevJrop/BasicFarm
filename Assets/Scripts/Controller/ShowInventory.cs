using UnityEngine;

namespace Controller
{
    public class ShowInventory : MonoBehaviour
    {
        [SerializeField] private CanvasRenderer inventory;

        public void OpenInventory()
        {
            inventory.gameObject.SetActive(true);
            Debug.Log("Open Inventory");
        }
    
        public void CloseInventory()
        {
            inventory.gameObject.SetActive(false);
            Debug.Log("Close Inventory");
        }
    }
}
