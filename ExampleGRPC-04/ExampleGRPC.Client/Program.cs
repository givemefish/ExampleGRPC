using System;
using ExampleGRPC.Proto;
using Grpc.Core;

namespace ExampleGRPC.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var channel = new Channel("localhost", 443, ChannelCredentials.Insecure);

                var client = new LoginService.LoginServiceClient(channel);
                var reply = client.Login(new LoginRequest()
                {
                    Id = "jimchen",
                    Password = "password"
                });

                Console.WriteLine(reply.Success ? "SUCC" : reply.Message);
            }
            catch (RpcException e)
            {
                Console.WriteLine($"[{e.Status.StatusCode}] {e.Status.Detail}");
            }
            
            Console.ReadKey();
        }
    }


}
