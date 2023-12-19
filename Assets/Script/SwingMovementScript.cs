using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwingMovementScript : MonoBehaviour
{
    //public float rotationSpeed = 5f;
    //public float moveSpeed = 2f;

    //void Update()
    //{
    //    // 로테이션을 변경 (여기서는 z축을 중심으로 회전)
    //    transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);

    //    // 변경된 로테이션의 z값에 따라 포지션을 움직임
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

    //    // D 키를 눌렀을 때만 로테이션 및 이동 수행
    //    if (Input.GetKey(KeyCode.D))
    //    {
    //        // 로테이션을 변경 (여기서는 z축을 중심으로 회전)


    //        // 변경된 로테이션의 z값에 따라 포지션을 움직임
    //        float zRotation = transform.eulerAngles.z;
    //        Vector3 newPosition = new Vector3(Mathf.Cos(zRotation * Mathf.Deg2Rad), Mathf.Sin(zRotation * Mathf.Deg2Rad), 0);
    //        transform.position += newPosition * moveSpeed * Time.deltaTime;
    //    }
    //}

    //=====================================================================================

    //public float moveSpeed = 2f;

    //void Update()
    //{
    //    //D 키를 눌렀을 때
    //    if (Input.GetKey(KeyCode.D))
    //    {
    //        //변경된 로테이션의 z값에 따라 포지션을 움직임
    //        MoveBasedOnRotation();
    //    }
    //    //A 키를 눌렀을 때
    //    else if (Input.GetKey(KeyCode.A))
    //    {
    //        //변경된 로테이션의 z값에 따라 포지션을 반대 방향으로 움직임
    //        MoveBasedOnRotation(true);
    //    }
    //}

    //void MoveBasedOnRotation(bool reverseDirection = false)
    //{
    //    float zRotation = transform.eulerAngles.z;

    //    //만약 reverseDirection이 true이면 반대 방향으로 이동
    //    float direction = reverseDirection ? -1f : 1f;

    //    Vector3 newPosition = new Vector3(Mathf.Cos(zRotation * Mathf.Deg2Rad), Mathf.Sin(zRotation * Mathf.Deg2Rad), 0);
    //    transform.position += newPosition * moveSpeed * direction * Time.deltaTime;
    //}

    //========================================================================

    //public float rotationSpeed = 5f;
    //public float moveSpeed = 2f;

    //void Update()
    //{
    //    // D 키를 눌렀을 때
    //    if (Input.GetKey(KeyCode.D))
    //    {
    //        // 변경된 로테이션의 z값에 따라 포지션을 움직임
    //        MoveBasedOnRotation();
    //    }
    //    // A 키를 눌렀을 때
    //    else if (Input.GetKey(KeyCode.A))
    //    {
    //        // 변경된 로테이션의 z값에 따라 포지션을 반대 방향으로 움직임
    //        MoveBasedOnRotation(true);
    //    }
    //}

    //void MoveBasedOnRotation(bool reverseDirection = false)
    //{
    //    float zRotation = transform.eulerAngles.z;

    //    // 만약 reverseDirection이 true이면 반대 방향으로 이동
    //    float direction = reverseDirection ? -1f : 1f;

    //    // x와 y 값을 교체하여 y 방향으로 움직이도록 함
    //    Vector3 newPosition = new Vector3(Mathf.Sin(zRotation * Mathf.Deg2Rad), Mathf.Cos(zRotation * Mathf.Deg2Rad), 0);
    //    transform.position += newPosition * moveSpeed * direction * Time.deltaTime;
    //}

    //===========================================================================

    /*
    public Tutorial_GrapplingGun grapplingGun;  // 그래플링 건 스크립트
    public float movementSpeed = 5f;  // 플레이어 이동 속도

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

        // 'A' 키를 누르면 왼쪽으로 움직임
        if (Input.GetKey(KeyCode.A))
        {
            MovePlayer(Vector2.left);
        }

        // 'D' 키를 누르면 오른쪽으로 움직임
        if (Input.GetKey(KeyCode.D))
        {
            MovePlayer(Vector2.right);
        }
    }

    void MovePlayer(Vector2 direction)
    {
        // 로프를 타고 움직일 때 플레이어에게 가속을 줌
        if (isGrappling)
        {
            // 현재 플레이어의 오른쪽 방향을 기준으로 한 로컬 좌표계에서의 방향
            Vector2 localDirection = transform.right * direction.x;

            // 로컬 방향에 따라 플레이어를 이동
            playerRigidbody.AddForce(localDirection * movementSpeed);
        }
    }
    
    */
    //=====================================================================

    //public Tutorial_GrapplingGun grapplingGun;  // 그래플링 건 스크립트
    //public float movementSpeed = 5f;  // 플레이어 이동 속도
    //public float customGravity = 9.8f;  // 사용자 정의 중력값

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

    //    // 'A' 키를 누르면 왼쪽으로 움직임
    //    if (Input.GetKey(KeyCode.A))
    //    {
    //        MovePlayer(Vector2.left);
    //    }

    //    // 'D' 키를 누르면 오른쪽으로 움직임
    //    if (Input.GetKey(KeyCode.D))
    //    {
    //        MovePlayer(Vector2.right);
    //    }
    //}

    //void MovePlayer(Vector2 direction)
    //{
    //    // 로프를 타고 움직일 때 플레이어에게 가속을 줌
    //    if (isGrappling)
    //    {
    //        //playerRigidbody.AddForce(direction * movementSpeed);

    //        playerRigidbody.AddForce(direction * movementSpeed - Vector2.up * customGravity * playerRigidbody.mass);
    //    }
    //}

    //==================================================================

    public Tutorial_GrapplingGun grapplingGun;  // 그래플링 건 스크립트
    public float movementSpeed = 5f;  // 플레이어 이동 속도
    public float customGravity = 9.8f;  // 사용자 정의 중력값

    private Rigidbody2D playerRigidbody;
    private bool isGrappling;

    public float rotationSpeed = 200f;

    [Header("키 코드")]
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
        }
        else
        {
            isGrappling = false;
            ResetPlayerRotation();
        }

        // 'A' 키를 누르면 왼쪽으로 움직임
        if (Input.GetKey(LeftKey))
        {
            MovePlayer(Vector2.up);
        }

        // 'D' 키를 누르면 오른쪽으로 움직임
        if (Input.GetKey(RightKey))
        {
            MovePlayer(Vector2.down);
        }
    }

    void ResetPlayerRotation()
    {
        // 목표 회전값 (오른쪽을 바라보는 회전)
        Quaternion targetRotation = Quaternion.Euler(0, 0, 0);

        // 현재 회전값에서 목표 회전값으로 천천히 회전
        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
    }

    void RotatePlayerTowardsGrapplePoint()
    {
        // 만약 그랩 중이라면
        Vector2 direction = grapplingGun.grapplePoint - (Vector2)transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

    }

    void MovePlayer(Vector2 direction)
    {
        //if (isGrappling) // 로프를 타고 움직일 때 플레이어에게 가속을 줌
        //{

        //    // 플레이어의 로컬 방향을 기준으로 한 방향으로 이동
        //    Vector2 localDirection = transform.TransformDirection(direction);

        //    // 중력의 영향을 제외한 힘을 가함
        //    playerRigidbody.AddForce(localDirection * movementSpeed - Vector2.up * customGravity * playerRigidbody.mass);
        //}


        if (isGrappling)
        {
            Vector2 localDirection = transform.TransformDirection(direction);

            Vector2 horizontalForce = localDirection * movementSpeed;
            Vector2 verticalForce = -Vector2.up * customGravity * playerRigidbody.mass;

            playerRigidbody.AddForce(horizontalForce);
            playerRigidbody.AddForce(verticalForce);
        }
    }


    //*/
}
