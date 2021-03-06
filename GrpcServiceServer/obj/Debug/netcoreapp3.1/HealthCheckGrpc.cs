// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HealthCheck.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Grpc.Health.V1 {
  public static partial class Health
  {
    static readonly string __ServiceName = "grpc.health.v1.Health";

    static readonly grpc::Marshaller<global::Grpc.Health.V1.HealthCheckRequest> __Marshaller_grpc_health_v1_HealthCheckRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Grpc.Health.V1.HealthCheckRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Grpc.Health.V1.HealthCheckResponse> __Marshaller_grpc_health_v1_HealthCheckResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Grpc.Health.V1.HealthCheckResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Grpc.Health.V1.HealthCheckRequest, global::Grpc.Health.V1.HealthCheckResponse> __Method_Check = new grpc::Method<global::Grpc.Health.V1.HealthCheckRequest, global::Grpc.Health.V1.HealthCheckResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Check",
        __Marshaller_grpc_health_v1_HealthCheckRequest,
        __Marshaller_grpc_health_v1_HealthCheckResponse);

    static readonly grpc::Method<global::Grpc.Health.V1.HealthCheckRequest, global::Grpc.Health.V1.HealthCheckResponse> __Method_Watch = new grpc::Method<global::Grpc.Health.V1.HealthCheckRequest, global::Grpc.Health.V1.HealthCheckResponse>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "Watch",
        __Marshaller_grpc_health_v1_HealthCheckRequest,
        __Marshaller_grpc_health_v1_HealthCheckResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Grpc.Health.V1.HealthCheckReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for Health</summary>
    public partial class HealthClient : grpc::ClientBase<HealthClient>
    {
      /// <summary>Creates a new client for Health</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public HealthClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Health that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public HealthClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected HealthClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected HealthClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Grpc.Health.V1.HealthCheckResponse Check(global::Grpc.Health.V1.HealthCheckRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Check(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Grpc.Health.V1.HealthCheckResponse Check(global::Grpc.Health.V1.HealthCheckRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Check, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Grpc.Health.V1.HealthCheckResponse> CheckAsync(global::Grpc.Health.V1.HealthCheckRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CheckAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Grpc.Health.V1.HealthCheckResponse> CheckAsync(global::Grpc.Health.V1.HealthCheckRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Check, null, options, request);
      }
      public virtual grpc::AsyncServerStreamingCall<global::Grpc.Health.V1.HealthCheckResponse> Watch(global::Grpc.Health.V1.HealthCheckRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Watch(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncServerStreamingCall<global::Grpc.Health.V1.HealthCheckResponse> Watch(global::Grpc.Health.V1.HealthCheckRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_Watch, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override HealthClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new HealthClient(configuration);
      }
    }

  }
}
#endregion
