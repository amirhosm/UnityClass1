using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoveCube : MonoBehaviour
{
    public float moveSpeed = 0.5f;
    public float rotateSpeed = 0.5f;
    Rigidbody rb;
    bool isMoving;
    bool canJump;

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
        //Debug.Log("Update");
        //Debug.Log(Input.GetAxis("Horizontal"));
        //Debug.Log(Input.GetAxis("Vertical"));
        //transform.position += new Vector3(0, 0, speed * Time.deltaTime);
        //transform.position += new Vector3(0, 0, speed * Time.deltaTime * Input.GetAxis("Vertical"));

        if (rb.velocity.y == 0) canJump = true;

        transform.Translate(transform.forward * moveSpeed * Time.deltaTime * 1);

        //transform.Rotate(new Vector3(0, rotateSpeed * Time.deltaTime * Input.GetAxis("Horizontal"), 0));

        if (Input.GetKeyUp(KeyCode.Space))
        {
            Debug.Log("Jump " + canJump);
            if (canJump)
            {
                Debug.Log("GetKeyUp");
                rb.AddForce(Vector3.up * 750);
                canJump = false;
                //transform.DOJump(new Vector3(0, 1.6f, 0), 1, 1, 1);
            }

        }

        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            Debug.Log("Left "+isMoving);
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
            }
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            //if (transform.position.x < 2)
            //transform.Translate(Vector3.right * 2);
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
            }
        }
    }

    void CompletedMove()
    {
        isMoving = false;
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
