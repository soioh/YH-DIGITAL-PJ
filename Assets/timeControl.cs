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
}
