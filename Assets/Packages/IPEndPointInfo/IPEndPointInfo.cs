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
                this.ipEndPoint = new IPEndPoint(FindIPAddress(this.address), this.port);
            }

            return this.ipEndPoint;
        }
    }

    #endregion Property

    #region Method

    public static IPAddress FindIPAddress(string hostname)
    {
        IPAddress[] addresses = Dns.GetHostAddresses(hostname);
        IPAddress   address   = IPAddress.None;

        for (var i = 0; i < addresses.Length; i++)
        {
            if (addresses[i].AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
            {
                address = addresses[i];
                break;
            }
        }

        return address;
    }

    #endregion Method
}