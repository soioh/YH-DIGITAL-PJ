using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopT : MonoBehaviour

{
    void Start()
    {
        Time.timeScale = 0f;
    }
    

    public void OnButtonClick()
    {
        if (Time.timeScale == 0f)
        {
            // �ð��� �̹� �����ִ� ���, �ٽ� �簳
            Time.timeScale = 1f;
        }
        else
        {
            // �ð��� �帣�� �ִ� ���, ����
            Time.timeScale = 0f;
        }
    }
}