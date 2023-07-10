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
            // 시간이 이미 멈춰있는 경우, 다시 재개
            Time.timeScale = 1f;
        }
        else
        {
            // 시간이 흐르고 있는 경우, 멈춤
            Time.timeScale = 0f;
        }
    }
}