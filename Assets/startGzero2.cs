using UnityEngine;

public class startGzero : MonoBehaviour
{
    private Rigidbody2D rb; // Rigidbody2D 컴포넌트에 접근하기 위한 변수
    //private float gravityScaleA = 1; // 중력 사용 여부를 저장하는 변수
    public float gravityScale;
    private int numberClick = 0;



    private void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // 현재 게임 오브젝트에 부착된 Rigidbody2D 컴포넌트를 가져옵니다.
        rb.gravityScale = 0f;

    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // 스페이스바 눌렀을 때
            numberClick += 1;
            if (numberClick == 1)
            { ToggleGravity(); }
        }
    }

    private void ToggleGravity()
    {
        rb.gravityScale = 1f; // 중력 사용
    }
}
