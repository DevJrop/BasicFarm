using System;
using UnityEngine;

public class GetLot : MonoBehaviour
{
    [SerializeField] private GameObject lot;
    [SerializeField] private float timer;
    [SerializeField] private Sprite tree;
    private bool growing;
    private Seed seed;


    private void Update()
    {
        Germinate();
    }

    private bool OnLot()
    {
        if (lot == null)
        {
            return false;
        }
        return true;
    }
    
    private void Germinate()
    {
        if (OnLot() != null)
        {
            timer += Time.deltaTime;
            Debug.Log("Tiempo");
            growing = true;
            Debug.Log("Tiempo terminado growing true");
        }
        
        Debug.Log("destruido semilla");
        OnSloting();
    }

    private void OnSloting()
    {
        Destroy(lot);
        Instantiate(tree, transform.position, Quaternion.identity);
    }
}
