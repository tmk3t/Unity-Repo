using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    //回転速度
    public float rotateSpeed = 1;
    //車が進むorバックする時に加える力
    public float power = 250;

    Rigidbody rb;

    //車が動けるか
    bool moveEnabled = true;

    //車が動いているか
    bool isMoving;


    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        isMoving = false;
    }

    // Update is called once per frame
    void Update()
    {
        //moveEnabled = true;

        //車が浮かない様に下方向に力を加える
        rb.AddForce(transform.up * -25.0f);

        //車が動いていたらisMoving = true;にする
        if (rb.IsSleeping())
        {
            isMoving = false;
            Debug.Log("車配sleepModeです");
        }
        else
        {
            isMoving = true;
            Debug.Log("車は動いています");

        }

        if (moveEnabled)
        {
            if (Input.GetKey(KeyCode.W))
            {
                Debug.Log("進んでます");
                isMoving = true;
                rb.AddForce(transform.forward * power);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                Debug.Log("バックしています");
                isMoving = true;
                rb.AddForce(transform.forward * -power);
            }
            else
            {
                isMoving = false;
            }

            if (Input.GetKey(KeyCode.A) && isMoving)//左へ曲がる
            {
                transform.Rotate(new Vector3(0, -1 * rotateSpeed, 0));
            }

            if (Input.GetKey(KeyCode.D) && isMoving)//右へ曲がる
            {
                transform.Rotate(new Vector3(0, rotateSpeed, 0));
            }


        }
    }

    /*
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("地面触れた");
        moveEnabled = true;

    }

    void OnCollisionExit(Collision collision)
    {
        Debug.Log("地面離れた");
        moveEnabled = false;

    }

    void OnCollisionStay(Collision collisionInfo)
    {
        //Debug.Log("地面のふれています");

    }
    */

}

