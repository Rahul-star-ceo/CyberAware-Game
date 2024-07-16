using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Make sure this is UnityEngine.UI, not Unity.UI

using TMPro;

public class New_script : MonoBehaviour
{
    public GameObject panelObject;
    public TMP_Text buttonText;

    public void OpenPanel()
    {
        if (panelObject != null)
        {
            bool isActive = panelObject.activeSelf;
            panelObject.SetActive(!isActive); // Use panelObject here instead of Panel

            if (buttonText != null){
                buttonText.text = isActive ?"Activate" : "Deactivate";
            }
        }
    }
}
