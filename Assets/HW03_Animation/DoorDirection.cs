using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorDirection : MonoBehaviour
{
    public Animator doorAnimator;
    public Transform player;

    private bool isOpen = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !isOpen)
        {
            Vector3 toPlayer = player.position - transform.position;
            float dot = Vector3.Dot(transform.forward, toPlayer.normalized);

            if (dot > 0.1f)
            {
                doorAnimator.SetInteger("status", 2); // Open outward
                Debug.Log("Opening outward (from inside to outside)");
            }
            else
            {
                doorAnimator.SetInteger("status", 1); // Open inward
                Debug.Log("Opening inward (from outside to inside)");
            }

            isOpen = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") && isOpen)
        {
            doorAnimator.SetInteger("status", 0); // Close door
            isOpen = false;
            Debug.Log("Closing door");
        }
    }
}
