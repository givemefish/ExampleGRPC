// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: user.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace ExampleGRPC.Proto {
  public static partial class LoginService
  {
    static readonly string __ServiceName = "ExampleGRPC.Proto.LoginService";

    static readonly grpc::Marshaller<global::ExampleGRPC.Proto.LoginRequest> __Marshaller_ExampleGRPC_Proto_LoginRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::ExampleGRPC.Proto.LoginRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::ExampleGRPC.Proto.LoginResponse> __Marshaller_ExampleGRPC_Proto_LoginResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::ExampleGRPC.Proto.LoginResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::ExampleGRPC.Proto.LoginRequest, global::ExampleGRPC.Proto.LoginResponse> __Method_Login = new grpc::Method<global::ExampleGRPC.Proto.LoginRequest, global::ExampleGRPC.Proto.LoginResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Login",
        __Marshaller_ExampleGRPC_Proto_LoginRequest,
        __Marshaller_ExampleGRPC_Proto_LoginResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::ExampleGRPC.Proto.UserReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of LoginService</summary>
    public abstract partial class LoginServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::ExampleGRPC.Proto.LoginResponse> Login(global::ExampleGRPC.Proto.LoginRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for LoginService</summary>
    public partial class LoginServiceClient : grpc::ClientBase<LoginServiceClient>
    {
      /// <summary>Creates a new client for LoginService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public LoginServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for LoginService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public LoginServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected LoginServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected LoginServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::ExampleGRPC.Proto.LoginResponse Login(global::ExampleGRPC.Proto.LoginRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Login(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::ExampleGRPC.Proto.LoginResponse Login(global::ExampleGRPC.Proto.LoginRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Login, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::ExampleGRPC.Proto.LoginResponse> LoginAsync(global::ExampleGRPC.Proto.LoginRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return LoginAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::ExampleGRPC.Proto.LoginResponse> LoginAsync(global::ExampleGRPC.Proto.LoginRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Login, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override LoginServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new LoginServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(LoginServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Login, serviceImpl.Login).Build();
    }

    /// <summary>Register service method implementations with a service binder. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, LoginServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_Login, serviceImpl.Login);
    }

  }
}
#endregion
