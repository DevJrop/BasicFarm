using System;
using Controller;
using Core;
using UnityEngine;

namespace Quests
{
    public class QuestSystem : MonoBehaviour
    {
        [SerializeField] private QuestLayout[] questGroup;
        QuestLayout quest;
        private int index;
        [SerializeField] private Transform button;
        [SerializeField] private FruitRecollection fruitRecollection;
        
        private void Check()
        {
            if (quest.requiredAmount == fruitRecollection.FruitCount(quest.fruitType))
            {
                button.gameObject.SetActive(true);
            }
        }
    }
}
