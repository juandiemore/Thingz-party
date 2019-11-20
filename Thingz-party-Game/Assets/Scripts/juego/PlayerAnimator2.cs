using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator2 : MonoBehaviour
{

    private Animator anim;

    float dirX, moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 5f;
        anim = GetComponent<Animator>();
        dirX = this.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {

  if (Input.GetKeyDown(KeyCode.LeftArrow)){
      Vector2 position = this.transform.position;
      position.x  =0.005f* moveSpeed;
      //transfrorm.position = position;

  }

    dirX = transform.position.x;
    transform.position = new Vector2 (transform.position.x + dirX, transform.position.y);

    if(dirX != 0){
        anim.SetBool("IsWalking",true);
    }else{
        anim.SetBool("IsWalking",false);
    }

        
        
    }

    
}
