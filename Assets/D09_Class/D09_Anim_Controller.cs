using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class D09_Anim_Controller : MonoBehaviour
{

    public Slider Slider;
    public Animator Animator;

    private void Start()
    {
        Animator.speed = Slider.value;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {

            Animator.speed = 1f;
            Slider.value = 1f;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Animator.speed = 0f;
            Slider.value = 0f;
        }

        Animator.speed = Slider.value;
    }

    public void OnSlider_SetSpeed()
    {
        Animator.speed = Slider.value;
    }
}
