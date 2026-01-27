using Core;
using UnityEngine;
using UnityEngine.Serialization;

namespace Quests
{
    [CreateAssetMenu(fileName = "QuestLayout", menuName = "Scriptable Objects/QuestLayout")]
    public class QuestLayout : ScriptableObject
    {
    
        public string questTitle;
        public string questInfo;
        public int reward;
        public FruitType fruitType;
        public int requiredAmount; 
    }
}
