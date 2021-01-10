using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UtilButton : MonoBehaviour
{
    //public GameObject menu_icon;



    [SerializeField] GameObject options;
    public void subButtonClick()
    {
        if (options.gameObject.activeSelf)
            options.gameObject.SetActive(false);
        else
            options.gameObject.SetActive(true);
    }
    void Update()
    {
           
    }
}
