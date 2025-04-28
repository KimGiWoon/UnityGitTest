using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] float jumpForce;
    [SerializeField] Rigidbody rb;
    private bool isGround;



    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        Move();
        if (Input.GetKeyDown(KeyCode.Space) && isGround) // ���� �پ� ���� �� �� �����ϰ� ����
        {
            Jump();
        }
    }

    void Move() // wasd ����Ű�� ���� ������ ����
    {
        float moveX = 0f;
        float moveZ = 0f;



        if (Input.GetKey(KeyCode.W))
            moveZ = 1f;
        if (Input.GetKey(KeyCode.S))
            moveZ = -1f;
        if (Input.GetKey(KeyCode.A))
            moveX = -1f;
        if (Input.GetKey(KeyCode.D))
            moveX = 1f;

        Vector3 move = new Vector3(moveX, 0f, moveZ).normalized;
        Vector3 moveVelocity = move * moveSpeed;
        Vector3 currentVelocity = rb.velocity;

        rb.velocity = new Vector3(moveVelocity.x, currentVelocity.y, moveVelocity.z);        // ���� �ӵ�(y)�� �״�� �����ϰ�, ���� �̵��� ����
    }

    void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGround = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGround = false;
        }
    }


}
