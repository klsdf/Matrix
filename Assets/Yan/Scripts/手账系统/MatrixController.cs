using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 作者：闫辰祥
/// 手账中，每一个网格的控制器
/// </summary>
public class MatrixController : MonoBehaviour
{
    public MatrixType matrixType;//矩阵的类型

    public GameObject[] elements;

    public enum MatrixType
    {
        一行一列,
        一行两列,
        两行一列
    }


    void Start()
    {
        
    }


    void Update()
    {

        if (Input.GetMouseButtonDown(1))
        {
            转置();
        }
        
    }
    private void OnMouseDrag()
    {
        //Vector3 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //transform.position = new Vector3(cursorPos.x, cursorPos.y);
    }



    private void 转置()
    {
        if (matrixType == MatrixType.两行一列)
        {
            foreach (GameObject element in elements)
            {
                ElementController elemController = element.GetComponent<ElementController>();
                if (elemController.elementType == "1,0")
                {
                    Vector3 pos = elemController.gameObject.transform.position;
                    elemController.gameObject.transform.position = new Vector3(pos.x + 10, pos.y + 10, 0f);
                    elemController.elementType = "0,1";
                    matrixType = MatrixType.一行两列;
                }
            }
        }
        else if (matrixType == MatrixType.一行两列)
        {
            foreach (GameObject element in elements)
            {
                ElementController elemController = element.GetComponent<ElementController>();
                if (elemController.elementType == "0,1")
                {
                    Vector3 pos = elemController.gameObject.transform.position;
                    elemController.gameObject.transform.position = new Vector3(pos.x - 10, pos.y - 10, 0f);
                    elemController.elementType = "1,0";
                    matrixType = MatrixType.两行一列;
                }
            }
        }

    }

}
