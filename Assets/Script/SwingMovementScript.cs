using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwingMovementScript : MonoBehaviour
{
    //public float rotationSpeed = 5f;
    //public float moveSpeed = 2f;

    //void Update()
    //{
    //    // �����̼��� ���� (���⼭�� z���� �߽����� ȸ��)
    //    transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);

    //    // ����� �����̼��� z���� ���� �������� ������
    //    float zRotation = transform.eulerAngles.z;
    //    Vector3 newPosition = new Vector3(Mathf.Cos(zRotation * Mathf.Deg2Rad), Mathf.Sin(zRotation * Mathf.Deg2Rad), 0);
    //    transform.position += newPosition * moveSpeed * Time.deltaTime;
    //}

    //=====================================================================================


    //public float rotationSpeed = 5f;
    //public float moveSpeed = 2f;

    //void Update()
    //{
    //    transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);

    //    // D Ű�� ������ ���� �����̼� �� �̵� ����
    //    if (Input.GetKey(KeyCode.D))
    //    {
    //        // �����̼��� ���� (���⼭�� z���� �߽����� ȸ��)


    //        // ����� �����̼��� z���� ���� �������� ������
    //        float zRotation = transform.eulerAngles.z;
    //        Vector3 newPosition = new Vector3(Mathf.Cos(zRotation * Mathf.Deg2Rad), Mathf.Sin(zRotation * Mathf.Deg2Rad), 0);
    //        transform.position += newPosition * moveSpeed * Time.deltaTime;
    //    }
    //}

    //=====================================================================================

    //public float moveSpeed = 2f;

    //void Update()
    //{
    //    //D Ű�� ������ ��
    //    if (Input.GetKey(KeyCode.D))
    //    {
    //        //����� �����̼��� z���� ���� �������� ������
    //        MoveBasedOnRotation();
    //    }
    //    //A Ű�� ������ ��
    //    else if (Input.GetKey(KeyCode.A))
    //    {
    //        //����� �����̼��� z���� ���� �������� �ݴ� �������� ������
    //        MoveBasedOnRotation(true);
    //    }
    //}

    //void MoveBasedOnRotation(bool reverseDirection = false)
    //{
    //    float zRotation = transform.eulerAngles.z;

    //    //���� reverseDirection�� true�̸� �ݴ� �������� �̵�
    //    float direction = reverseDirection ? -1f : 1f;

    //    Vector3 newPosition = new Vector3(Mathf.Cos(zRotation * Mathf.Deg2Rad), Mathf.Sin(zRotation * Mathf.Deg2Rad), 0);
    //    transform.position += newPosition * moveSpeed * direction * Time.deltaTime;
    //}

    //========================================================================

    //public float rotationSpeed = 5f;
    //public float moveSpeed = 2f;

    //void Update()
    //{
    //    // D Ű�� ������ ��
    //    if (Input.GetKey(KeyCode.D))
    //    {
    //        // ����� �����̼��� z���� ���� �������� ������
    //        MoveBasedOnRotation();
    //    }
    //    // A Ű�� ������ ��
    //    else if (Input.GetKey(KeyCode.A))
    //    {
    //        // ����� �����̼��� z���� ���� �������� �ݴ� �������� ������
    //        MoveBasedOnRotation(true);
    //    }
    //}

    //void MoveBasedOnRotation(bool reverseDirection = false)
    //{
    //    float zRotation = transform.eulerAngles.z;

    //    // ���� reverseDirection�� true�̸� �ݴ� �������� �̵�
    //    float direction = reverseDirection ? -1f : 1f;

    //    // x�� y ���� ��ü�Ͽ� y �������� �����̵��� ��
    //    Vector3 newPosition = new Vector3(Mathf.Sin(zRotation * Mathf.Deg2Rad), Mathf.Cos(zRotation * Mathf.Deg2Rad), 0);
    //    transform.position += newPosition * moveSpeed * direction * Time.deltaTime;
    //}

    //===========================================================================

    /*
    public Tutorial_GrapplingGun grapplingGun;  // �׷��ø� �� ��ũ��Ʈ
    public float movementSpeed = 5f;  // �÷��̾� �̵� �ӵ�

    private Rigidbody2D playerRigidbody;
    private bool isGrappling = false;

    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (grapplingGun.isSwing == true)
        {
            isGrappling = true;
        }
        else
        {
            isGrappling = false;
        }

        // 'A' Ű�� ������ �������� ������
        if (Input.GetKey(KeyCode.A))
        {
            MovePlayer(Vector2.left);
        }

        // 'D' Ű�� ������ ���������� ������
        if (Input.GetKey(KeyCode.D))
        {
            MovePlayer(Vector2.right);
        }
    }

    void MovePlayer(Vector2 direction)
    {
        // ������ Ÿ�� ������ �� �÷��̾�� ������ ��
        if (isGrappling)
        {
            // ���� �÷��̾��� ������ ������ �������� �� ���� ��ǥ�迡���� ����
            Vector2 localDirection = transform.right * direction.x;

            // ���� ���⿡ ���� �÷��̾ �̵�
            playerRigidbody.AddForce(localDirection * movementSpeed);
        }
    }
    
    */
    //=====================================================================

    //public Tutorial_GrapplingGun grapplingGun;  // �׷��ø� �� ��ũ��Ʈ
    //public float movementSpeed = 5f;  // �÷��̾� �̵� �ӵ�
    //public float customGravity = 9.8f;  // ����� ���� �߷°�

    //private Rigidbody2D playerRigidbody;
    //private bool isGrappling = false;

    //void Start()
    //{
    //    playerRigidbody = GetComponent<Rigidbody2D>();
    //}

    //void Update()
    //{
    //    if (grapplingGun.isSwing == true)
    //    {
    //        isGrappling = true;
    //    }
    //    else
    //    {
    //        isGrappling = false;
    //    }

    //    // 'A' Ű�� ������ �������� ������
    //    if (Input.GetKey(KeyCode.A))
    //    {
    //        MovePlayer(Vector2.left);
    //    }

    //    // 'D' Ű�� ������ ���������� ������
    //    if (Input.GetKey(KeyCode.D))
    //    {
    //        MovePlayer(Vector2.right);
    //    }
    //}

    //void MovePlayer(Vector2 direction)
    //{
    //    // ������ Ÿ�� ������ �� �÷��̾�� ������ ��
    //    if (isGrappling)
    //    {
    //        //playerRigidbody.AddForce(direction * movementSpeed);

    //        playerRigidbody.AddForce(direction * movementSpeed - Vector2.up * customGravity * playerRigidbody.mass);
    //    }
    //}

    //==================================================================

    public Tutorial_GrapplingGun grapplingGun;  // �׷��ø� �� ��ũ��Ʈ
    public Ghost ghost;

    public float movementSpeed = 5f;  // �÷��̾� �̵� �ӵ�
    public float dashSpeed = 55f;
    public float customGravity = 9.8f;  // ����� ���� �߷°�

    private bool isGrappling;

    public bool isDash;
    public float rotationSpeed = 200f;

    private float Distance;

    [Header("Physics Ref:")]
    private Rigidbody2D playerRigidbody;


    [Header("KeyCode")]
    public KeyCode LeftKey = KeyCode.A;
    public KeyCode RightKey = KeyCode.D;
    public KeyCode DashKey = KeyCode.LeftShift;

    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (grapplingGun.isSwing == true)
        {
            isGrappling = true;
            RotatePlayerTowardsGrapplePoint();

            moveIf();
        }
        else
        {
            isGrappling = false;
            ResetPlayerRotation();
        }
        
        
    }

    void moveIf()
    {
        // 'A' Ű�� ������ �������� ������
        if (Input.GetKey(LeftKey))
        {
            MovePlayer(Vector2.up, movementSpeed);
        }

        // 'D' Ű�� ������ ���������� ������
        if (Input.GetKey(RightKey))
        {
            MovePlayer(Vector2.down, movementSpeed);
        }

        if (Input.GetKeyDown(DashKey))
        {
            if (isDash == false)
            {
                StartCoroutine(DasheLineLock());
            }
        }

        if (isDash == true)
        {
            StartCoroutine(DashSpeed());
        }
    }

    IEnumerator DashSpeed()
    {
        movementSpeed = dashSpeed;

        yield return new WaitForSeconds(.1f);

        movementSpeed = 3;
    }

    IEnumerator DasheLineLock() // �ڵ尡 ���� ���ľ� �ҵ� + ������?
    {
        isDash = true;
        Distance = grapplingGun.m_springJoint2D.distance;
        //Debug.Log(Distance);

        grapplingGun.launchToPoint = false;
        grapplingGun.m_springJoint2D.frequency = 0;
        grapplingGun.autoConfigureDistance = true;
        ghost.makeGhost = true;

        yield return new WaitForSeconds(.7f);
        
        isDash = false;

        grapplingGun.launchToPoint = true;
        grapplingGun.m_springJoint2D.frequency = grapplingGun.launchSpeed;
        grapplingGun.autoConfigureDistance = false;
        ghost.makeGhost = false;
    }

    void ResetPlayerRotation()
    {
        // ��ǥ ȸ���� (�������� �ٶ󺸴� ȸ��)
        Quaternion targetRotation = Quaternion.Euler(0, 0, 0);

        // ���� ȸ�������� ��ǥ ȸ�������� õõ�� ȸ��
        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
    }

    void RotatePlayerTowardsGrapplePoint()
    {
        // ���� �׷� ���̶��
        Vector2 direction = grapplingGun.grapplePoint - (Vector2)transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

    }

    void MovePlayer(Vector2 direction, float Speed)
    {
        if (isGrappling)
        {
            Vector2 localDirection = transform.TransformDirection(direction);

            Vector2 horizontalForce = localDirection * Speed;
            Vector2 verticalForce = -Vector2.up * customGravity * playerRigidbody.mass;

            playerRigidbody.AddForce(horizontalForce);
            playerRigidbody.AddForce(verticalForce);
        }
        Debug.Log(Speed);
    }


    //*/
}
