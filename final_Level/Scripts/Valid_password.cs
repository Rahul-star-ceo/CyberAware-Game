using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class PasswordValid : MonoBehaviour
{
    [SerializeField] TMP_InputField inputField;
    [SerializeField] TextMeshProUGUI resultText;

   public void ValidateInput()
   {
    string input =inputField.text;

    if (input == "Rahul"){
        resultText.text ="<b>Flag:flag{You're_Great_Attacker}</b>";
        resultText.color=Color.green;
    }
    else{
        resultText.text="Invalid input";
        resultText.color=Color.red;
    }
   }
}
