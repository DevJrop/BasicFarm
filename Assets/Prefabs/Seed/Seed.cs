using UnityEngine;

[CreateAssetMenu(fileName = "Seed", menuName = "Scriptable Objects/Seed")]
public class Seed : ScriptableObject
{

    [SerializeField] private Sprite seed;
    [SerializeField] private float timeBeforeGrowth;
    [SerializeField] private GameObject slot;

}
