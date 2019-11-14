using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{

    private Animator anim;

    float dirX, moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 5f;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    dirX = Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime;

    transform.position = new Vector2 (transform.position.x + dirX, transform.position.y);

    if(dirX != 0){
        anim.SetBool("IsWalking",true);
    }else{
        anim.SetBool("IsWalking",false);
    }

        
        
    }

    
}
