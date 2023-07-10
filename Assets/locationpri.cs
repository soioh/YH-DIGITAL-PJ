using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class locationpri : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform objectA;
    //public TMP_Text displayText;
    public TextMeshProUGUI displayText;

    void Start()
    {

        //Cursor.lockState = CursorLockMode.Confined;
        displayText = GetComponent<TextMeshProUGUI>();
        

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 velocity = objectA.rigidbody2D.velocity;
        displayText.text = "v:" + speed;
        float speed = velocity.magnitude;
        //Debug.Log("물체의 속도: " + speed);
    }
}
