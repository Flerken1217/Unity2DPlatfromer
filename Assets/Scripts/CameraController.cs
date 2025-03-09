using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //相机默认的z位置不在0，在-10，所以相机的z位置不能和player一样
        //且相机的y位置不能随着player上下跑，会造成颠的感觉
        //相机唯一移动的就是玩家的x。
        transform.position=new Vector3(target.position.x,transform.position.y,transform.position.z);
    }
}
