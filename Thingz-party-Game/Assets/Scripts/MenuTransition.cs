using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
