using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;

[CreateAssetMenu(fileName = "NewWeapon",menuName ="ScriptableObjects/Weapon",order =1)]
public class Weapon : ScriptableObject
{
    public string weaponType;
    public string weaponRange;
    public string weaponShots;
    public string weaponPen;
    public string specialMove;
    public string specialExplosive;
    public string specialSlot1;
    public string specialSlot2;
    public string specialSlot3;
    public int weaponCost;
}
