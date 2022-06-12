using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.XR.ARFoundation;
using TMPro;

public class PlaceObject : MonoBehaviour
{
    public ARRaycastManager RayCastManager;
    public GameObject objectToCreate;
    List<ARRaycastHit> hits = new List<ARRaycastHit>();
    bool alreadycreated;
    public GameObject SpamWarning;
    GameObject spawnedObject;
    const float minSafeItemDist = 5;
    const float maxSafeDist = 15;
    const float safefDist = 10;

    void Update()
    {
        if (alreadycreated)
        {
            return;
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                SpawnOnPos(Camera.main.transform.position + Camera.main.transform.forward * 20, Quaternion.identity);
            }
        }

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
                var hit = hits[0];
                SpawnOnPos(hit.pose.position, hit.pose.rotation);
            }
        }
        else
        {
            RayCastManager = FindObjectOfType<ARRaycastManager>();
        }
    }

    void SpawnOnPos(Vector3 pos, Quaternion rot)
    {
        if (Vector3.Distance(Camera.main.transform.position, pos) < minSafeItemDist || Vector3.Distance(Camera.main.transform.position, pos) > maxSafeDist)
        {
            Debug.Log("Te has pasadooo");
            pos = Camera.main.transform.position + (pos - Camera.main.transform.position).normalized * safefDist;
        }
        spawnedObject = GameObject.Instantiate(objectToCreate, pos, rot);
        spawnedObject.transform.localScale = Vector3.one * 0.4f;
        spawnedObject.SetActive(true);
        spawnedObject.transform.GetChild(0).gameObject.SetActive(true);
        alreadycreated = true;
        SpamWarning.SetActive(false);
    }

    public void ResetObject()
    {
        if (spawnedObject)
        {
            Destroy(spawnedObject, 0);
        }
        alreadycreated = false;
        SpamWarning.SetActive(true);
    }
}
