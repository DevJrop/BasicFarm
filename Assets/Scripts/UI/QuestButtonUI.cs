using UnityEngine;

namespace UI
{
    public class QuestButtonUI : MonoBehaviour
    {
        [SerializeField] private GameObject questPanel;
        
        public void OpenQuestPanel( )
        {
            questPanel.SetActive(true);
        }

        public void CloseQuestPanel()
        {
            questPanel.SetActive(false);
        }
    }
}
