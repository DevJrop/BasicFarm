using System;
using Controller;
using Core;
using TMPro;
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
        
        [SerializeField] private TMP_Text titleText;
        [SerializeField] private TMP_Text descriptionText;
        [SerializeField] private TMP_Text fruitText;
        [SerializeField] private TMP_Text rewardText;
        
        private void Start()
        {
            LoadQuest(0);

            UpdateTextUI();
            
            
            if (fruitRecollection != null)
                fruitRecollection.ChangeUI += Refresh;
            
            Refresh();
        }

        private void OnDestroy()
        {
            if (fruitRecollection != null)
            {
                fruitRecollection.ChangeUI -= Refresh;
            }
        }

        private void LoadQuest(int newIndex)
        {
            index = Mathf.Clamp(newIndex, 0, questGroup.Length - 1);
            quest = questGroup[index];
            
            
        }

        private void Refresh()
        {
            if (quest == null || fruitRecollection == null || button == null) return;
            
            bool ready = fruitRecollection.FruitCount(quest.fruitType) >= quest.requiredAmount;
            button.gameObject.SetActive(ready);
        }

        public void Claim()
        {
            if (quest == null || fruitRecollection == null) return;
           
            bool spent = fruitRecollection.TrySpendFruit(quest.fruitType, quest.requiredAmount);
            if (!spent) return;

            int next = index + 1;
            if (next < questGroup.Length)
            {
                LoadQuest(next);
                UpdateTextUI();
            }
            Refresh();
        }

        private void UpdateTextUI()
        {
            if (quest == null) return;
            
            titleText.SetText(quest.questTitle);
            descriptionText.SetText(quest.questInfo);
            fruitText.SetText(quest.requiredAmount.ToString());
            rewardText.SetText(quest.reward.ToString());
            
        }
    }
}
