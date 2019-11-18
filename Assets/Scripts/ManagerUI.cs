using AssemblyCSharp;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


#region Author & Version
/* ========================================================================  
*Author：WLY 
* File name：
* Version：V1.0.1
* Company: 
* 创建：    
* Date : 2019.9.25  13:50
* 功能描述：     ...............................    
* 版本：     主.次.月日.时分  修改者姓名  修改内容    
*            ............       ....      .......        
* ========================================================================
*/
#endregion

public class ManagerUI : MonoSingleton<ManagerUI>
{
    [SerializeField] GameObject UIMenu;
    [SerializeField] Image imgHelp;
    public static bool isPup = false;//判断是否有弹窗弹出

    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        UIMenu.gameObject.SetActive(false);
    }

    /// <summary>
    /// This function is called every fixed framerate frame, if the MonoBehaviour is enabled.
    /// </summary>
    void FixedUpdate()
    {
        BtnMenu();
    }


    /// <summary>
    /// 菜单栏
    /// </summary>
    public void BtnMenu()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !UIMenu.gameObject.activeSelf)
        {
            UIMenu.gameObject.SetActive(true);

        }

        else if (Input.GetKeyDown(KeyCode.Escape) && UIMenu.gameObject.activeSelf)
        {
            UIMenu.gameObject.SetActive(false);
            imgHelp.gameObject.SetActive(false);
        }
    }

    /// <summary>
    /// 左边UI部分按钮
    /// </summary>
    /// <param name="btnName"></param>
    public void UIButton(string btnName)
    {
        switch (btnName)
        {
            case "menu":
                print("================菜单====================");
                break;
            case "setting":
                print("================设置====================");
                break;
            case "help":
                print("================帮助====================");
                if (imgHelp.gameObject.activeSelf) imgHelp.gameObject.SetActive(false);
                else imgHelp.gameObject.SetActive(true);
                break;
            case "exit":
                print("================退出====================");
                Exit();
                break;
            case "noon":
                print("================白天====================");
                ManagerGame.instance.Noon();
                break;
            case "night":
                print("================黑夜====================");
                ManagerGame.instance.Night();
                break;

        }
    }

    public void Exit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif

    }
}
