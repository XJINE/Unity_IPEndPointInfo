using System;
using System.Net;
using UnityEngine;

[Serializable]
public class IPEndPointInfo
{
    #region Field

    public static readonly IPAddress LocalIPAddress = IPAddress.Parse("127.0.0.1");

    [SerializeField] private string address;
    [SerializeField] private int    port;

    #endregion Field

    #region Property

    private IPEndPoint _ipEndPoint;
    private IPEndPoint _ipEndPointLocal;

    public string Address
    {
        get => address;
        set
        {
            address          = value;
            _ipEndPoint      = new IPEndPoint(IPAddress.Parse(address), port);
            _ipEndPointLocal = new IPEndPoint(LocalIPAddress,           port);
        }
    }
    public int Port
    {
        get => port;
        set
        {
            port             = value;
            _ipEndPoint      = new IPEndPoint(IPAddress.Parse(address), port);
            _ipEndPointLocal = new IPEndPoint(LocalIPAddress,           port);
        }
    }

    public IPEndPoint IPEndPoint      => _ipEndPoint      ??= new IPEndPoint(IPAddress.Parse(address), port);
    public IPEndPoint IPEndPointLocal => _ipEndPointLocal ??= new IPEndPoint(LocalIPAddress,           port);

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