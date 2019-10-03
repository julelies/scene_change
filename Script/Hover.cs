using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;


public class Hover : MonoBehaviour, IPointerEnterHandler
{
    public Text textcomponent;
    float currentNumber = 0;

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Mouse enter");
        currentNumber += 1;
        textcomponent.text = currentNumber.ToString();
    }

}


