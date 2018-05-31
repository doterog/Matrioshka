using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag_Camera : MonoBehaviour
{

    public GameObject camera_GameObject;

    Vector2 StartPosition;
    Vector2 DragStartPosition;
    Vector2 DragNewPosition;
    Vector2 Finger0Position;

    // Update is called once per frame
    void Update()
    {

        if (Input.touchCount == 1)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Moved)
            {
                Vector2 NewPosition = GetWorldPosition();
                Vector2 PositionDifference = NewPosition - StartPosition;
                this.transform.Translate(-PositionDifference);
            }
            StartPosition = GetWorldPosition();
        }
    }

    Vector2 GetWorldPosition()
    {
        return this.GetComponent<Camera>().ScreenToWorldPoint(Input.mousePosition);
    }

    Vector2 GetWorldPositionOfFinger(int FingerIndex)
    {
        return this.GetComponent<Camera>().ScreenToWorldPoint(Input.GetTouch(FingerIndex).position);
    }
}