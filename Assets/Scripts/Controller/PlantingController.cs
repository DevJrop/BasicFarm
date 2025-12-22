using UnityEngine;

namespace Controller
{
    public class PlantingController : MonoBehaviour
    {
        [SerializeField] private Transform slotGroupParent;
        [SerializeField] private Seed kindOfSeed;
        bool canPlant;
    
        public void CheckListOfSlots()
        {
        
            foreach (Transform slot in slotGroupParent)
            {
                if (slot.childCount == 0) 
                {
                    
                    Instantiate(kindOfSeed.seed, slot);
                    return;
                }
            }
        }
    }
}
