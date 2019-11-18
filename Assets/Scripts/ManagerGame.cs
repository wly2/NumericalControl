using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using AssemblyCSharp;
using UnityEngine.UI;

#region Author & Version
/* ========================================================================  
*Author：WLY 
* File name：
* Version：V1.0.1
* Company: 
* 创建：    
* Date : 2019.9.25  13:50
* 功能描述：     .................实现游戏逻辑..............    
* 版本：     主.次.月日.时分  修改者姓名  修改内容    
*            ............       ....      .......        
* ========================================================================
*/
#endregion

public class ManagerGame : MonoSingleton<ManagerGame>
{
    public GameObject lights;//灯光
    public Text txtTip;
    [SerializeField] GameObject screenComputer;
    public static int gameProgress = 1;
    public Camera cameraLookAt;

    void Awake()
    {
        ClearTip();
    }

    private void FixedUpdate()
    {

    }

/// <summary>
/// 白天模式
/// </summary>
    public void Noon()
    {

        lights.gameObject.SetActive(true);
    }

/// <summary>
/// 夜晚模式
/// </summary>
    public void Night()
    {
        lights.gameObject.SetActive(false);
    }

    /// <summary>
    /// OnTriggerEnter is called when the Collider other enters the trigger.
    /// </summary>
    /// <param name="other">The other Collider involved in this collision.</param>
    void OnTriggerStay(Collider something)
    {
        if (something.tag == "anishukong" && gameProgress ==1)
        {
            MyDebug.Log("====================发生碰撞=====================");
            txtTip.text = ConfigPath.Tip.Tip1;

            if (Input.GetKeyDown(KeyCode.V) && gameProgress ==1)
            {
                MyDebug.Log("====================按下V键=====================");
                screenComputer.SetActive(true);
                ClearTip();

                gameProgress = 2;
            }

            if (gameProgress == 2)
            {
                txtTip.text = ConfigPath.Tip.Tip2;
            }
        }

    }

    /// <summary>
    /// 清空提示面板
    /// </summary>
    public void ClearTip()
    {
        txtTip.text = "";
    }

}
