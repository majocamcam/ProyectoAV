using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI; 

public class LaunchManager : MonoBehaviour, IPointerDownHandler,IPointerUpHandler
{
    float maxPressTime = 1;
    float currentPressTime;
    public Image launchbar;
    GameObject currentlaunchobject;
    GameObject currentpreview;
    public float launchStr = 12000;
    public float launchUp = 4;
    bool isPressed;
    
    public void OnPointerDown(PointerEventData eventData)
    {
        isPressed = true; 
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isPressed = false;
        if (currentPressTime > 0.1f)
        {
            Launchobject();
        }
    }

    private void Update()
    {
        if (isPressed)
        {
            currentPressTime = currentPressTime + Time.deltaTime;     
        }
        else
        {
            currentPressTime = 0;
        }

        launchbar.fillAmount = currentPressTime;
        currentPressTime = Mathf.Clamp01(currentPressTime); 
        
    }

    public void Selectlaunchitem (GameObject item)
    {
        currentpreview = item;
        currentlaunchobject = Instantiate(item, item.transform.position, item.transform.rotation);
        currentlaunchobject.AddComponent<Rigidbody>().mass = 10;
        currentlaunchobject.SetActive(false);
        this.GetComponent<Button>().interactable = true;
    }

    void Launchobject()
    {
        currentpreview.SetActive(false);
        currentlaunchobject.SetActive(true);
        this.GetComponent<Button>().interactable = false;
        Vector3 camForward = Camera.main.transform.forward;
        Vector3 force = new Vector3(camForward.x * launchStr * currentPressTime, Mathf.Max(camForward.y, 0.1f) * launchStr * launchUp, camForward.z * launchStr);
        currentlaunchobject.GetComponent<Rigidbody>().AddForce(force);
        Destroy(currentlaunchobject.gameObject, 3);
    }

}
