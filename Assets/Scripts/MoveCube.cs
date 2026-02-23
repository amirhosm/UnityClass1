using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using Unity.VisualScripting;

public class MoveCube : MonoBehaviour
{
    public bool gameStarted;
    public AnimationController animController;
    public float moveSpeed = 0.5f;
    public float rotateSpeed = 0.5f;
    Rigidbody rb;
    bool isMoving;
    bool canJump;
    SoundManager soundManager;
    bool isMouseDown;
    Vector2 mousePosStart;
    

    void OnEnable()
    {
        //Debug.Log("OnEnable");
    }
    void OnDisable()
    {
        //Debug.Log("OnDisable");
    }
    void Awake()
    {
        //Debug.Log("Awake");
        soundManager = GameObject.FindWithTag("SoundManager").GetComponent<SoundManager>();
    }

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Start");
        Application.targetFrameRate = 60;
        rb=GetComponent<Rigidbody>();
    }


    // Update is called once per frame
    void Update()
    {
        if (gameStarted)
        {

            if (Input.GetMouseButtonDown(0))
            {
                isMouseDown = true;
                mousePosStart = Input.mousePosition;
                Debug.Log(Input.mousePosition);
            }

            if (Input.GetMouseButtonUp(0))
            {
                if (isMouseDown)
                {
                    float dragDistance = Input.mousePosition.x - mousePosStart.x;
                    Debug.Log(dragDistance);
                    if (Mathf.Abs(dragDistance) > 50)
                    {
                        if (dragDistance < 0)
                        {
                            OnBTN_Left();
                        }
                        else
                        {
                            OnBTN_Right();
                        }
                    }
                    else
                    {
                        float dragDistanceY = Input.mousePosition.y - mousePosStart.y;
                        if (Mathf.Abs(dragDistanceY) > 50)
                        {
                            if (dragDistanceY > 0) OnBTN_Jump();
                        }
                    }
                }
                isMouseDown = false;
                //Debug.Log(Input.mousePosition);
            }

            if (rb.velocity.y == 0)
            {
                canJump = true;
                animController.PlayRun();
            }

            transform.Translate(transform.forward * moveSpeed * Time.deltaTime * 1);

            //transform.Rotate(new Vector3(0, rotateSpeed * Time.deltaTime * Input.GetAxis("Horizontal"), 0));

            if (Input.GetKeyUp(KeyCode.Space))
            {
                OnBTN_Jump();
            }

            if (Input.GetKeyUp(KeyCode.LeftArrow))
            {
                OnBTN_Left();
            }
            if (Input.GetKeyUp(KeyCode.RightArrow))
            {
                OnBTN_Right();
            }
        }
    }

    public void StartRun()
    {
        gameStarted = true;
        animController.PlayRun();
    }

    public void Lose()
    {
        gameStarted = false;
        animController.PlayFall();
    }

    void CompletedMove()
    {
        isMoving = false;
        animController.PlayRun();
    }

    public void OnBTN_Left()
    {
        Debug.Log("Left " + isMoving);
        //if (transform.position.x > -2)
        //transform.Translate(Vector3.left * 2);

        if (isMoving == false)
        {
            if (transform.position.x == 2)
            {
                isMoving = true;
                transform.DOLocalMoveX(0, 0.5f).OnComplete(CompletedMove);
            }
            else if (transform.position.x == 0)
            {
                isMoving = true;
                transform.DOLocalMoveX(-2, 0.5f).OnComplete(CompletedMove);
            }
            soundManager.PlaySfx_Move();
            animController.PlayLeft();
        }
    }

    public void OnBTN_Right()
    {
        Debug.Log("Right " + isMoving);
        if (isMoving == false)
        {
            if (transform.position.x == -2)
            {
                isMoving = true;
                transform.DOLocalMoveX(0, 0.5f).OnComplete(CompletedMove);
            }
            else if (transform.position.x == 0)
            {
                isMoving = true;
                transform.DOLocalMoveX(2, 0.5f).OnComplete(CompletedMove);
            }
            soundManager.PlaySfx_Move();
            animController.PlayRight();
        }
    }

    public void OnBTN_Jump()
    {
        Debug.Log("Jump " + canJump);
        //if (canJump)
        //{
        soundManager.PlaySfx_Jump();

        Debug.Log("GetKeyUp");

        rb.AddForce(Vector3.up * 850);
        canJump = false;

        //transform.DOJump(new Vector3(0, 1.6f, 0), 1, 1, 1);
        animController.PlayJump();
    }

    private void FixedUpdate()
    {
        //Debug.Log("FixedUpdate");
    }

    private void LateUpdate()
    {
        //Debug.Log("LateUpdate");
    }

}
