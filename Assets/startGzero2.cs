using UnityEngine;

public class startGzero : MonoBehaviour
{
    private Rigidbody2D rb; // Rigidbody2D ������Ʈ�� �����ϱ� ���� ����
    //private float gravityScaleA = 1; // �߷� ��� ���θ� �����ϴ� ����
    public float gravityScale;
    private int numberClick = 0;



    private void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // ���� ���� ������Ʈ�� ������ Rigidbody2D ������Ʈ�� �����ɴϴ�.
        rb.gravityScale = 0f;

    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // �����̽��� ������ ��
            numberClick += 1;
            if (numberClick == 1)
            { ToggleGravity(); }
        }
    }

    private void ToggleGravity()
    {
        rb.gravityScale = 1f; // �߷� ���
    }
}
