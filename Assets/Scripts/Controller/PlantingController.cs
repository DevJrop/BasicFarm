using UnityEngine;

namespace Controller
{
    public class PlantingController : MonoBehaviour
    {
        [SerializeField] private Transform slotGroupParent;
        [SerializeField] private GameObject seed;
        bool canPlant;
    
        public void CheckListOfSlots()
        {
        
            foreach (Transform slot in slotGroupParent)
            {
                if (slot.childCount == 0) 
                {
                    
                    Instantiate(seed, slot);
                    return;
                }
            }
        }
    }
}
