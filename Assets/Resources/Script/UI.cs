using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour {

    public GameObject Matrioska;
    public GameObject camera_GameObject;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.touchCount == 1)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Moved)
            {
                Vector2 NewPosition = MatrioskaPosition();
            }
        }
    }

    Vector2 MatrioskaPosition()
    {
        return camera_GameObject.GetComponent<Camera>().ScreenToWorldPoint(Matrioska.transform.position);
    }
}
