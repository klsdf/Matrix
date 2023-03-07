using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 作者：闫辰祥
/// </summary>
public class PlayerController : MonoBehaviour
{
    //private float speed = 3.0f;
    public GameObject interactObj;//进入范围的交互物体

    void Start()
    {
        
    }


    void Update()
    {


        if (Input.GetKeyDown(KeyCode.E))
        {
            if (interactObj != null)
            {
                interactObj.GetComponent<IInteractObject>().Interact();
            }


        }



    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<IInteractObject>() !=null)
        {
            interactObj = collision.gameObject;
            GameManager.Instance.ShowEmoji();
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        GameManager.Instance.NotShowEmoji();
        interactObj = null;
    }
}
