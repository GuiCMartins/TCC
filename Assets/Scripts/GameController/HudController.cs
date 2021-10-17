using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class HudController : MonoBehaviour
{
    //Serialized fields
    [Header("HUD coin text configuration")]
    [SerializeField]
    private TextMeshProUGUI text = null;
    [Header("HUD life bar configuration")]
    [SerializeField]
    private Image lifeBar = null;
    [Header("HUD Stats life configuration")]
    [SerializeField]
    private GameObject statsLife = null;
    [Header("HUD stats damage configuration")]
    [SerializeField]
    private GameObject StatsDamage = null;

    //Non serialized fields
    private TextMeshProUGUI totalLifeText = null;
    private TextMeshProUGUI currentLifeText = null;
    private TextMeshProUGUI damageMaxText = null;
    private TextMeshProUGUI damageMinText = null;
    private TextMeshProUGUI criticalDamageText = null;
    private TextMeshProUGUI criticalChanceText = null;

    // Start is called before the first frame update
    void Start()
    {
        this.totalLifeText = statsLife.transform.GetChild(4).GetComponent<TextMeshProUGUI>();
        this.currentLifeText = statsLife.transform.GetChild(2).GetComponent<TextMeshProUGUI>();
        this.damageMinText = StatsDamage.transform.GetChild(0).transform.GetChild(1).GetComponent<TextMeshProUGUI>();
        this.damageMaxText = StatsDamage.transform.GetChild(1).transform.GetChild(1).GetComponent<TextMeshProUGUI>();
        this.criticalDamageText = StatsDamage.transform.GetChild(2).transform.GetChild(1).GetComponent<TextMeshProUGUI>();
        this.criticalChanceText = StatsDamage.transform.GetChild(3).transform.GetChild(1).GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        setCoinText();
    }

    private void setCoinText()
    {
        string s = this.gameObject.GetComponent<GameController>().getPlayerCoins().ToString("N0");
        this.text.text = s.Replace(",", ".");
    }

    public void setLifeBar()
    { 
        this.lifeBar.fillAmount = ((float)this.gameObject.GetComponent<GameController>().getPlayerCurrentLife() / (float)this.gameObject.GetComponent<GameController>().getPlayerTotalLife());
    }

    public void setTotalLifeText()
    {
        this.totalLifeText.text = this.gameObject.GetComponent<GameController>().getPlayerTotalLife().ToString();
    }

    public void setCurrentLifeText()
    {
        Debug.Log(this.currentLifeText);
        this.currentLifeText.text = this.gameObject.GetComponent<GameController>().getPlayerCurrentLife().ToString();
    }

    public void setDamageMinText()
    {
        this.damageMinText.text = this.gameObject.GetComponent<GameController>().getPlayerDamageMin().ToString();
    }

    public void setDamageMaxText()
    {
        this.damageMaxText.text = this.gameObject.GetComponent<GameController>().getPlayerDamageMax().ToString();
    }

    public void setCriticalDamageText()
    {
        this.criticalDamageText.text = this.gameObject.GetComponent<GameController>().getPlayerCriticalDamage().ToString();
    }

    public void setCriticalChanceText()
    {
        this.criticalChanceText.text = this.gameObject.GetComponent<GameController>().getPlayerCriticalChance().ToString();
    }

    public float getLifeBarPercent()
    {
        return this.lifeBar.fillAmount;
    }
}
