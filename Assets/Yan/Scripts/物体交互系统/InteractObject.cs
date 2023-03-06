using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 作者：闫辰祥
/// </summary>
public class InteractObject : MonoBehaviour
{

    public enum ObjectType
    {
        门,
        手账本,
        计划表
    }

    public ObjectType 物体类型;


    public void Interact()
    {
        switch(物体类型)
        {
            case ObjectType.门:
                print("门");
                break;
            case ObjectType.手账本:
                break;
            case ObjectType.计划表:
                print("修改游戏");
                break;
        }
    }

    void Start()
    {
        
    }


    void Update()
    {
        
    }
}
