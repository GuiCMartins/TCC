using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class LifeCount : MonoBehaviour
{
    //Serialized fields
    [Header("Life configuration")]
    [SerializeField]
    private GameObject[] life = new GameObject[3];

    public void lifeLost(int count)
    {
        Image image = life[count].GetComponent<Image>();
        image.color = new Color(image.color.r, image.color.g, image.color.b, .35f);
    }
}
