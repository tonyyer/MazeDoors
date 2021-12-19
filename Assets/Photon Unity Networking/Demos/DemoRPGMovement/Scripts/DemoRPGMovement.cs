using UnityEngine;
using System.Collections;

public class DemoRPGMovement : MonoBehaviour 
{
    public RPGCamera Camera;
	public GameObject BotonPersonaje_01;
	public GameObject BotonPersonaje_02;

    void OnJoinedRoom()
    {
        CreatePlayerObject();
    }

    void CreatePlayerObject()
    {
        
    }


	public void CreatePlayerUno()
	{
		Vector3 position = new Vector3( 8.67f, 6.12f, 77.8f );
		 Quaternion p = new Quaternion();
        p[1] = 45.0f; 
		GameObject newPlayerObject = PhotonNetwork.Instantiate( "JugadorUno", position, p, 0 );
		Camera.Target = newPlayerObject.transform;
		Destroy(BotonPersonaje_01, 1);
		Destroy(BotonPersonaje_02, 1);


	}

	public void CreatePlayerDos()
	{
		Vector3 position = new Vector3( 8.70f, 7.6f, 31.5f );
		GameObject newPlayerObject = PhotonNetwork.Instantiate( "JugadorUno_b", position, Quaternion.identity, 0 );
		// GameObject newPlayerObject = PhotonNetwork.Instantiate( "JugadorDos", position, Quaternion.identity, 0 );
		Camera.Target = newPlayerObject.transform;
		Destroy(BotonPersonaje_01, 1);
		Destroy(BotonPersonaje_02, 1);


	}



}
