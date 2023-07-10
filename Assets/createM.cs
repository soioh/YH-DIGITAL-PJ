using UnityEngine;

public class createM : MonoBehaviour
{
    public GameObject objectCre; // A 오브젝트를 Inspector에서 할당해주세요. 
    public GameObject objectB; // B 오브젝트를 Inspector에서 할당해주세요.
    public GameObject objectA;
    public GameObject objectC;
    private bool isDragging = false; // A 오브젝트를 드래그 중인지 여부를 저장할 변수
    private Vector3 originalGravity;
    float dragNumber = 0;
    GameObject mediumO;
    //float forceGravity = 10f;

    void Start()
    {
        originalGravity = Physics.gravity; // 기존 중력 값 저장
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (hit.collider != null && hit.collider.gameObject == objectCre)
            {
                // A 오브젝트를 클릭하면 드래그 시작
                if (dragNumber == 1)
                { }
                isDragging = true;
                dragNumber += 1;
                if (dragNumber == 1)

            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            // 마우스 왼쪽 버튼을 놓으면 드래그 종료
            isDragging = false;
            objectB.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            Time.timeScale = 0f;
            Physics2D.gravity = originalGravity;
        }

        if (isDragging)
        {
            //시간 다시 재개
            Time.timeScale = 1f;

            // A 오브젝트를 드래그하면 B 오브젝트를 마우스 커서 위치로 이동
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePosition.y = objectB.transform.position.y;
            mousePosition.z = 0f; // 2D 상에서는 z 위치를 0으로 고정
            objectB.transform.position = mousePosition;

            //드래그 중에 중력 만땅
            objectB.GetComponent<Rigidbody2D>().AddForce(Vector2.down);

            //다른 오브젝트 힘0 중력 0방법으로
            Physics2D.gravity = Vector2.zero;
            objectA.GetComponent<Rigidbody2D>().velocity = Vector2.zero;


        }
    }
}