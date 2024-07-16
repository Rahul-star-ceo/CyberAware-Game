using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Flag_sub : MonoBehaviour
{
    

    public GameObject panelObject;
 

    public void OpenPanel()
    {
        if (panelObject != null)
        {
            bool isActive = panelObject.activeSelf;
            panelObject.SetActive(!isActive); // Use panelObject here instead of Panel

            
        }
    }


}
