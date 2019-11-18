using AssemblyCSharp;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#region Author & Version
/* ========================================================================  
*Author：WLY 
* File name：
* Version：V1.0.1
* Company: 
* 创建：    
* Date : 2019.9.25  13:50
* 功能描述：     .................动画管理..............    
* 版本：     主.次.月日.时分  修改者姓名  修改内容    
*            ............       ....      .......        
* ========================================================================
*/
#endregion


public class ManagerAni : MonoBehaviour {
    Animator ani;

    void Awake()
    {
        ani = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && ManagerGame.gameProgress == 2)
        {
            MyDebug.Log("=======================按下Q键================");
            AniWork();
        }
    }

    public void AniWork()
    {
        ani.SetBool("iswork", true);
        StartCoroutine(IDleyLookAtCamera(6));
    }

    IEnumerator IDleyLookAtCamera(int delaytime)
    {
        yield return new WaitForSeconds(delaytime);
        ManagerGame.instance.cameraLookAt.gameObject.SetActive(true);
    }

    void FinishWork()
    {
        ManagerGame.gameProgress = 3;
    }
}
