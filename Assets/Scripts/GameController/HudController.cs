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

    //Non serialized fields
    private GameObject gameController = null;
    private TextMeshProUGUI totalLifeText = null;
    private TextMeshProUGUI currentLifeText = null;
    private TextMeshProUGUI damageMaxText = null;
    private TextMeshProUGUI damageMinText = null;
    private TextMeshProUGUI criticalDamageText = null;
    private TextMeshProUGUI criticalChanceText = null;

    // Start is called before the first frame update
    void Start()
    {
        this.gameController = GameObject.FindWithTag("GameController");
        this.totalLifeText = GameObject.FindWithTag("StatsLifeText").transform.GetChild(4).GetComponent<TextMeshProUGUI>();
        this.currentLifeText = GameObject.FindWithTag("StatsLifeText").transform.GetChild(2).GetComponent<TextMeshProUGUI>();
        this.damageMinText = GameObject.FindWithTag("StatsDamageText").transform.GetChild(0).transform.GetChild(1).GetComponent<TextMeshProUGUI>();
        this.damageMaxText = GameObject.FindWithTag("StatsDamageText").transform.GetChild(1).transform.GetChild(1).GetComponent<TextMeshProUGUI>();
        this.criticalDamageText = GameObject.FindWithTag("StatsDamageText").transform.GetChild(2).transform.GetChild(1).GetComponent<TextMeshProUGUI>();
        this.criticalChanceText = GameObject.FindWithTag("StatsDamageText").transform.GetChild(3).transform.GetChild(1).GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        setCoinText();
    }

    private void setCoinText()
    {
        string s = this.gameController.GetComponent<GameController>().getPlayerCoins().ToString("N0");
        this.text.text = s.Replace(",", ".");
    }

    public void setLifeBar()
    { 
        this.lifeBar.fillAmount = ((float)this.gameController.GetComponent<GameController>().getPlayerCurrentLife() / (float)this.gameController.GetComponent<GameController>().getPlayerTotalLife());
    }

    public void setTotalLifeText()
    {
        this.totalLifeText.text = this.gameController.GetComponent<GameController>().getPlayerTotalLife().ToString();
    }

    public void setCurrentLifeText()
    {
        this.currentLifeText.text = this.gameController.GetComponent<GameController>().getPlayerCurrentLife().ToString();
    }

    public void setDamageMinText()
    {
        this.damageMinText.text = this.gameController.GetComponent<GameController>().getPlayerDamageMin().ToString();
    }

    public void setDamageMaxText()
    {
        this.damageMaxText.text = this.gameController.GetComponent<GameController>().getPlayerDamageMax().ToString();
    }

    public void setCriticalDamageText()
    {
        this.criticalDamageText.text = this.gameController.GetComponent<GameController>().getPlayerCriticalDamage().ToString();
    }

    public void setCriticalChanceText()
    {
        this.criticalChanceText.text = this.gameController.GetComponent<GameController>().getPlayerCriticalChance().ToString();
    }

    public float getLifeBarPercent()
    {
        return this.lifeBar.fillAmount;
    }
}
