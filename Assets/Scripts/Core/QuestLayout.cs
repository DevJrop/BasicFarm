using UnityEngine;

namespace Core
{
    [CreateAssetMenu(fileName = "QuestLayout", menuName = "Scriptable Objects/QuestLayout")]
    public class QuestLayout : ScriptableObject
    {
    
        public string questName;
        public string questInfo;
        public GameObject questPrefab;
        public int reward;
        public Dificult dificulty;
        public FruitType fruitType;
        public int requiredAmount; 
        public bool questCompleted;
    }
}
