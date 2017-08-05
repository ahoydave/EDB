using UnityEngine;
using System.Collections;
using System.IO.Ports;


public class SelectOnInput : MonoBehaviour {

	public GameObject PlayerObject;

	private TwineTextPlayer TwinePlayer;

	// Use this for initialization
	SerialPort sp ;//= new SerialPort("COM13",9600);

	void Start () {

		TwinePlayer = PlayerObject.GetComponent<TwineTextPlayer> ();
		print (TwinePlayer);
//		var ports = SerialPort.GetPortNames ();
//		foreach (var s in ports)
//			Debug.Log (s);
//		
//		Debug.Log ("Hi Guys");
//		int i = 0;
//		for (; i < 1; i++)
//		{        
//			try {
//				//print ("HELLO");
//				print ("/dev/ttyUS" + i.ToString("X"));
//				sp = new SerialPort("/dev/tty.Bluetooth-Incoming-Port" ,9600);
//				sp.Open ();
//				sp.ReadTimeout = 1;
//				print ("Made it");
//				break;
//
//			} catch (System.Exception e)  {
//				print (e);
//			}
//		}
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			TwinePlayer.DoChangeSelected ();
		}
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			TwinePlayer.DoSelect ();
		}
			
//		try {
//			print (sp.ReadLine());
//		} catch (System.Exception e)  {
//			print ("IOException source: {0}");  
//		}
	}

}