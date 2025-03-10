using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthController : MonoBehaviour
{
    //设置为单例，即整个系统里只有这一个
    //单例可以直接通过类名来调用函数
    public static PlayerHealthController instance;

    //设置生命值点数
    public int currentHealth,maxHealth;

    //游戏一旦启动，就会调用一次的
    void Awake()
    {
        instance=this;
    }

    // Start is called before the first frame update
    void Start()
    {
        //游戏开始时，将当前生命值设置为最大生命值
        currentHealth=maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //处理玩家伤害
    public void DealDamage(){
        currentHealth--;

        if(currentHealth<=0){
            gameObject.SetActive(false);
        }
    }
}
