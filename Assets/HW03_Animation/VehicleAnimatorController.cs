using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class VehicleAnimatorController : MonoBehaviour
{
    public Animator animator;

    public void StartMoving()
    {
        animator.Play("Vehicle_Move", 0, 0f);
    }
}