using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionDoor : Interaction
{
    //Non serialized Fields
    [SerializeField]
    private List<bool> clicks = new List<bool>();

    public override void interaction()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            StartCoroutine("click");
            openDoor();
        }
    }

    public void disableProperties()
    {
        this.gameObject.transform.GetComponent<BoxCollider2D>().enabled = false;
        this.gameObject.transform.GetChild(0).gameObject.SetActive(false);
        this.gameObject.transform.GetChild(1).gameObject.SetActive(false);
        gameObject.tag = "Untagged";
    }

    private void openDoor()
    {
        if (this.clicks.Count == 5)
        {
            this.gameObject.transform.GetComponent<Animator>().SetBool("IsOpen", true);
        }
    }

    IEnumerator click()
    {
        this.clicks.Add(true);
        yield return new WaitForSeconds(.47f);
        this.clicks.RemoveAt(0);
    }
}
