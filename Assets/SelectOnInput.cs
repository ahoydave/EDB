using UnityEngine;
using System.Collections;
using System.IO.Ports;


public class SelectOnInput : MonoBehaviour {

	public GameObject PlayerObject;

    public float MaxSelectSpeed = 0.5f;
    public int OnValue = 0;

    private TwineTextPlayer TwinePlayer;
    SerialPort sp;
    int previousVal = 1;
    float nextTime = 0;

    void Start () {

		TwinePlayer = PlayerObject.GetComponent<TwineTextPlayer> ();
		print (TwinePlayer);

        try
        {
            sp = new SerialPort("COM5", 9600);
            sp.Open();
            sp.ReadTimeout = 100;
        }
        catch (System.Exception e)
        {
            print(e);
        }
    }

	// Update is called once per frame
	void Update () {

        var newTime = Time.time;
        var newVal = int.Parse(sp.ReadLine());
        if (newVal != previousVal && newTime > nextTime)
        {
            previousVal = newVal;
            nextTime = newTime + MaxSelectSpeed;
            if (newVal == OnValue)
            {
                //print("Selection Changed!");
                TwinePlayer.DoChangeSelected();
            }
        }

  //      if (Input.GetKeyDown (KeyCode.DownArrow)) {
		//	TwinePlayer.DoChangeSelected ();
		//}
		//if (Input.GetKeyDown (KeyCode.UpArrow)) {
		//	TwinePlayer.DoSelect ();
		//}
	}

}