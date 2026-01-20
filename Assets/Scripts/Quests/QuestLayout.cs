using Core;
using UnityEngine;

namespace Quests
{
    [CreateAssetMenu(fileName = "QuestLayout", menuName = "Scriptable Objects/QuestLayout")]
    public class QuestLayout : ScriptableObject
    {
    
        public string questName;
        public string questInfo;
        public int reward;
        public FruitType fruitType;
        public int requiredAmount; 
    }
}
