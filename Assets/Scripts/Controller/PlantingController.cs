using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Controller
{
    public class PlantingController : MonoBehaviour
    {
        [SerializeField] private Transform slotGroupParent;

        public void Plant(Seed seedToPlant)
        {
            foreach (Transform slot in slotGroupParent)
            {
                    if (slot.childCount != 0) continue;
                    GameObject instSeed = Instantiate(seedToPlant.seed, slot);
                    StartGrowth(instSeed, slot, seedToPlant);
                    return;
                
            }   
        }
        private void StartGrowth(GameObject instSeed, Transform slot, Seed seedData)
        {
            CountDown cd = instSeed.GetComponent<CountDown>();
            cd.Init(seedData.timeAfterGrowth, () => FinishCharging(instSeed, slot, seedData));
        }

        void FinishCharging(GameObject instSeed, Transform slot,Seed seedData)
        {
            Destroy(instSeed);
            Instantiate(seedData.growsInto.tree, slot);
        }
        
    }
}
