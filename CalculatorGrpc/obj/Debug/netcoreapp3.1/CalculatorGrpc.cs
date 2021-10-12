// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/calculator.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace CalculatorGrpcService {
  /// <summary>
  /// The greeting service definition.
  /// </summary>
  public static partial class Calculator
  {
    static readonly string __ServiceName = "calculator.Calculator";

    static readonly grpc::Marshaller<global::CalculatorGrpcService.HelloRequest> __Marshaller_calculator_HelloRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::CalculatorGrpcService.HelloRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::CalculatorGrpcService.HelloReply> __Marshaller_calculator_HelloReply = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::CalculatorGrpcService.HelloReply.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::CalculatorGrpcService.Numbers> __Marshaller_calculator_Numbers = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::CalculatorGrpcService.Numbers.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::CalculatorGrpcService.Response> __Marshaller_calculator_Response = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::CalculatorGrpcService.Response.Parser.ParseFrom);

    static readonly grpc::Method<global::CalculatorGrpcService.HelloRequest, global::CalculatorGrpcService.HelloReply> __Method_SayHello = new grpc::Method<global::CalculatorGrpcService.HelloRequest, global::CalculatorGrpcService.HelloReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SayHello",
        __Marshaller_calculator_HelloRequest,
        __Marshaller_calculator_HelloReply);

    static readonly grpc::Method<global::CalculatorGrpcService.Numbers, global::CalculatorGrpcService.Response> __Method_Addition = new grpc::Method<global::CalculatorGrpcService.Numbers, global::CalculatorGrpcService.Response>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Addition",
        __Marshaller_calculator_Numbers,
        __Marshaller_calculator_Response);

    static readonly grpc::Method<global::CalculatorGrpcService.Numbers, global::CalculatorGrpcService.Response> __Method_Subtraction = new grpc::Method<global::CalculatorGrpcService.Numbers, global::CalculatorGrpcService.Response>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Subtraction",
        __Marshaller_calculator_Numbers,
        __Marshaller_calculator_Response);

    static readonly grpc::Method<global::CalculatorGrpcService.Numbers, global::CalculatorGrpcService.Response> __Method_Multiplication = new grpc::Method<global::CalculatorGrpcService.Numbers, global::CalculatorGrpcService.Response>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Multiplication",
        __Marshaller_calculator_Numbers,
        __Marshaller_calculator_Response);

    static readonly grpc::Method<global::CalculatorGrpcService.Numbers, global::CalculatorGrpcService.Response> __Method_Division = new grpc::Method<global::CalculatorGrpcService.Numbers, global::CalculatorGrpcService.Response>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Division",
        __Marshaller_calculator_Numbers,
        __Marshaller_calculator_Response);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::CalculatorGrpcService.CalculatorReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for Calculator</summary>
    public partial class CalculatorClient : grpc::ClientBase<CalculatorClient>
    {
      /// <summary>Creates a new client for Calculator</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public CalculatorClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Calculator that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public CalculatorClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected CalculatorClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected CalculatorClient(ClientBaseConfiguration configuration) : base(configuration)
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
      public virtual global::CalculatorGrpcService.HelloReply SayHello(global::CalculatorGrpcService.HelloRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SayHello(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::CalculatorGrpcService.HelloReply SayHello(global::CalculatorGrpcService.HelloRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SayHello, null, options, request);
      }
      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::CalculatorGrpcService.HelloReply> SayHelloAsync(global::CalculatorGrpcService.HelloRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SayHelloAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::CalculatorGrpcService.HelloReply> SayHelloAsync(global::CalculatorGrpcService.HelloRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SayHello, null, options, request);
      }
      public virtual global::CalculatorGrpcService.Response Addition(global::CalculatorGrpcService.Numbers request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Addition(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::CalculatorGrpcService.Response Addition(global::CalculatorGrpcService.Numbers request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Addition, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::CalculatorGrpcService.Response> AdditionAsync(global::CalculatorGrpcService.Numbers request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AdditionAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::CalculatorGrpcService.Response> AdditionAsync(global::CalculatorGrpcService.Numbers request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Addition, null, options, request);
      }
      public virtual global::CalculatorGrpcService.Response Subtraction(global::CalculatorGrpcService.Numbers request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Subtraction(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::CalculatorGrpcService.Response Subtraction(global::CalculatorGrpcService.Numbers request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Subtraction, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::CalculatorGrpcService.Response> SubtractionAsync(global::CalculatorGrpcService.Numbers request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SubtractionAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::CalculatorGrpcService.Response> SubtractionAsync(global::CalculatorGrpcService.Numbers request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Subtraction, null, options, request);
      }
      public virtual global::CalculatorGrpcService.Response Multiplication(global::CalculatorGrpcService.Numbers request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Multiplication(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::CalculatorGrpcService.Response Multiplication(global::CalculatorGrpcService.Numbers request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Multiplication, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::CalculatorGrpcService.Response> MultiplicationAsync(global::CalculatorGrpcService.Numbers request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MultiplicationAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::CalculatorGrpcService.Response> MultiplicationAsync(global::CalculatorGrpcService.Numbers request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Multiplication, null, options, request);
      }
      public virtual global::CalculatorGrpcService.Response Division(global::CalculatorGrpcService.Numbers request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Division(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::CalculatorGrpcService.Response Division(global::CalculatorGrpcService.Numbers request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Division, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::CalculatorGrpcService.Response> DivisionAsync(global::CalculatorGrpcService.Numbers request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DivisionAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::CalculatorGrpcService.Response> DivisionAsync(global::CalculatorGrpcService.Numbers request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Division, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override CalculatorClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new CalculatorClient(configuration);
      }
    }

  }
}
#endregion
