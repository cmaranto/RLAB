using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Units",menuName = "ScriptableObjects/UnitScriptableObject",order =1)]
public class UnitScriptableObject : ScriptableObject
{
    public enum ArmorType{
        Light,
        Medium,
        Heavy
    }

    public enum DamageType{
        Blunt,
        Magic,
        Piercing
    }

    public enum Race{
        Human,
        Orc,
        Elf,
        Halfling
    }

    public enum Class{
        Warrior,
        Mage,
        Archer,
        Thief
    }

    public enum Trait{
        Hearty,
        Swift,
        Strong,
        Studious
    }

    public string unitName = "Unit";
    public int range = 0;
    public int baseVitality = 1;
    public int baseSpeed = 1;
    public int baseStrength = 1;
    public int baseIntelligence = 1;
    public bool isEnemy = false;

    public Race race;
    public Class unitClass;
    public Trait[] traits;

    public override string ToString(){
        return string.Format("{0}: {1} {2}",name,race,unitClass);
    }

    

}
