using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Controller
{
    public class PlantingController : MonoBehaviour
    {
        [SerializeField] private Transform slotGroupParent;
        [SerializeField] private Seed kindOfSeed;
        [SerializeField] private Tree kindOfTree;

        Action finishAction;

        public void CheckListOfSlots()
        {
            foreach (Transform slot in slotGroupParent)
            {
                if (slot.childCount == 0) 
                {
                    GameObject instSeed = Instantiate(kindOfSeed.seed, slot);
                    Timer(instSeed, slot);
                    return;
                }
            }   
        }
        private void Timer(GameObject instSeed, Transform slot)
        {
            CountDown cd = instSeed.GetComponent<CountDown>();
            Action finishCharging = () => FinishCharging(instSeed, slot);
            cd.Init(kindOfSeed.timeAfterGrowth, finishCharging);
        }

        void FinishCharging(GameObject instSeed, Transform slot)
        {
            Destroy(instSeed.gameObject);
            Instantiate(kindOfTree.tree, slot);
        }
        
    }
}
