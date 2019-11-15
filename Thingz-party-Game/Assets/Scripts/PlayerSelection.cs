using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerSelection : MonoBehaviour
{

    static public int seleccion = 1;
    private Animator anim;
    private int estado=1;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
    if(Input.GetKeyDown(KeyCode.S) && estado<3){
        estado+=1;
        
    }
        if(Input.GetKeyDown(KeyCode.W) && estado>1){
        estado-=1;

    }

    anim.SetInteger("pj",estado);
    seleccion = estado;

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
