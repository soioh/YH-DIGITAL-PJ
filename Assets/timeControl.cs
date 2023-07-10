using UnityEngine;

public class timeControl : MonoBehaviour
{
    void Start()
    {
        Time.timeScale = 0f;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
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
}
