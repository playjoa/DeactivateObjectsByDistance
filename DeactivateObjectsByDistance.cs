using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateObjectsByDistance : MonoBehaviour
{
    [SerializeField]
    private float distanceToDeactivate = 30;

    [SerializeField]
    private GameObject[] objects;

    [SerializeField]
    private Transform targetToCheckDistance;

    private float dist;

    void FixedUpdate()
    {
        CheckDistance();
    }

    void ProcessObjects(bool value)
    {
        if (objects.Length == 0)
            return;

        foreach (GameObject o in objects)
        {
            if (o.activeSelf != value)
                o.SetActive(value);
        }
    }

    void CheckDistance()
    {            
        dist = Vector3.Distance(transform.position, targetToCheckDistance.position);

        if (dist <= distanceToDeactivate)
            ProcessObjects(true);
        else
            ProcessObjects(false);
    }
}
