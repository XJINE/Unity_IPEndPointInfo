# Unity_IPEndPointInfo

<img src="https://github.com/XJINE/Unity_IPEndPointInfo/blob/main/Screenshot.png" width="100%" height="auto" />

IPEndPoint wrapper to setup from Inspector.

## Importing

You can use Package Manager or import it directly.

```
https://github.com/XJINE/Unity_IPEndPointInfo.git?path=Assets/Packages/IPEndPointInfo
```

## How to Use

Set ``address`` and ``port`` field. And get ``IPEndPoint`` from property.
The source is quite simple.

```csharp
[SerializeField] private string address;
[SerializeField] private int    port;

private IPEndPoint _ipEndPoint;

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
            port        = value;
            _ipEndPoint = new IPEndPoint(IPAddress.Parse(address), port);
        }
    }

public IPEndPoint IPEndPoint => _ipEndPoint ??= new IPEndPoint(IPAddress.Parse(address), port);
```