using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallPlacer : MonoBehaviour
{

    bool IsEditing = true;

    public GameObject WallPrefab;
    public Camera Cam;

    public List<Transform> Walls;

    Transform currentWall;
    float lastValue = 0f;

    private void Start()
    {
        Cam = FindObjectOfType<Camera>();
        currentWall = Instantiate(WallPrefab, transform).transform;
    }

    private void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            if (currentWall != null && IsEditing)
            {
                Debug.Log("Pressed");
                Walls.Add(currentWall);
                currentWall = Instantiate(WallPrefab, transform).transform;
            }
        }

        float delta = Input.GetAxis("Mouse ScrollWheel") - lastValue;
        if (delta != 0)
        {
            int direction = delta > 0 ? 1 : -1;
            float angle = currentWall.localEulerAngles.y + 90f * direction;
            currentWall.localEulerAngles = Vector3.up * angle;
        }

        RaycastHit hit;
        if (Physics.Raycast(Cam.ScreenPointToRay(Input.mousePosition), out hit, 50f))
        {
            if (hit.transform.tag == "Base")
            {
                //Debug.Log("HIT" + hit.transform.name);
                Vector3 pos = hit.point.ToWhole();
                currentWall.position = pos;
            }
        }
    }

}
