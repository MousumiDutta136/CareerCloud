// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/CompanyDescription.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace CareerCloud.gRPC.Protos {
  public static partial class CompanyDescriptionService
  {
    static readonly string __ServiceName = "CareerCloud.gRPC.CompanyDescriptionService";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::CareerCloud.gRPC.Protos.IdRequest4> __Marshaller_CareerCloud_gRPC_IdRequest4 = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::CareerCloud.gRPC.Protos.IdRequest4.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::CareerCloud.gRPC.Protos.CompanyDescription> __Marshaller_CareerCloud_gRPC_CompanyDescription = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::CareerCloud.gRPC.Protos.CompanyDescription.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Protobuf.WellKnownTypes.Empty.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::CareerCloud.gRPC.Protos.CompanyDescriptions> __Marshaller_CareerCloud_gRPC_CompanyDescriptions = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::CareerCloud.gRPC.Protos.CompanyDescriptions.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::CareerCloud.gRPC.Protos.IdRequest4, global::CareerCloud.gRPC.Protos.CompanyDescription> __Method_GetCompanyDescription = new grpc::Method<global::CareerCloud.gRPC.Protos.IdRequest4, global::CareerCloud.gRPC.Protos.CompanyDescription>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetCompanyDescription",
        __Marshaller_CareerCloud_gRPC_IdRequest4,
        __Marshaller_CareerCloud_gRPC_CompanyDescription);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::CareerCloud.gRPC.Protos.CompanyDescriptions> __Method_GetCompanyDescriptions = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::CareerCloud.gRPC.Protos.CompanyDescriptions>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetCompanyDescriptions",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_CareerCloud_gRPC_CompanyDescriptions);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::CareerCloud.gRPC.Protos.CompanyDescriptions, global::Google.Protobuf.WellKnownTypes.Empty> __Method_AddCompanyDescription = new grpc::Method<global::CareerCloud.gRPC.Protos.CompanyDescriptions, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AddCompanyDescription",
        __Marshaller_CareerCloud_gRPC_CompanyDescriptions,
        __Marshaller_google_protobuf_Empty);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::CareerCloud.gRPC.Protos.CompanyDescriptions, global::Google.Protobuf.WellKnownTypes.Empty> __Method_UpdateCompanyDescription = new grpc::Method<global::CareerCloud.gRPC.Protos.CompanyDescriptions, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateCompanyDescription",
        __Marshaller_CareerCloud_gRPC_CompanyDescriptions,
        __Marshaller_google_protobuf_Empty);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::CareerCloud.gRPC.Protos.CompanyDescriptions, global::Google.Protobuf.WellKnownTypes.Empty> __Method_DeleteCompanyDescription = new grpc::Method<global::CareerCloud.gRPC.Protos.CompanyDescriptions, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteCompanyDescription",
        __Marshaller_CareerCloud_gRPC_CompanyDescriptions,
        __Marshaller_google_protobuf_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::CareerCloud.gRPC.Protos.CompanyDescriptionReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of CompanyDescriptionService</summary>
    [grpc::BindServiceMethod(typeof(CompanyDescriptionService), "BindService")]
    public abstract partial class CompanyDescriptionServiceBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::CareerCloud.gRPC.Protos.CompanyDescription> GetCompanyDescription(global::CareerCloud.gRPC.Protos.IdRequest4 request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::CareerCloud.gRPC.Protos.CompanyDescriptions> GetCompanyDescriptions(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> AddCompanyDescription(global::CareerCloud.gRPC.Protos.CompanyDescriptions request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> UpdateCompanyDescription(global::CareerCloud.gRPC.Protos.CompanyDescriptions request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> DeleteCompanyDescription(global::CareerCloud.gRPC.Protos.CompanyDescriptions request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(CompanyDescriptionServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetCompanyDescription, serviceImpl.GetCompanyDescription)
          .AddMethod(__Method_GetCompanyDescriptions, serviceImpl.GetCompanyDescriptions)
          .AddMethod(__Method_AddCompanyDescription, serviceImpl.AddCompanyDescription)
          .AddMethod(__Method_UpdateCompanyDescription, serviceImpl.UpdateCompanyDescription)
          .AddMethod(__Method_DeleteCompanyDescription, serviceImpl.DeleteCompanyDescription).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, CompanyDescriptionServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetCompanyDescription, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CareerCloud.gRPC.Protos.IdRequest4, global::CareerCloud.gRPC.Protos.CompanyDescription>(serviceImpl.GetCompanyDescription));
      serviceBinder.AddMethod(__Method_GetCompanyDescriptions, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Protobuf.WellKnownTypes.Empty, global::CareerCloud.gRPC.Protos.CompanyDescriptions>(serviceImpl.GetCompanyDescriptions));
      serviceBinder.AddMethod(__Method_AddCompanyDescription, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CareerCloud.gRPC.Protos.CompanyDescriptions, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.AddCompanyDescription));
      serviceBinder.AddMethod(__Method_UpdateCompanyDescription, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CareerCloud.gRPC.Protos.CompanyDescriptions, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.UpdateCompanyDescription));
      serviceBinder.AddMethod(__Method_DeleteCompanyDescription, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CareerCloud.gRPC.Protos.CompanyDescriptions, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.DeleteCompanyDescription));
    }

  }
}
#endregion
