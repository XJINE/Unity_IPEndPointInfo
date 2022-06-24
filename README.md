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
public string address;
public int    port;

private IPEndPoint _ipEndPoint;
public IPEndPoint IPEndPoint => _ipEndPoint ??= new IPEndPoint(IPAddress.Parse(address), port);
```