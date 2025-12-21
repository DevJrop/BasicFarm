using UnityEngine;

public class PlantingController : MonoBehaviour
{
    [SerializeField] private GameObject slotGroupParent;
    GroundState groundState;
    void Update()
    {
        
    }

    private void CheckListOfSlots()
    {
        if (groundState.EmptySlot() == false)
        {
            foreach (GameObject slot in slotGroupParent.GetComponentsInChildren<GameObject>())
            {
                
            }
        }
    }
    
}
