using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DamagePlayer : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //检测player碰撞地形伤害
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.tag == "Player")
        {
            // Debug.Log("Hit");
            
            //查找当前所有的object中拥有PlayerHealthController的，然后调用它的DealDamage函数
            //FindObjectOfType<PlayerHealthController>().DealDamage();

            PlayerHealthController.instance.DealDamage();

        }
    }

}
