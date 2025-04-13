using UnityEngine;

public class RideController : MonoBehaviour
{
    public Animator vehicleAnimator;
    private bool isRiding = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Vehicle" && !isRiding)
        {
            isRiding = true;

            transform.SetParent(other.transform);
            transform.position = other.transform.position + Vector3.up * 2f;

            vehicleAnimator.speed = 1.0f;

            float vehicleZ = Mathf.Round(other.transform.position.z);

            vehicleAnimator.ResetTrigger("Move_Front");
            vehicleAnimator.ResetTrigger("Move_Back");

            if (vehicleZ == -30f)
            {
                vehicleAnimator.SetTrigger("Move_Front");
            }
            else if (vehicleZ == 30f)
            {
                vehicleAnimator.SetTrigger("Move_Back");
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "Vehicle" && isRiding)
        {
            isRiding = false;
            transform.SetParent(null);
            vehicleAnimator.speed = 0.0f;
        }
    }
}
