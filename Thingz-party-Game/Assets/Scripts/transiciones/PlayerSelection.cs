using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerSelection : MonoBehaviour
{

    static public int seleccion = 1;
    private Animator anim;
    AudioSource audio;
    private int estado=1;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        audio = GetComponent<AudioSource>();
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

        audio.Play();
        anim.SetBool("selected",true);

        }
    }

    void Seleccionado(){
        if(this.tag == "player1"){

        SceneManager.LoadScene("seleccionPlayer2");
        }else if(this.tag == "player2"){

        SceneManager.LoadScene("menu");
        }
    }
}
