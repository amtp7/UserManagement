// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/usersManagement.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981
#region Designer generated code

using grpc = global::Grpc.Core;

namespace UserManagement.UserService.Protos {
  public static partial class UsersManagement
  {
    static readonly string __ServiceName = "UsersManagement.UsersManagement";

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
    static readonly grpc::Marshaller<global::UserManagement.UserService.Protos.GetUserRequest> __Marshaller_UsersManagement_GetUserRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::UserManagement.UserService.Protos.GetUserRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::UserManagement.UserService.Protos.GetUserResponse> __Marshaller_UsersManagement_GetUserResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::UserManagement.UserService.Protos.GetUserResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::UserManagement.UserService.Protos.Empty> __Marshaller_UsersManagement_Empty = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::UserManagement.UserService.Protos.Empty.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::UserManagement.UserService.Protos.GetAllUsersResponse> __Marshaller_UsersManagement_GetAllUsersResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::UserManagement.UserService.Protos.GetAllUsersResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::UserManagement.UserService.Protos.CreateUserRequest> __Marshaller_UsersManagement_CreateUserRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::UserManagement.UserService.Protos.CreateUserRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::UserManagement.UserService.Protos.CreateUserResponse> __Marshaller_UsersManagement_CreateUserResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::UserManagement.UserService.Protos.CreateUserResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::UserManagement.UserService.Protos.GetUserRequest, global::UserManagement.UserService.Protos.GetUserResponse> __Method_GetUser = new grpc::Method<global::UserManagement.UserService.Protos.GetUserRequest, global::UserManagement.UserService.Protos.GetUserResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetUser",
        __Marshaller_UsersManagement_GetUserRequest,
        __Marshaller_UsersManagement_GetUserResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::UserManagement.UserService.Protos.Empty, global::UserManagement.UserService.Protos.GetAllUsersResponse> __Method_GetAllUsers = new grpc::Method<global::UserManagement.UserService.Protos.Empty, global::UserManagement.UserService.Protos.GetAllUsersResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAllUsers",
        __Marshaller_UsersManagement_Empty,
        __Marshaller_UsersManagement_GetAllUsersResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::UserManagement.UserService.Protos.CreateUserRequest, global::UserManagement.UserService.Protos.CreateUserResponse> __Method_CreateUser = new grpc::Method<global::UserManagement.UserService.Protos.CreateUserRequest, global::UserManagement.UserService.Protos.CreateUserResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateUser",
        __Marshaller_UsersManagement_CreateUserRequest,
        __Marshaller_UsersManagement_CreateUserResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::UserManagement.UserService.Protos.UsersManagementReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of UsersManagement</summary>
    [grpc::BindServiceMethod(typeof(UsersManagement), "BindService")]
    public abstract partial class UsersManagementBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::UserManagement.UserService.Protos.GetUserResponse> GetUser(global::UserManagement.UserService.Protos.GetUserRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::UserManagement.UserService.Protos.GetAllUsersResponse> GetAllUsers(global::UserManagement.UserService.Protos.Empty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::UserManagement.UserService.Protos.CreateUserResponse> CreateUser(global::UserManagement.UserService.Protos.CreateUserRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(UsersManagementBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetUser, serviceImpl.GetUser)
          .AddMethod(__Method_GetAllUsers, serviceImpl.GetAllUsers)
          .AddMethod(__Method_CreateUser, serviceImpl.CreateUser).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, UsersManagementBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetUser, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::UserManagement.UserService.Protos.GetUserRequest, global::UserManagement.UserService.Protos.GetUserResponse>(serviceImpl.GetUser));
      serviceBinder.AddMethod(__Method_GetAllUsers, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::UserManagement.UserService.Protos.Empty, global::UserManagement.UserService.Protos.GetAllUsersResponse>(serviceImpl.GetAllUsers));
      serviceBinder.AddMethod(__Method_CreateUser, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::UserManagement.UserService.Protos.CreateUserRequest, global::UserManagement.UserService.Protos.CreateUserResponse>(serviceImpl.CreateUser));
    }

  }
}
#endregion
