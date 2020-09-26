using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SocketIO;
public class TestSocket : MonoBehaviour
{

    public SocketIOComponent socket;
    // Start is called before the first frame update
    void Start()
    {
        socket.Connect();
        socket.On("connection", OnConnected);

        
    }

    private void OnConnected(SocketIOEvent evt)
    {
        Debug.Log("Server Connected: " + evt);
        socket.Emit("auth");
    }
    
}
