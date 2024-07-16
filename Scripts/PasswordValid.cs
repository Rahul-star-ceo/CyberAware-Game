using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class PasswordValid : MonoBehaviour
{
    [SerializeField] TMP_InputField inputField;
    [SerializeField] Text resultText;

   public void ValidateInput()
   {
    string input =inputField.text;

    if (input == "Rahul"){
        resultText.text ="Valid input";
        resultText.color=Color.green;
    }
    else{
        resultText.text="Invalid input";
        resultText.color=Color.red;
    }
   }
}
