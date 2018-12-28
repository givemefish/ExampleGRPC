using System;
using System.Threading.Tasks;
using ExampleGRPC.Proto;
using Grpc.Core;

namespace ExampleGRPC.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            var server = new Grpc.Core.Server()
            {
                Services = { LoginService.BindService(new LoginServiceImpl())},
                Ports = { new ServerPort("localhost", 443, ServerCredentials.Insecure) }
            };
            server.Start();

            Console.ReadKey();
            server.ShutdownAsync().Wait();
        }
    }

    class LoginServiceImpl : Proto.LoginService.LoginServiceBase
    {
        public override Task<LoginResponse> Login(LoginRequest request, ServerCallContext context)
        {
            return Task.FromResult(new LoginResponse(new LoginResponse()
            {
                Success = true,
                Message = string.Empty
            }));
        }
    }
}
