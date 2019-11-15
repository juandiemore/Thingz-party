using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mapSelection : MonoBehaviour
{

    private Animator anim;
    private int estado;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
    if(Input.GetKeyDown(KeyCode.D) && estado<=2){
        estado+=1;
        
    }
        if(Input.GetKeyDown(KeyCode.A) && estado>0){
        estado-=1;

    }

    anim.SetInteger("estado",estado);

    if(Input.GetKeyDown(KeyCode.Return)){
        anim.SetBool("selected",true);
        }
    }

    void Seleccionado(){
        if(estado == 0){
        SceneManager.LoadScene("juego");
        }else if(estado == 1){
            SceneManager.LoadScene("instrucciones");
        }else if(estado == 2){
            SceneManager.LoadScene("mapa");
        }else if(estado == 3){
            SceneManager.LoadScene("pjs");
        }
    }
}
