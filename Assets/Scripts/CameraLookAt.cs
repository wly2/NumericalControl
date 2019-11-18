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
* 功能描述：     .................实现游戏逻辑..............    
* 版本：     主.次.月日.时分  修改者姓名  修改内容    
*            ............       ....      .......        
* ========================================================================
*/
#endregion


public class CameraLookAt : ManagerCamera
{
    [SerializeField] Transform traTestStep1;
    [SerializeField] Transform traWorkResult;

    private void Update()
    {
        StartCoroutine(ILookAtTestStep1());
        if (ManagerGame.gameProgress == 3)
        {
            base.LookAtAppointTarget();
            base.LookAtTarget = traWorkResult;
        }
    }

   public IEnumerator ILookAtTestStep1()
    {
        yield return new WaitForSeconds(2);
        LookAtTestStep1();

    }

    public void LookAtTestStep1()
    {
        base.LookAtAppointTarget();
        base.LookAtTarget = traTestStep1;
    }


}
