using UnityEngine;
//using Newtonsoft.Json;

public class Socket : MonoBehaviour
{
    //variables
    private TCPConnection myTCP;
    public string message;

    void Awake()
    {
        //add a copy of TCPConnection to this game object
        myTCP = gameObject.AddComponent<TCPConnection>();
    }

    void Start()
    {

    }

    void Update()
    {
		
		SendToServer ("stuff: {" + UserControls.downfist+ ", " + UserControls.upfist + "}");
    }

    void OnGUI()
    {
        //if connection has not been made, display button to connect
        if (myTCP.socketReady == false)
        {
			if (GUILayout.Button("Connect", GUILayout.Height(250), GUILayout.Width(250)))
            {
                //try to connect
                Debug.Log("Attempting to connect..");
                myTCP.setupSocket();
            }
        }

        //once connection has been made, display editable text field with a button to send that string to the server (see function below)
        if (myTCP.socketReady == true)
        {
            message = GUILayout.TextField(message);
            if (GUILayout.Button("Write to server", GUILayout.Height(30)))
            {
                //SendToServer(message);
				SendToServer(message);
            }
        }
    }

    //send message to the server
    public void SendToServer(string str)
    {
        myTCP.writeSocket(str);
        Debug.Log("[CLIENT] -> " + str);
        //Debug.Log("After parsing: " + parseJson(str));
    }
		
}