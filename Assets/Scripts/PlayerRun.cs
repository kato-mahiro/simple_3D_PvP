using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRun : MonoBehaviour
{
    GameObject refObj;
    // Start is called before the first frame update
    public float speed;
    public Animator anim;
    public float gravity;
    public float jumpPower;

    private Vector3 moveDirection;
    private CharacterController controller;
    enum AnimationPatterns
    {
        Idling,
        Running,
        Jumping,
    }
    private AnimationPatterns animation_ptn; 

    void Start()
    {
        anim = GetComponent<Animator>(); //これで、Unityちゃんに関連づけられているAnimatorオブジェクトの参照が取得できる
        controller = GetComponent<CharacterController>();
        animation_ptn = AnimationPatterns.Idling;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(transform.position);
        if (controller.isGrounded) 
        {
            if(Input.GetKey(KeyCode.RightArrow)) { transform.rotation = Quaternion.AngleAxis(90, new Vector3(0,1,0)); }
            else if(Input.GetKey(KeyCode.LeftArrow)) { transform.rotation = Quaternion.AngleAxis(270, new Vector3(0,1,0)); }

            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection *= speed;
            if(moveDirection.magnitude > 1.5f)
            {
                animation_ptn = AnimationPatterns.Running;
            }
            else
            {
                animation_ptn = AnimationPatterns.Idling;
            }
            if (Input.GetButtonDown("Jump")) 
            {
                refObj = GameObject.Find("BarCtrl");
                UIDirector hoge = refObj.GetComponent<UIDirector>();
                if (hoge.sp > 0.3)
                {
                    animation_ptn = AnimationPatterns.Jumping;
                    hoge.minus();
                    moveDirection.y += jumpPower;
                }
            }

        }

        moveDirection.y -= gravity;
        moveDirection.z = 0;
        controller.Move(moveDirection * Time.deltaTime);
        //Debug.Log(moveDirection.magnitude);

        switch((int)animation_ptn){
            case 0:
            anim.SetBool("is_idling",true);
            anim.SetBool("is_running",false);
            anim.SetBool("is_jumping",false);
            break;

            case 1:
            anim.SetBool("is_idling",false);
            anim.SetBool("is_running",true);
            anim.SetBool("is_jumping",false);
            break;

            case 2:
            anim.SetBool("is_idling",false);
            anim.SetBool("is_running",false);
            anim.SetBool("is_jumping",true);
            break;
        }
    }
}
