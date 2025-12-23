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
        
         public void CheckListOfSlots()
        {
            foreach (Transform slot in slotGroupParent)
            {
                if (slot.childCount == 0) 
                {
                    GameObject instSeed = Instantiate(kindOfSeed.seed, slot);
                    StartCoroutine(Timer(instSeed, slot));
                    return;
                }
            }   
        }
        private IEnumerator Timer(GameObject instSeed, Transform slot)
        {
            yield return new WaitForSeconds(kindOfSeed.timeAfterGrowth);
                Destroy(instSeed.gameObject);
                Instantiate(kindOfTree.tree, slot);
        }
    }
}
