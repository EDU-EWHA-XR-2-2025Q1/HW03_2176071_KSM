using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleMover : MonoBehaviour
{
    public Transform room1Point;
    public Transform room2Point;

    public float speed = 3f;

    private Transform targetPoint;
    private bool isMoving = false;

    public void StartMoving()
    {
        
        float distToRoom1 = Vector3.Distance(transform.position, room1Point.position);
        float distToRoom2 = Vector3.Distance(transform.position, room2Point.position);
        targetPoint = (distToRoom1 < distToRoom2) ? room2Point : room1Point;

        isMoving = true;
    }

    public void StopMoving()
    {
        isMoving = false;
    }

    private void Update()
    {
        if (isMoving)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPoint.position, speed * Time.deltaTime);

            if (Vector3.Distance(transform.position, targetPoint.position) < 0.1f)
            {
                isMoving = false;
            }
        }
    }
}
