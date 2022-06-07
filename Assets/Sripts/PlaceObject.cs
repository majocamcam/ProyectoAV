using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.XR.ARFoundation;

public class PlaceObject : MonoBehaviour
{
    public ARRaycastManager RayCastManager;
    public GameObject objectToCreate;
    List<ARRaycastHit> hits = new List<ARRaycastHit>();
    bool alreadycreated;


    void Update()
    {
        if (RayCastManager != null) {
            Touch touch;
            if (Input.touchCount < 1 || (touch = Input.GetTouch(0)).phase != TouchPhase.Began) {
                return;
            }

            if (EventSystem.current.IsPointerOverGameObject(touch.fingerId)) {
                return;
            }

            if (RayCastManager.Raycast(touch.position, hits))
            {
                if (alreadycreated) { return; }
                var hit = hits[0];
                GameObject.Instantiate(objectToCreate, hit.pose.position, hit.pose.rotation);
                alreadycreated = true;
            }
        } else {
            RayCastManager = FindObjectOfType<ARRaycastManager>();
        }
    }
}
