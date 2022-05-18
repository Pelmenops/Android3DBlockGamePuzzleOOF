using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIInterface : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
 public void OnPointerDown (PointerEventData eventData)
    {
        Debug.Log("Button down");
    }
    public void OnPointerUp (PointerEventData eventData)
    {
        Debug.Log("Button up");
    }
}
