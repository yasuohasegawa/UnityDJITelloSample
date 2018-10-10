using UnityEngine;
using System;
using System.Net.Sockets;
using System.Text;

public class Tello : MonoBehaviour {
    private string host = "192.168.10.1";
    private int port = 8889;
    private UdpClient client;

    // Use this for initialization
    void Start () {
        Connect();
        Command("command");
        Debug.Log("command");
    }

    private void Connect()
    {
        try
        {
            client = new UdpClient();
            client.Connect(host, port);
        }
        catch (Exception e)
        {
            Debug.Log("error: " + e);
        }
    }

    private void Command(string mess)
    {
        try
        {
            byte[] cmd = Encoding.UTF8.GetBytes(mess);
            client.Send(cmd, cmd.Length);
        }
        catch (Exception e)
        {
            Debug.Log("error: " + e);
        }
    }

    public void OnBattey()
    {
        Command("Battery?");
        Debug.Log("OnBattey");
    }

    public void OnTakeoff()
    {
        Command("takeoff");
        Debug.Log("OnTakeoff");
    }

    public void OnLand()
    {
        Command("land");
        Debug.Log("OnLand");
    }

    public void OnCw()
    {
        Command("cw 90");
        Debug.Log("OnCw");
    }

    public void OnCcw()
    {
        Command("ccw 90");
        Debug.Log("OnCcw");
    }

    public void OnUp()
    {
        Command("up 20");
        Debug.Log("OnUp");
    }

    public void OnDown()
    {
        Command("down 20");
        Debug.Log("OnDown");
    }

    public void OnLeft()
    {
        Command("left 20");
        Debug.Log("OnLeft");
    }

    public void OnRight()
    {
        Command("right 20");
        Debug.Log("OnRight");
    }

    public void OnForward()
    {
        Command("forward 20");
        Debug.Log("OnFoward");
    }

    public void OnBack()
    {
        Command("back 20");
        Debug.Log("OnBack");
    }

    public void OnFlipL()
    {
        Command("flip l");
        Debug.Log("OnFlipL");
    }

    public void OnFlipR()
    {
        Command("flip r");
        Debug.Log("OnFlipR");
    }

    public void OnFlipF()
    {
        Command("flip f");
        Debug.Log("OnFlipF");
    }

    public void OnFlipB()
    {
        Command("flip b");
        Debug.Log("OnFlipB");
    }

    void OnApplicationQuit()
    {
        client.Close();
        client = null;
    }
}
