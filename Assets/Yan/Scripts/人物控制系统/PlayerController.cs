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
        //var x = Input.GetAxis("Horizontal");
        //var y = Input.GetAxis("Vertical");


        //transform.position += speed * Time.deltaTime * new Vector3(x, y,0);

        if (Input.GetKeyDown(KeyCode.E))
        {
            //var position = new Vector2(transform.position.x, transform.position.y);
            //Collider2D[] collider2D = Physics2D.OverlapCircleAll(position,1.0f,1<<LayerMask.NameToLayer("交互物体"));
            if (interactObj != null)
            {
                interactObj.GetComponent<InteractObject>().Interact();
            }

            //print(collider2D[0]);
        }



    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print(collision.name);
        interactObj = collision.gameObject;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        interactObj = null;
    }
}
