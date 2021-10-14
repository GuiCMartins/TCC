using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HudStatsController : MonoBehaviour
{
    //Serialized Fields
    [Header("Hud Stats Configuration")]
    [SerializeField]
    private GameObject stats = null;
    [Header("Hud closed stats Configuration")]
    [SerializeField]
    private GameObject closedStats = null;

    public void closeStats()
    {
        this.stats.SetActive(false);
        this.closedStats.SetActive(true);
    }

    public void openStats()
    {
        this.closedStats.SetActive(false);
        this.stats.SetActive(true);
    }
}
