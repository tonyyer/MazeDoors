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
		Vector3 position = new Vector3( 56.7f, 7.9f, 77.8f );
		GameObject newPlayerObject = PhotonNetwork.Instantiate( "JugadorUno", position, Quaternion.identity, 0 );
		Camera.Target = newPlayerObject.transform;
		Destroy(BotonPersonaje_01, 1);
		Destroy(BotonPersonaje_02, 1);


	}

	public void CreatePlayerDos()
	{
		Vector3 position = new Vector3( 33.5f, 3.74f, 20.5f );
		GameObject newPlayerObject = PhotonNetwork.Instantiate( "JugadorUno_b", position, Quaternion.identity, 0 );
		// GameObject newPlayerObject = PhotonNetwork.Instantiate( "JugadorDos", position, Quaternion.identity, 0 );
		Camera.Target = newPlayerObject.transform;
		Destroy(BotonPersonaje_01, 1);
		Destroy(BotonPersonaje_02, 1);


	}



}
