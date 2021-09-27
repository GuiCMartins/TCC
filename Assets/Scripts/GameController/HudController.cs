using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class HudController : MonoBehaviour
{
    //Non serialized fields
    private GameObject gameController = null;

    //Serialized fields
    [Header("HUD coin text configuration")]
    [SerializeField]
    private TextMeshProUGUI text = null;
    [Header("HUD life bar configuration")]
    [SerializeField]
    private Image lifeBar = null;

    // Start is called before the first frame update
    void Start()
    {
        this.gameController = GameObject.FindWithTag("GameController");
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

    public float getLifeBarPercent()
    {
        return this.lifeBar.fillAmount;
    }
}
