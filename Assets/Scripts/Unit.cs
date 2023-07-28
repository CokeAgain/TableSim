using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;

[CreateAssetMenu(fileName = "NewUnit", menuName = "ScriptableObjects/Unit", order = 1)]
public class Unit : ScriptableObject
{
    public string unitType;
    public string unitQuality;
    public string unitMove;
    public string unitVehicleManeuvre;
    public List<Weapon> unitWeapon;
    public int unitCost;
}
