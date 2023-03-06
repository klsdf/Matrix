using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 作者：闫辰祥
/// 矩阵元素的控制器
/// </summary>
public class ElementController : MonoBehaviour
{
    public string elementType = "0,0"; 


    void Start()
    {
        
    }


    void Update()
    {
        
    }
    private void OnMouseDrag()
    {
        Vector3 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.parent.position = new Vector3(cursorPos.x, cursorPos.y);
    }
}
