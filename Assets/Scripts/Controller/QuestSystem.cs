using Core;
using UnityEngine;

namespace Controller
{
    public class QuestSystem : MonoBehaviour
    {
        QuestLayout quest;
        FruitRecollection fruitRecollection;
        
        private void Check()
        {
            if (quest.requiredAmount == fruitRecollection.FruitCount(quest.fruitType))
            {
                quest.questCompleted = true;
                
            
            }
        }
    }
}
