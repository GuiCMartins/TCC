using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ItemInformation : MonoBehaviour
{
    //Serialized Fields
    [Header("Item slots configuration")]
    [SerializeField]
    private GameObject itemSlot = null;
    [Header("Information configuration")]
    [SerializeField]
    private GameObject inf = null;
    [Header("Texts configuration")]
    [SerializeField]
    private TextMeshProUGUI nameTxt = null;
    [SerializeField]
    private TextMeshProUGUI descriptionTxt = null;
    [SerializeField]
    private TextMeshProUGUI moreLifeTxt = null;
    [SerializeField]
    private TextMeshProUGUI moreDamageTxt = null;
    [SerializeField]
    private TextMeshProUGUI damageTxt = null;
    [SerializeField]
    private TextMeshProUGUI moreCriticalDamageTxt = null;
    [SerializeField]
    private TextMeshProUGUI moreCriticalChanceTxt = null;
    [SerializeField]
    private TextMeshProUGUI healTxt = null;

    public void information()
    {
        if (this.itemSlot.GetComponent<BuyItemSlot>() != null)
        {
            this.nameTxt.text = this.itemSlot.GetComponent<BuyItemSlot>().getItem().GetComponent<InformationItem>().getName();
            this.descriptionTxt.text = this.itemSlot.GetComponent<BuyItemSlot>().getItem().GetComponent<InformationItem>().getDescription();
            this.moreLifeTxt.text = this.itemSlot.GetComponent<BuyItemSlot>().getItem().GetComponent<InformationItem>().getMoreLife();
            this.moreDamageTxt.text = this.itemSlot.GetComponent<BuyItemSlot>().getItem().GetComponent<InformationItem>().getMoreDamage();
            this.damageTxt.text = this.itemSlot.GetComponent<BuyItemSlot>().getItem().GetComponent<InformationItem>().getDamage();
            this.moreCriticalDamageTxt.text = this.itemSlot.GetComponent<BuyItemSlot>().getItem().GetComponent<InformationItem>().getMoreCriticalDamage();
            this.moreCriticalChanceTxt.text = this.itemSlot.GetComponent<BuyItemSlot>().getItem().GetComponent<InformationItem>().getMoreCriticalChance();
            this.healTxt.text = this.itemSlot.GetComponent<BuyItemSlot>().getItem().GetComponent<InformationItem>().getHeal();
            this.inf.SetActive(true);
        }
        else
        {
            if (this.itemSlot.GetComponent<Slot>().getItemInInventory() != null)
            {
                this.nameTxt.text = this.itemSlot.GetComponent<Slot>().getItemInInventory().GetComponent<InformationItem>().getName();
                this.descriptionTxt.text = this.itemSlot.GetComponent<Slot>().getItemInInventory().GetComponent<InformationItem>().getDescription();
                this.moreLifeTxt.text = this.itemSlot.GetComponent<Slot>().getItemInInventory().GetComponent<InformationItem>().getMoreLife();
                this.moreDamageTxt.text = this.itemSlot.GetComponent<Slot>().getItemInInventory().GetComponent<InformationItem>().getMoreDamage();
                this.damageTxt.text = this.itemSlot.GetComponent<Slot>().getItemInInventory().GetComponent<InformationItem>().getDamage();
                this.moreCriticalDamageTxt.text = this.itemSlot.GetComponent<Slot>().getItemInInventory().GetComponent<InformationItem>().getMoreCriticalDamage();
                this.moreCriticalChanceTxt.text = this.itemSlot.GetComponent<Slot>().getItemInInventory().GetComponent<InformationItem>().getMoreCriticalChance();
                this.healTxt.text = this.itemSlot.GetComponent<Slot>().getItemInInventory().GetComponent<InformationItem>().getHeal();
                this.inf.SetActive(true);
            }
        }
    }
}
