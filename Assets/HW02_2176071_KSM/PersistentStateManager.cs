using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistentStateManager : MonoBehaviour
{
    public static PersistentStateManager Instance;

    public bool isRadioOn = false;
    public bool isTVOn = false;
    public bool isLightOn = false;

    void Awake()
    {
        // 씬 전환에도 유지되도록 설정
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
