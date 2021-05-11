using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class HudController : MonoBehaviour
{
    //Non serialized fields
    private GameController gameController;

    //Serialized fields
    [Header("Scrip PlayerStats configuration")]
    [SerializeField]
    private PlayerStats playerStats = null;
    [Header("HUD coin text configuration")]
    [SerializeField]
    private TextMeshProUGUI text = null;
    [Header("HUD life bar configuration")]
    [SerializeField]
    private Image lifeBar = null;

    // Start is called before the first frame update
    void Start()
    {
        this.playerStats = FindObjectOfType(typeof(PlayerStats)) as PlayerStats;
        this.gameController = FindObjectOfType(typeof(GameController)) as GameController;
    }

    // Update is called once per frame
    void Update()
    {
        setCoinText();
        setLifeBar();
    }

    private void setCoinText()
    {
        string s = this.gameController.getPlayerCoins().ToString("N0");
        this.text.text = s.Replace(",", ".");
    }

    private void setLifeBar()
    {
        if(this.playerStats == null)
        {
            this.playerStats = FindObjectOfType(typeof(PlayerStats)) as PlayerStats;
        }

        this.lifeBar.fillAmount = ((float)playerStats.getCurrentLife() / (float)playerStats.getTotalLife());
    }
}
