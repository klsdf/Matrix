using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 作者：闫辰祥
/// 矩阵贴纸可以对一个照片区域进行变换
/// </summary>
public class MatrixSticker : HandAccountBase
{
    public enum MatrixType
    {
        转置,
        镜像,
        x轴缩放,
    }

    public MatrixType 矩阵变换类型;

    void Start()
    {
        
    }


    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        collision.SendMessage("转置");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        collision.SendMessage("恢复");
    }

}
