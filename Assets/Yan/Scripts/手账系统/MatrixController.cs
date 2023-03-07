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
    [SerializeField] Transform 女主;
    Vector2 maxmatrixelement = new Vector2(-100, -100);
    Vector2 minmatrixelement = new Vector2(100, 100);
    Vector2 scaleFactor = new Vector2();
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
    void UpdateMatrixtrans()
    {

        Vector2 m_scale = new Vector2(transform.lossyScale.y, transform.lossyScale.x);
        Vector2 m_localScale = transform.localScale;
        transform.localScale = m_scale / transform.parent.lossyScale;
        scaleFactor = m_localScale / transform.localScale;
        女主.localPosition = matrixType == MatrixType.两行一列 ? transpose(女主.localPosition) : detranspose(女主.localPosition);
        女主.localScale *= scaleFactor;
        /*Vector2 m_scale = transform.lossyScale;
        Vector2 m_localScale = transform.localScale;
        var 女主scale = 女主.lossyScale;
        var m_worldpivot = transform.localToWorldMatrix* new Vector4(0.0f,0.25f,0.00f,1.0f);
        var degree = matrixType == MatrixType.一行两列? 90:-90;
        transform.RotateAround(m_worldpivot,Vector3.forward,degree);
        女主.Rotate(Vector3.forward,-degree);
        Vector2 m_parentscale = transform.parent.localScale;
        transform.localScale = matrixType == MatrixType.一行两列? 
        new Vector3(m_scale.x/m_parentscale.y,m_scale.y/m_parentscale.x):
        new Vector3(m_scale.x/m_parentscale.x,m_scale.y/m_parentscale.y);
        scaleFactor = m_localScale/transform.localScale;
        女主.localScale *=scaleFactor;*/
    }
    Vector3 transpose(Vector3 input)
    {
        return new Vector3(-input.y, input.x, input.z);
    }
    Vector3 detranspose(Vector3 input)
    {
        return new Vector3(input.y, -input.x, input.z);
    }
    private void 转置()
    {
        if (matrixType == MatrixType.两行一列)
        {
            UpdateMatrixtrans();
            transform.position += new Vector3(10.0f, 10.0f) / 2;
            foreach (GameObject element in elements)
            {
                ElementController elemController = element.GetComponent<ElementController>();
                elemController.transform.localScale *= scaleFactor;
                elemController.transform.localPosition = transpose(elemController.transform.localPosition);
                if (elemController.elementType == "1,0")
                {
                    //Vector3 pos = elemController.gameObject.transform.position;
                    //elemController.transform.localPosition += new Vector3( 0.5f,1.0f );
                    elemController.elementType = "0,1";
                    matrixType = MatrixType.一行两列;
                }
            }

        }
        else if (matrixType == MatrixType.一行两列)
        {
            UpdateMatrixtrans();
            transform.position -= new Vector3(10.0f, 10.0f) / 2;
            foreach (GameObject element in elements)
            {
                ElementController elemController = element.GetComponent<ElementController>();
                elemController.transform.localScale *= scaleFactor;
                elemController.transform.localPosition = detranspose(elemController.transform.localPosition);
                if (elemController.elementType == "0,1")
                {
                    //Vector3 pos = elemController.gameObject.transform.position;
                    //elemController.transform.position -= new Vector3( 10.0f,10.0f );
                    elemController.elementType = "1,0";
                    matrixType = MatrixType.两行一列;
                }
            }
        }

    }

    
    
    //判断贴纸是否进入
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print(collision.name);
        if (collision.GetComponent<stickerController>() != null)
        {
            print(collision.name);
        }
    }

}
