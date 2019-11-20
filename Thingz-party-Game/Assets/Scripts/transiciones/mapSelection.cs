using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mapSelection : MonoBehaviour
{

    private Animator anim;
    public static int estado;
    AudioSource audio;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
    if(Input.GetKeyDown(KeyCode.D) && estado<2){
        estado+=1;
     
    }
        if(Input.GetKeyDown(KeyCode.A) && estado>0){
        estado-=1;
     
    }

    anim.SetInteger("estado",estado);


     if(Input.GetKeyDown(KeyCode.Return)){

        audio.Play();
        anim.SetBool("selected",true);

        }

    /*

    if(estado == 0){
         audio.clip = desierto;
       
    }else 
      if(estado == 1){
         audio.clip = selva;
    
    }else if(estado == 2){
         audio.clip = barrio;
      
    }


  switch(estado){
      case 0: 
            audio.clip = desierto;
            audio.Play();
            break;
       case 1:
        audio.clip = selva;
            audio.Play();
            break;
        case 2:
         audio.clip = barrio;
            audio.Play();
            break;
  }
  */
}

    public void back(){

   SceneManager.LoadScene("menu");
    }
}
