using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject target;

    public float yOffset = 3.0f;

    void Update()
    {
        if (target != null)
        {
            Vector3 targetPosition = target.transform.position;
            transform.position = new Vector3(targetPosition.x, targetPosition.y + yOffset, -910);
        }
    }
}
