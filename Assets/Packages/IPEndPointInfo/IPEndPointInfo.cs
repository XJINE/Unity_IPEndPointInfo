using System.Net;

[System.Serializable]
public class IPEndPointInfo
{
    #region Field

    public string address;
    public int    port;

    #endregion Field

    #region Property

    private IPEndPoint _ipEndPoint;

    public IPEndPoint IPEndPoint => _ipEndPoint ??= new IPEndPoint(IPAddress.Parse(address), port);

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