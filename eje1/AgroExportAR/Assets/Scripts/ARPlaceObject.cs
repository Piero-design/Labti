using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ARPlaceObject : MonoBehaviour
{
    [SerializeField]
    private GameObject objectToPlace;

    private ARRaycastManager arRaycastManager;
    private GameObject spawnedObject;
    private static List<ARRaycastHit> hits = new List<ARRaycastHit>();

    void Awake()
    {
        arRaycastManager = GetComponent<ARRaycastManager>();
    }

    void Update()
    {
        // Detectar toque en la pantalla
        if (Input.touchCount == 0)
            return;

        Touch touch = Input.GetTouch(0);

        if (touch.phase != TouchPhase.Began)
            return;

        // Lanzar raycast hacia la superficie detectada
        if (arRaycastManager.Raycast(touch.position, hits, TrackableType.PlaneWithinPolygon))
        {
            Pose hitPose = hits[0].pose;

            if (spawnedObject == null)
            {
                // Primera vez: instanciar el objeto
                spawnedObject = Instantiate(objectToPlace, hitPose.position, hitPose.rotation);
            }
            else
            {
                // Ya existe: mover a nueva posición
                spawnedObject.transform.position = hitPose.position;
                spawnedObject.transform.rotation = hitPose.rotation;
            }
        }
    }
}