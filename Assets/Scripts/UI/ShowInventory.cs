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
            Debug.Log("Seleccionado: " + generator.name);
        }

        public void CloseInventory()
        {
            panel.SetActive(false);
        }

        public void DeleteCurrentTree()
        {
            if (currentGenerator == null)
            {
                Debug.LogWarning("No hay árbol seleccionado para borrar.");
                return;
            }

            Destroy(currentGenerator.gameObject);
            currentGenerator = null;
            CloseInventory();
        }
    }
}