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
        // �� ��ȯ���� �����ǵ��� ����
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
