using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTo : MonoBehaviour {

    public void  MoveToPosition(Vector3 target)
    {
        transform.position = Vector3.MoveTowards(transform.position, target, 1f);
    }
}
