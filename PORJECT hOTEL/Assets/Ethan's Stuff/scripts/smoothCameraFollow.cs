using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smoothCameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public Quaternion rotationOffset;
    [Range(1, 10)]
    public float smoothFactor;

    private void FixedUpdate()
    {
        Follow();
    }

    void Follow()
    {
        Vector3 targetPosition = target.position + offset;
        Vector3 smoothPosition = Vector3.Lerp(transform.position, targetPosition, smoothFactor * Time.fixedDeltaTime);
        transform.position = smoothPosition;
        if (target.CompareTag("rotatable"))
        {
            Quaternion targetRotation = target.rotation * rotationOffset;
            transform.rotation = targetRotation;
        }
        else if (target.CompareTag("Player"))
        {
            transform.rotation = Quaternion.identity * rotationOffset;
        }
    }
}

