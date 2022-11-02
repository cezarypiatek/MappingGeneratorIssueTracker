#region snippet2
using System.Threading.Tasks;
using Grpc.Net.Client;
using GrpcGreeterClient;

#region snippet
// The port number must match the port of the gRPC server.
using var channel = GrpcChannel.ForAddress("https://localhost:7042");
var client = new Greeter.GreeterClient(channel);
var reply = await client.SayHelloAsync(
                  new HelloRequest { Name = "GreeterClient" });
Console.WriteLine("Greeting: " + reply.Message);
Console.WriteLine("Press any key to exit...");
Console.ReadKey();
#endregion
#endregion

public class RequestDto
{
    public string Name { get; set; }
    public UserDto User { get; set; }
}

public class UserDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

