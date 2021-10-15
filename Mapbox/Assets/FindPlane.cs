using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class FindPlane : MonoBehaviour
{

    //this is in charge of detecting Raycasts
    public ARRaycastManager _raycastManager;

    //When we raycast, we have a list of everything the raycast hits here to check against
    public List<ARRaycastHit> raycastHits = new List<ARRaycastHit>();
    
    public Camera cam;

    public GameObject frogPrefab;

    private GameObject newFrog = null;

    public GameObject canv;
    
    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Ray ray = cam.ViewportPointToRay(new Vector3(0.5F, 0.5F, 0));

        if (_raycastManager.Raycast(ray, raycastHits))
        {
            if (newFrog == null)
            {
                newFrog = Instantiate(frogPrefab, raycastHits[0].pose.position, Quaternion.identity);
                canv.SetActive(true);
            }
        }

    }


    private void OnDrawGizmos()
    {
        // Draws a 5 unit long red line in front of the object
        Gizmos.color = Color.red;
        Ray ray = cam.ViewportPointToRay(new Vector3(0.5F, 0.5F, 0));
        Gizmos.DrawRay(ray );
    }
}
