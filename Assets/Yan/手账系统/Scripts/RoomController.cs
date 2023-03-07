using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 作者：闫辰祥
/// </summary>
public class RoomController : MonoBehaviour
{
    public bool isActive=false;//房间是否被激活 

    private float speed = 3.0f;

    void Start()
    {

    }


    void Update()
    {
        if (isActive == true)
        {
            var x = Input.GetAxis("Horizontal");
            var y = Input.GetAxis("Vertical");


            transform.position += speed * Time.deltaTime * new Vector3(-x, -y, 0);
        }
    }
}
