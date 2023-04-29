using Proxy;

var virtualProxy = new VirtualProxy();
Console.WriteLine(virtualProxy.Present());
Thread.Sleep(11000);
Console.WriteLine(virtualProxy.Present());