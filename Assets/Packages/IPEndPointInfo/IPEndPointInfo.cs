using System.Net;

[System.Serializable]
public class IPEndPointInfo
{
    #region Field

    public string address;
    public int    port;

    #endregion Field

    #region Property

    protected IPEndPoint ipEndPoint;

    public IPEndPoint IPEndPoint
    {
        get
        {
            if (this.ipEndPoint == null)
            {
                this.ipEndPoint = new IPEndPoint(IPAddress.Parse(this.address), this.port);
            }

            return this.ipEndPoint;
        }
    }

    #endregion Property

    #region Constructor

    public IPEndPointInfo() { }

    public IPEndPointInfo(string address, int port)
    {
        this.address = address;
        this.port = port;
    }

    #endregion Constructor
}