using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{

    Camera mainCamera;

    float lastValue = 0f;

	void Start ()
    {
        mainCamera = GetComponent<Camera>();
	}

    private void Update()
    {
        Vector2 pos = Input.mousePosition;
        float delta = Input.GetAxis("Mouse ScrollWheel") - lastValue;
        if (delta != 0)
        {
            float size = mainCamera.orthographicSize - (mainCamera.orthographicSize * delta * Time.deltaTime * 30f);
            mainCamera.orthographicSize = Mathf.Clamp(size, 3f, 6.5f);
        }

        //if (pos.y > (float)Screen.height * 0.9f)
        //{
        //    transform.position += Vector3.right + Vector3.forward * Time.deltaTime * 1f;
        //}
        //if (pos.y < (float)Screen.height * 0.1f)
        //{
        //    transform.position += Vector3.left + Vector3.back * Time.deltaTime * 1f;
        //}

        //if (pos.x < (float)Screen.width * 0.1f)
        //{
        //    transform.position += Vector3.forward + Vector3.left * Time.deltaTime * 1f;
        //}
        //if (pos.x > (float)Screen.width * 0.9f)
        //{
        //    transform.position += Vector3.forward + Vector3.right * Time.deltaTime * 1f;
        //}

        if (pos.y > (float)Screen.height * 0.7f && pos.x > (float)Screen.width * 0.7f)
        {
            transform.position += Vector3.right * Time.deltaTime * 5f;
        }
        if (pos.y < (float)Screen.height * 0.3f && pos.x < (float)Screen.width * 0.3f)
        {
            transform.position += Vector3.left * Time.deltaTime * 5f;
        }

        if (pos.y > (float)Screen.height * 0.7f && pos.x < (float)Screen.width * 0.3f)
        {
            transform.position += Vector3.forward * Time.deltaTime * 5f;
        }
        if (pos.y < (float)Screen.height * 0.3f && pos.x > (float)Screen.width * 0.7f)
        {
            transform.position += Vector3.back * Time.deltaTime * 5f;
        }

    }

}
