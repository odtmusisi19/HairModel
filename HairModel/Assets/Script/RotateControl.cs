using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateControl : MonoBehaviour
{
    // Start is called before the first frame update
    private Touch touch;
    private Vector2 touchPosition;
    private Quaternion rotationY;
    private float rotationSpeedModifier = 10f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
                rotationY = Quaternion.Euler(0f, -touch.deltaPosition.x * rotationSpeedModifier * Time.fixedDeltaTime, 0f);
                // rotationY = Quaternion.Lerp(transform.rotation, transform.rotation, rotationSpeedModifier * Time.deltaTime);
                transform.rotation = rotationY * transform.rotation;
                // Debug.Log(rotationY);
            }
        }
    }
}
