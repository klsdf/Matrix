using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Spine.Unity;
public class Playerscript : MonoBehaviour
{
    Animator animator;
    float walkspeed;
    bool faceright=true;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        walkspeed = Input.GetAxis("Horizontal");
        walkspeed *= Input.GetKey(KeyCode.LeftShift)?2:1; 
        animator.SetBool("move",Mathf.Abs(walkspeed)>0.0f);
        animator.SetFloat("speed",Mathf.Abs(walkspeed));
        transform.Translate(Vector3.right*walkspeed*Time.deltaTime*3.0f);
    }

    void FixedUpdate() {

        if(walkspeed>0.0f&&!faceright){
            Flip();
        }else if(walkspeed<0.0f&&faceright){
            Flip();
        }
    }
    void Flip(){
        faceright =!faceright;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }


}
