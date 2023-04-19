using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    private const float Y_ANGLE_MIN = 0.0f;
    private const float Y_ANGLE_MAX = 180.0f;

    public Transform mLookAt;
    public Vector3 mCamOffset;

    private float mMouseX = 0.0f;
    private float mMouseY = 0.0f;


    private bool mIsCameraRotation = false;
    private Vector3 mClickPos = Vector2.zero;
    private Quaternion mPrevCamRotation;

    private void Awake()
    {
        mCamOffset = new Vector3 (this.transform.position.x, this.transform.position.y, this.transform.position.z);
        mLookAt = GameObject.FindWithTag("Player").transform;
        mPrevCamRotation = this.transform.rotation;
    }

    private void Update()
    {
        this.transform.position = mLookAt.position + mCamOffset;

        // 마우스 휠 클릭
        if(Input.GetMouseButtonDown(2))
        {
            mIsCameraRotation = true;
            mClickPos = this.transform.position;
            mPrevCamRotation = this.transform.rotation;
        }
    
        if (Input.GetMouseButtonUp(2))
        {
            mIsCameraRotation = false;
            this.transform.position = mClickPos;
            this.transform.rotation = mPrevCamRotation;
        }

        if (mIsCameraRotation)
        {
            this.transform.rotation = mPrevCamRotation;

            float mDeltaX = Input.GetAxis("Mouse X");
            float mDeltaY = Input.GetAxis("Mouse Y");


            mMouseX += mDeltaX;
            mMouseY += mDeltaY;

            mMouseY = Mathf.Clamp(mMouseY, Y_ANGLE_MIN, Y_ANGLE_MAX);
            Quaternion rotation = Quaternion.Euler(mMouseY, mMouseX, 0);
            this.transform.rotation = mPrevCamRotation*rotation;
                    
           
        }

    }


}
