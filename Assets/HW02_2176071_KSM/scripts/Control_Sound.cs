using UnityEngine;

public class Control_Sound : MonoBehaviour
{
    public AudioSource soundSource;

    void Start()
    {
        if (soundSource != null)
        {
            if (PersistentStateManager.Instance != null && PersistentStateManager.Instance.isRadioOn)
            {
                soundSource.Play();
            }
            else
            {
                soundSource.Stop();
            }
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (soundSource != null)
            {
                if (soundSource.isPlaying)
                {
                    soundSource.Stop();
                    PersistentStateManager.Instance.isRadioOn = false; // ²¨Áü »óÅÂ ÀúÀå
                }
                else
                {
                    soundSource.Play();
                    PersistentStateManager.Instance.isRadioOn = true;  // ÄÑÁü »óÅÂ ÀúÀå
                }
            }
        }
    }
}
