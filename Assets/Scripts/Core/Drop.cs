using Prefabs.Seed;
using UnityEngine;
using UnityEngine.EventSystems;

public class Drop : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        GameObject dropped = eventData.pointerDrag;
        DropAndDrag dropAndDrag = dropped.GetComponent<DropAndDrag>();
        dropAndDrag.parentAfterDrag = transform;
    }
}
