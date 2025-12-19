using UnityEngine;

namespace Prefabs.Seed
{
    public class DropAndDrag : MonoBehaviour
    {
        [SerializeField] GameObject seedSpot;
        private Vector3 startPos;
        private Camera cam;
        private bool grabbing;

        void Awake()
        {
            startPos = transform.position;
            cam = Camera.main;
        
        }

        void OnMouseDown()
        {
            grabbing = true;
        }

        void OnMouseDrag()
        {
            if (!grabbing) return;

            Vector3 p = Input.mousePosition;
            p.z = Mathf.Abs(cam.transform.position.z);  

            Vector3 world = cam.ScreenToWorldPoint(p);
            world.z = startPos.z;                       

            transform.position = world;
        }

        void OnMouseUp()
        {
            grabbing = false;
            transform.position = seedSpot.transform.position;
        }
    }
}
