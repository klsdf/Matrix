using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 作者：闫辰祥
/// 贴纸的控制器
/// </summary>
public class stickerController : MonoBehaviour
{

    public enum StrickerType
    {
        转置,
        太阳
    }

    public StrickerType 贴纸类型;

    void Start()
    {
        
    }


    void Update()
    {
        
    }
    private void OnMouseDrag()
    {
        Vector3 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(cursorPos.x, cursorPos.y);
    }
}
