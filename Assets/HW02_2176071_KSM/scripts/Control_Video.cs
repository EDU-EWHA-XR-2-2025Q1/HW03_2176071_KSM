using UnityEngine;
using UnityEngine.Video;

public class Control_Video : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    void Start()
    {
        if (videoPlayer != null)
        {
            if (PersistentStateManager.Instance != null && PersistentStateManager.Instance.isTVOn)
            {
                videoPlayer.Play();
            }
            else
            {
                videoPlayer.Stop();
            }
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            if (videoPlayer != null)
            {
                if (videoPlayer.isPlaying)
                {
                    videoPlayer.Stop();
                    PersistentStateManager.Instance.isTVOn = false; // ⛔ 꺼짐 상태 저장
                }
                else
                {
                    videoPlayer.Play();
                    PersistentStateManager.Instance.isTVOn = true;  // ✅ 켜짐 상태 저장
                }
            }
        }
    }
}
