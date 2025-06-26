using System;
using System.Net;
using UnityEngine;

[Serializable]
public class IPEndPointInfo
{
    #region Field

    public static readonly IPAddress LocalhostAddress = IPAddress.Parse("127.0.0.1");

    [SerializeField] private string address;
    [SerializeField] private int    port;

    #endregion Field

    #region Property

    private IPEndPoint _ipEndPoint;
    private IPEndPoint _ipEndPointLocalhost;

    public string Address
    {
        get => address;
        set
        {
            address     = value;
            _ipEndPoint = new IPEndPoint(IPAddress.Parse(address), port);
        }
    }
    public int Port
    {
        get => port;
        set
        {
            port                 = value;
            _ipEndPoint          = new IPEndPoint(IPAddress.Parse(address), port);
            _ipEndPointLocalhost = new IPEndPoint(LocalhostAddress,         port);
        }
    }

    public IPEndPoint IPEndPoint          => _ipEndPoint          ??= new IPEndPoint(IPAddress.Parse(address), port);
    public IPEndPoint IPEndPointLocalhost => _ipEndPointLocalhost ??= new IPEndPoint(LocalhostAddress,         port);

    public string HttpUrl  => $"http://{ Address }:{ Port }/";
    public string HttpsUrl => $"https://{ Address }:{ Port }/";
    public string WsUrl    => $"ws://{ Address }:{ Port }/";
    public string WssUrl   => $"wss://{ Address }:{ Port }/";

    #endregion Property

    #region Constructor

    public IPEndPointInfo() { }

    public IPEndPointInfo(string address, int port)
    {
        this.address = address;
        this.port    = port;
    }

    #endregion Constructor
}