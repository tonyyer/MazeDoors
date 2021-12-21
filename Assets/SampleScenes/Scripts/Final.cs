using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Final : MonoBehaviour
{
    public GameObject Win;
    private void OnTriggerEnter(Collider other){
        Win.gameObject.SetActive(true);
        Debug.Log("Ganastes");
    }

}
