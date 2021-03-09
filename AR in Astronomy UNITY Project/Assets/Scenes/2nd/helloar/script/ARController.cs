using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleARCore;

#if UNITY_EDITOR
using input = GoogleARCore.InstantPreviewInput;
#endif


public class ARController : MonoBehaviour
{
    public GameObject GridPrefab;
    public GameObject portal;
    public GameObject ARCamera;
    private List<TrackedPlane> m_NewTrackedPlanes = new List<TrackedPlane>();

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //check ar core session
        if (Session.Status != SessionStatus.Tracking)
        {
            return;
        }

        Session.GetTrackables<TrackedPlane>(m_NewTrackedPlanes, TrackableQueryFilter.New);
        for (int i = 0; i < m_NewTrackedPlanes.Count; ++i)
        {
            GameObject grid = Instantiate(GridPrefab, Vector3.zero, Quaternion.identity, transform);
            grid.GetComponent<GridVisualiser>().Initialize(m_NewTrackedPlanes[i]);
        }

        Touch touch;
        if (Input.touchCount < 1 || (touch = Input.GetTouch(0)).phase != TouchPhase.Began)
        {
            return;

        }


        TrackableHit hit;
        if (Frame.Raycast(touch.position.x, touch.position.y, TrackableHitFlags.PlaneWithinPolygon, out hit))
        {
            portal.SetActive(true);

            Anchor anchor = hit.Trackable.CreateAnchor(hit.Pose);

            portal.transform.position = hit.Pose.position;
            portal.transform.rotation = hit.Pose.rotation;

            Vector3 cameraposition = ARCamera.transform.position;
            cameraposition.y = hit.Pose.position.y;
            portal.transform.LookAt(cameraposition, portal.transform.up);
            portal.transform.parent = anchor.transform;
        }
    }
}