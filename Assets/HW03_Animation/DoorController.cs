using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public Animator doorAnimator;
    public Transform player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Vector3 toPlayer = player.position - transform.position;
            float dot = Vector3.Dot(transform.forward, toPlayer);

            if (dot > 0)
                doorAnimator.Play("Open_Outside");
            else 
                doorAnimator.Play("Open_Inside");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            doorAnimator.Play("Close");
        }
    }
}
