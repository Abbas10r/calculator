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

    /// <summary>Base class for server-side implementations of Calculator</summary>
    [grpc::BindServiceMethod(typeof(Calculator), "BindService")]
    public abstract partial class CalculatorBase
    {
      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::CalculatorGrpcService.HelloReply> SayHello(global::CalculatorGrpcService.HelloRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::CalculatorGrpcService.Response> Addition(global::CalculatorGrpcService.Numbers request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::CalculatorGrpcService.Response> Subtraction(global::CalculatorGrpcService.Numbers request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::CalculatorGrpcService.Response> Multiplication(global::CalculatorGrpcService.Numbers request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::CalculatorGrpcService.Response> Division(global::CalculatorGrpcService.Numbers request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(CalculatorBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_SayHello, serviceImpl.SayHello)
          .AddMethod(__Method_Addition, serviceImpl.Addition)
          .AddMethod(__Method_Subtraction, serviceImpl.Subtraction)
          .AddMethod(__Method_Multiplication, serviceImpl.Multiplication)
          .AddMethod(__Method_Division, serviceImpl.Division).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, CalculatorBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_SayHello, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CalculatorGrpcService.HelloRequest, global::CalculatorGrpcService.HelloReply>(serviceImpl.SayHello));
      serviceBinder.AddMethod(__Method_Addition, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CalculatorGrpcService.Numbers, global::CalculatorGrpcService.Response>(serviceImpl.Addition));
      serviceBinder.AddMethod(__Method_Subtraction, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CalculatorGrpcService.Numbers, global::CalculatorGrpcService.Response>(serviceImpl.Subtraction));
      serviceBinder.AddMethod(__Method_Multiplication, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CalculatorGrpcService.Numbers, global::CalculatorGrpcService.Response>(serviceImpl.Multiplication));
      serviceBinder.AddMethod(__Method_Division, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CalculatorGrpcService.Numbers, global::CalculatorGrpcService.Response>(serviceImpl.Division));
    }

  }
}
#endregion
