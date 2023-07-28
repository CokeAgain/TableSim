using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;

[CreateAssetMenu(fileName = "NewUnitOptions", menuName = "ScriptableObjects/OptionPrefab", order = 1)]
public class UnitOptions : MonoBehaviour
{
    public GameObject unitName;
    public List<GameObject> weaponOptions;
}
