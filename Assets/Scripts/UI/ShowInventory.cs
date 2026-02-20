using Controller;
using UnityEngine;
namespace UI
{
    public class ShowInventory : MonoBehaviour
    {
        [SerializeField] private GameObject panel;
        private FruitGenerator currentGenerator;
        public void OpenInventory(FruitGenerator generator)
        {
            currentGenerator = generator;
            panel.SetActive(true);
        }
        public void CloseInventory()
        {
            panel.SetActive(false);
        }
        public void DeleteCurrentTree()
        {
            if (currentGenerator == null)
            {
                return;
            }
            Destroy(currentGenerator.gameObject);
            currentGenerator = null;
            CloseInventory();
        }
    }
}