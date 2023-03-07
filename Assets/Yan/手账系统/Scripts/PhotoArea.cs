using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 作者：闫辰祥
/// 照片区域，游戏的核心
/// </summary>
public class PhotoArea : HandAccountBase
{

    Transform saveTranform;
    void Start()
    {
        saveTranform = transform;
    }


    void Update()
    {
      
    }

    public void 转置()
    {
       Transform child =  transform.GetChild(1);
        if (child.transform.position.y < 0)
        {
            child.transform.localPosition= new Vector3(1,0,0);

        }

    }

    public void 恢复()
    {
        //transform = saveTranform;
        Transform child = transform.GetChild(1);
        child.transform.localPosition = new Vector3(0, -1, 0);

    }


}
