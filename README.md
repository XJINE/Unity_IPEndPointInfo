# Unity_IPEndPointInfo

<img src="https://github.com/XJINE/Unity_IPEndPointInfo/blob/master/Screenshot.png" width="100%" height="auto" />

IPEndPoint wrapper to setup from Inspector.

## Import to Your Project

You can import this asset from UnityPackage.

- [IPEndPointInfo.unitypackage](https://github.com/XJINE/Unity_IPEndPointInfo/blob/master/IPEndPointInfo.unitypackage)

## How to Use

Set ``address`` and ``port`` field. And get ``IPEndPoint`` from property.
The source is quite simple.

```csharp
public string address;
public int    port;
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

```