using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class ButtonSpeech : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public UnityEvent OnButtonPressed;
    public UnityEvent OnButtonRelease;
    

    public void OnPointerDown(PointerEventData eventData)
    {
        OnButtonPressed?.Invoke();
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        OnButtonRelease?.Invoke();
    }


}
