using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbriendoPuerta : MonoBehaviour
{
    public Animator laPuerta;
    private void OnTriggerEnter(Collider other){
        laPuerta.Play("TerrenoAbrir");
        laPuerta.Play("AguaAbrir");
        laPuerta.Play("TerrenoAbrir2");
        laPuerta.Play("AguaAbrir2");
    }

    private void OnTriggerExit(Collider other){
        laPuerta.Play("TerrenoCerrar");
        laPuerta.Play("AguaCerrar");
        laPuerta.Play("TerrenoCerrar2");
        laPuerta.Play("AguaCerrar2");
    }
}
