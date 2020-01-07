using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class addNumber : MonoBehaviour
{
    public Text targetText;

    void Start()
    {
        targetText.text = "0";
    }

    public void addOne()
    {
        int tempResult = int.Parse(targetText.text) + 1;
        targetText.text = tempResult.ToString();
    }
}
