using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTo : MonoBehaviour
{

    private Vector3 target;

    void Start()
    {
        target = Vector3.MoveTowards(transform.position, target, 1f);
    }

    void Update()
    {
        if (transform.position != target) transform.position = Vector3.MoveTowards(transform.position, target, 1f);
    }

    public void MoveToPosition(Vector3 _target)
    {
        target = _target;
    }
}
