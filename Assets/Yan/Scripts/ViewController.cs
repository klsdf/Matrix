using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 作者：闫辰祥
/// </summary>
public class ViewController : MonoBehaviour
{
    Vector3 lastMousePosition;
    Vector3 nowMousePosition;
    bool isMouseDown;

    private Camera camera;

    void Start()
    {
        isMouseDown = false;
        camera = GetComponent<Camera>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(2))
        {
            isMouseDown = true;
        }
        if (Input.GetMouseButtonUp(2))
        {
            isMouseDown = false;
            lastMousePosition = Vector3.zero;
        }
        if (isMouseDown)
        {
            nowMousePosition = Input.mousePosition;

            if (lastMousePosition != Vector3.zero)
            {
                Vector3 offset = nowMousePosition - lastMousePosition;
                transform.position = transform.position - offset * 0.05f;


            }
            lastMousePosition = nowMousePosition;

        }
        float m = Input.GetAxis("Mouse ScrollWheel");
        camera.orthographicSize += -m;

    }
}