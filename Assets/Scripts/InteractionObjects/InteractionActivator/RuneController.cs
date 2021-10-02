using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuneController : MonoBehaviour
{
    //Serialized fields
    [Header("Right color Configuration")]
    [SerializeField]
    private GameObject[] activators = new GameObject[3] { null, null, null };

    //Non serialized fields
    private Color[] color = new Color[3] { Color.blue, Color.red, Color.green };

    public bool isAllActivatorsRight()
    {
        for (int i = 0; i < 3; i++)
        {
            if (this.activators[i].GetComponent<InteractionActivator>().getCurrentColor() != this.color[i])
            {
                return false;
            }
        }

        disableProperties();
        return true;
    }

    private void disableProperties()
    {
        for (int i = 0; i < 3; i++)
        {
            this.activators[i].transform.GetChild(0).gameObject.SetActive(false);
            this.activators[i].transform.GetChild(1).gameObject.SetActive(false);
            this.activators[i].tag = "Untagged";
        }
    }
}
