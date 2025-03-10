using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    //远景和中间背景的位置
    public Transform farBackground,middleBackground;
    //相机能到达的最高和最低
    public float minHeight,maxHeight;
    //上一帧posoition
    private Vector2 lastPosition;

    // Start is called before the first frame update
    void Start()
    {
        // lastPosition=transform.position.x;
        lastPosition=transform.position;//会自动截断z
    }

    // Update is called once per frame
    void Update()
    {
        //相机默认的z位置不在0，在-10，所以相机的z位置不能和player一样
        //Clamp函数将相机的位置钳制在最小和最大值之间
        transform.position=new Vector3(target.position.x,Mathf.Clamp(target.position.y,minHeight,maxHeight),transform.position.z);

        //计算这一帧和上一帧之间character移动了多少
        Vector2 amountToMove=new Vector2(transform.position.x-lastPosition.x,transform.position.y-lastPosition.y);

        //更改远景近景的移动速度
        //远景完全跟着camera移动
        farBackground.position+=new Vector3(amountToMove.x,amountToMove.y,0f);
        //近景以0.5倍的速度跟着character动
        middleBackground.position+=new Vector3(amountToMove.x,amountToMove.y,0f)*0.5f;

        //结束时将当前的x位置传给lastPosition保存
        lastPosition=transform.position;
    }
}
