using UnityEngine;

public class Animation_Ride_Controller : MonoBehaviour
{
    public Animator vehicleAnimator;
    public Transform vehicle;

    private bool isRiding = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Vehicle") && !isRiding)
        {
            isRiding = true;
            transform.SetParent(vehicle);
            vehicleAnimator.SetBool("isMoving", true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Vehicle") && isRiding)
        {
            isRiding = false;
            transform.SetParent(null);
            vehicleAnimator.SetBool("isMoving", false); 
        }
    }
}
