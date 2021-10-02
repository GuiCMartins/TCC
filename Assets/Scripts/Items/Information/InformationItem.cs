using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InformationItem : MonoBehaviour
{
    //Serialized Fields
    [Header("Description configuration")]
    [SerializeField]
    private string name = "";
    [SerializeField]
    private string description = "";
    [Header("Status configuration")]
    [SerializeField]
    private string moreLife = "";
    [SerializeField]
    private string moreDamage = "";
    [SerializeField]
    private string damage = "";
    [SerializeField]
    private string moreCriticalDamage = "";
    [SerializeField]
    private string moreCriticalChance = "";
    [SerializeField]
    private string heal = "";

    public string getName()
    {
        return this.name;
    }

    public string getDescription()
    {
        return this.description;
    }

    public string getMoreLife()
    {
        return this.moreLife;
    }

    public string getMoreDamage()
    {
        return this.moreDamage;
    }

    public string getDamage()
    {
        return this.damage;
    }

    public string getMoreCriticalDamage()
    {
        return this.moreCriticalDamage;
    }

    public string getMoreCriticalChance()
    {
        return this.moreCriticalChance;
    }

    public string getHeal()
    {
        return this.heal;
    }
}
