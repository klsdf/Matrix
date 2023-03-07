using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace Yan
{
    public class Door : MonoBehaviour, IInteractObject
    {
        public enum DoorType
        {
            上,
            下,
            左,
            右
        }


        public DoorType 门的位置;


        public void Interact()
        {
            RaycastHit2D[] colliders = null;
            switch (门的位置)
            {
                case DoorType.上:
                    colliders = Physics2D.RaycastAll(transform.position, Vector2.up, 4f, 1 << LayerMask.NameToLayer("交互物体"));
                    break;
                case DoorType.下:
                    colliders = Physics2D.RaycastAll(transform.position, Vector2.down, 4f, 1 << LayerMask.NameToLayer("交互物体"));
                    break;
                case DoorType.左:
                    colliders = Physics2D.RaycastAll(transform.position, Vector2.left, 4f, 1 << LayerMask.NameToLayer("交互物体"));
                    break;
                case DoorType.右:
                    colliders = Physics2D.RaycastAll(transform.position, Vector2.right, 4f, 1 << LayerMask.NameToLayer("交互物体"));
                    break;
            }


            //Collider2D[] colliders =  Physics2D.OverlapCircleAll(transform.position,4.0f,1<<LayerMask.NameToLayer("交互物体"));
            foreach (RaycastHit2D coll in colliders)
            {
                if (coll.transform.gameObject.GetComponent<Door>() && coll.transform.gameObject != gameObject)
                {
                    print("找到下一个门" + coll.transform.gameObject.name);
                    MoveTo(coll.transform.gameObject);
                }
                else
                {
                    DialogSystem.Instance.ChangeMessage("我发现了一个门，但是打不开。");
                }


            }
            //print("ok");
        }

        void Start()
        {

        }


        //从门移动到另一个元素,转过去的时候，新房间激活
        public void MoveTo(GameObject target)
        {
            target.transform.parent.GetComponent<RoomController>().isActive = true;
            transform.parent.GetComponent<RoomController>().isActive = false;


            GameManager.Instance.女主.transform.parent = target.transform.parent.parent;
            //print("父亲所说"+target.transform.parent.parent);
            if (门的位置 == DoorType.右)
            {
                GameManager.Instance.女主.transform.position = target.transform.position + Vector3.right;
            }
            else if (门的位置 == DoorType.左)
            {
                GameManager.Instance.女主.transform.position = target.transform.position + Vector3.left;
            } else if (门的位置 == DoorType.上)
            {
                GameManager.Instance.女主.transform.position = target.transform.position + Vector3.up;
            }
            else if (门的位置 == DoorType.下)
            {
                GameManager.Instance.女主.transform.position = target.transform.position + Vector3.down;
            }

        }


        void Update()
        {

        }
    }
}

