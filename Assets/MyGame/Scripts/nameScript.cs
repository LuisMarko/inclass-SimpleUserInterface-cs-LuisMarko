using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class transfereText : MonoBehaviour
{
    public Text targetText;
    public InputField inputField;

    public void setText()
    {
        targetText.text = inputField.text;
        inputField.text = "";
    }
}