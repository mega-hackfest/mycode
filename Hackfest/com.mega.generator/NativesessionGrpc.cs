// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: nativesession.proto
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using grpc = global::Grpc.Core;

namespace Mega {
  /// <summary>
  /// The greeting service definition.
  /// </summary>
  public static partial class NativeSession
  {
    static readonly string __ServiceName = "mega.NativeSession";

    static readonly grpc::Marshaller<global::Mega.NewSessionRequest> __Marshaller_NewSessionRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Mega.NewSessionRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Mega.NewSessionReply> __Marshaller_NewSessionReply = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Mega.NewSessionReply.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Mega.GenerateRequest> __Marshaller_GenerateRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Mega.GenerateRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Mega.GenerateReply> __Marshaller_GenerateReply = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Mega.GenerateReply.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Mega.CloseSessionRequest> __Marshaller_CloseSessionRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Mega.CloseSessionRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Mega.CloseSessionReply> __Marshaller_CloseSessionReply = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Mega.CloseSessionReply.Parser.ParseFrom);

    static readonly grpc::Method<global::Mega.NewSessionRequest, global::Mega.NewSessionReply> __Method_OpenSession = new grpc::Method<global::Mega.NewSessionRequest, global::Mega.NewSessionReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "OpenSession",
        __Marshaller_NewSessionRequest,
        __Marshaller_NewSessionReply);

    static readonly grpc::Method<global::Mega.GenerateRequest, global::Mega.GenerateReply> __Method_Generate = new grpc::Method<global::Mega.GenerateRequest, global::Mega.GenerateReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Generate",
        __Marshaller_GenerateRequest,
        __Marshaller_GenerateReply);

    static readonly grpc::Method<global::Mega.CloseSessionRequest, global::Mega.CloseSessionReply> __Method_CloseSession = new grpc::Method<global::Mega.CloseSessionRequest, global::Mega.CloseSessionReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CloseSession",
        __Marshaller_CloseSessionRequest,
        __Marshaller_CloseSessionReply);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Mega.NativesessionReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of NativeSession</summary>
    public abstract partial class NativeSessionBase
    {
      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Mega.NewSessionReply> OpenSession(global::Mega.NewSessionRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Mega.GenerateReply> Generate(global::Mega.GenerateRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Mega.CloseSessionReply> CloseSession(global::Mega.CloseSessionRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for NativeSession</summary>
    public partial class NativeSessionClient : grpc::ClientBase<NativeSessionClient>
    {
      /// <summary>Creates a new client for NativeSession</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public NativeSessionClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for NativeSession that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public NativeSessionClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected NativeSessionClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected NativeSessionClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Mega.NewSessionReply OpenSession(global::Mega.NewSessionRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return OpenSession(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Mega.NewSessionReply OpenSession(global::Mega.NewSessionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_OpenSession, null, options, request);
      }
      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Mega.NewSessionReply> OpenSessionAsync(global::Mega.NewSessionRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return OpenSessionAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Mega.NewSessionReply> OpenSessionAsync(global::Mega.NewSessionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_OpenSession, null, options, request);
      }
      public virtual global::Mega.GenerateReply Generate(global::Mega.GenerateRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Generate(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Mega.GenerateReply Generate(global::Mega.GenerateRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Generate, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Mega.GenerateReply> GenerateAsync(global::Mega.GenerateRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GenerateAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Mega.GenerateReply> GenerateAsync(global::Mega.GenerateRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Generate, null, options, request);
      }
      public virtual global::Mega.CloseSessionReply CloseSession(global::Mega.CloseSessionRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return CloseSession(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Mega.CloseSessionReply CloseSession(global::Mega.CloseSessionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CloseSession, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Mega.CloseSessionReply> CloseSessionAsync(global::Mega.CloseSessionRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return CloseSessionAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Mega.CloseSessionReply> CloseSessionAsync(global::Mega.CloseSessionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CloseSession, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override NativeSessionClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new NativeSessionClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(NativeSessionBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_OpenSession, serviceImpl.OpenSession)
          .AddMethod(__Method_Generate, serviceImpl.Generate)
          .AddMethod(__Method_CloseSession, serviceImpl.CloseSession).Build();
    }

  }
}
#endregion