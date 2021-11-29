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
		Vector3 position = new Vector3( 33.5f, 1.5f, 20.5f );
		GameObject newPlayerObject = PhotonNetwork.Instantiate( "JugadorUno", position, Quaternion.identity, 0 );
		Camera.Target = newPlayerObject.transform;
		Destroy(BotonPersonaje_01, 1);
		Destroy(BotonPersonaje_02, 1);


	}

	public void CreatePlayerDos()
	{
		Vector3 position = new Vector3( 33.5f, 1.5f, 20.5f );
		GameObject newPlayerObject = PhotonNetwork.Instantiate( "JugadorDos", position, Quaternion.identity, 0 );
		Camera.Target = newPlayerObject.transform;
		Destroy(BotonPersonaje_01, 1);
		Destroy(BotonPersonaje_02, 1);


	}



}
