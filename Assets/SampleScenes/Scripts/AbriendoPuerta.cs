using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbriendoPuerta : MonoBehaviour
{
    public Animator laPuerta;
    private void OnTriggerEnter(Collider other){
        laPuerta.Play("TerrenoAbrir");
    }

    private void OnTriggerExit(Collider other){
        laPuerta.Play("TerrenoCerrar");
    }
}
