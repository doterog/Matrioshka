using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Structure : MonoBehaviour {

    public GameObject RedRuin, BlueRuin;
    
    Vector3 positionInitial = new Vector3();

    void Start()
    {
        positionInitial = this.transform.position;
    }
    // Update is called once per frame
    void Update()
    {

        this.transform.localRotation = Quaternion.Euler(0, 0, 0);
        this.transform.position = positionInitial;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "RED_Babuska")
        {
            
            DestroyObject(this);
            GameObject Red_Ruin = Instantiate(RedRuin, positionInitial, transform.rotation) as GameObject;
            Red_Ruin.name = "Red_Ruin";
        }

        if (collision.gameObject.tag == "BLUE_Babuska")
        {
            DestroyObject(this);
            GameObject Blue_Ruin = Instantiate(BlueRuin, positionInitial, transform.rotation) as GameObject;
            Blue_Ruin.name = "Blue_Ruin";
        }
    }
}
