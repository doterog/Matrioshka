using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movMatrioska : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {
        if (GameObject.FindGameObjectWithTag("variables").GetComponent<Variables>().boolMatrio)
        {
            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
            {
                Vector2 touchPosition = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);

                GameObject sprite = GameObject.FindGameObjectWithTag("Ruin");
                if (sprite.GetComponent<SpriteRenderer>().bounds.Contains(touchPosition))
                {
                }
            }
        }
    }
}
