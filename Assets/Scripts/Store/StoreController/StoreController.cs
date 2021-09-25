using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreController : MonoBehaviour
{
    //Serialized Fields
    [Header("Category configuration")]
    [SerializeField]
    private GameObject currentCategory = null;
    [SerializeField]
    private GameObject[] categoriesSlots = new GameObject[4];
    [Header("Store configuration")]
    [SerializeField]
    private GameObject store = null;

    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject category in this.categoriesSlots)
        {
            category.SetActive(false);
        }

        this.store.SetActive(false);

        this.currentCategory.SetActive(true);
    }

    public GameObject getCurrentCategory()
    {
        return this.currentCategory;
    }

    public void setCurrentCategory(GameObject currentCategory)
    {
        this.currentCategory = currentCategory;
    }
}
