using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuTransition : MonoBehaviour
{

    private Animator animMenu;
    private int estado;
    // Start is called before the first frame update
    void Start()
    {
        animMenu = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
    if(Input.GetKeyDown(KeyCode.W) && estado<=3){
        estado+=1;
        
    }
        if(Input.GetKeyDown(KeyCode.S) && estado>=0){
        estado-=1;

    }

    animMenu.SetInteger("state",estado);

    if(Input.GetKeyDown(KeyCode.Return)){
        animMenu.SetBool("selected",true);
    }
    }
}
