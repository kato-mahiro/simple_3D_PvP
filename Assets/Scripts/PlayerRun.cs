using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRun : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public float dash_speed;
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
            if(Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D)) { transform.rotation = Quaternion.AngleAxis(45, new Vector3(0,1,0));}
            else if(Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.S)) { transform.rotation = Quaternion.AngleAxis(135, new Vector3(0,1,0));}
            else if(Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A)) { transform.rotation = Quaternion.AngleAxis(225, new Vector3(0,1,0));}
            else if(Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.W)) { transform.rotation = Quaternion.AngleAxis(315, new Vector3(0,1,0));}
            else if(Input.GetKey(KeyCode.W)) { transform.rotation = Quaternion.AngleAxis(0, new Vector3(0,1,0)); }
            else if(Input.GetKey(KeyCode.D)) { transform.rotation = Quaternion.AngleAxis(90, new Vector3(0,1,0)); }
            else if(Input.GetKey(KeyCode.S)) { transform.rotation = Quaternion.AngleAxis(180, new Vector3(0,1,0)); }
            else if(Input.GetKey(KeyCode.A)) { transform.rotation = Quaternion.AngleAxis(270, new Vector3(0,1,0)); }

            if(Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.RightArrow)) { transform.rotation = Quaternion.AngleAxis(45, new Vector3(0,1,0));}
            else if(Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.DownArrow)) { transform.rotation = Quaternion.AngleAxis(135, new Vector3(0,1,0));}
            else if(Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.LeftArrow)) { transform.rotation = Quaternion.AngleAxis(225, new Vector3(0,1,0));}
            else if(Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.UpArrow)) { transform.rotation = Quaternion.AngleAxis(315, new Vector3(0,1,0));}
            else if(Input.GetKey(KeyCode.UpArrow)) { transform.rotation = Quaternion.AngleAxis(0, new Vector3(0,1,0)); }
            else if(Input.GetKey(KeyCode.RightArrow)) { transform.rotation = Quaternion.AngleAxis(90, new Vector3(0,1,0)); }
            else if(Input.GetKey(KeyCode.DownArrow)) { transform.rotation = Quaternion.AngleAxis(180, new Vector3(0,1,0)); }
            else if(Input.GetKey(KeyCode.LeftArrow)) { transform.rotation = Quaternion.AngleAxis(270, new Vector3(0,1,0)); }

            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

            //Rキーを押しているとダッシュ
            if(Input.GetKey(KeyCode.R))
            {
                moveDirection *= dash_speed; 
                anim.SetFloat("running_speed",1.5f);
            }
            else
            {
                moveDirection *= speed;
                anim.SetFloat("running_speed",1.0f);
            }

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
                moveDirection.y += jumpPower; 
                animation_ptn = AnimationPatterns.Jumping;
            }
        }

        moveDirection.y -= gravity;
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
