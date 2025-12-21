using UnityEngine;

public class GroundState : MonoBehaviour
{
    public bool EmptySlot()
    {
        if (transform.childCount > 0)
        {
            return true;
        }
        return false;
    }
}
