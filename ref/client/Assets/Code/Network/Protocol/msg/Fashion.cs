//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: Fashion.proto
namespace fogs.proto.msg
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"FashionSlotProto")]
  public partial class FashionSlotProto : global::ProtoBuf.IExtensible
  {
    public FashionSlotProto() {}
    
    private uint _id = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint id
    {
      get { return _id; }
      set { _id = value; }
    }
    private ulong _fashion_uuid = default(ulong);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"fashion_uuid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong fashion_uuid
    {
      get { return _fashion_uuid; }
      set { _fashion_uuid = value; }
    }
    private uint _goods_id = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"goods_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint goods_id
    {
      get { return _goods_id; }
      set { _goods_id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"FashionOperationInfo")]
  public partial class FashionOperationInfo : global::ProtoBuf.IExtensible
  {
    public FashionOperationInfo() {}
    
    private uint _type = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint type
    {
      get { return _type; }
      set { _type = value; }
    }
    private ulong _uuid = default(ulong);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"uuid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong uuid
    {
      get { return _uuid; }
      set { _uuid = value; }
    }
    private uint _subtype = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"subtype", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint subtype
    {
      get { return _subtype; }
      set { _subtype = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"FashionOperation")]
  public partial class FashionOperation : global::ProtoBuf.IExtensible
  {
    public FashionOperation() {}
    
    private readonly global::System.Collections.Generic.List<fogs.proto.msg.FashionOperationInfo> _info = new global::System.Collections.Generic.List<fogs.proto.msg.FashionOperationInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<fogs.proto.msg.FashionOperationInfo> info
    {
      get { return _info; }
    }
  
    private uint _role_id = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"role_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint role_id
    {
      get { return _role_id; }
      set { _role_id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"FashionOperationRespInfo")]
  public partial class FashionOperationRespInfo : global::ProtoBuf.IExtensible
  {
    public FashionOperationRespInfo() {}
    
    private uint _result = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint result
    {
      get { return _result; }
      set { _result = value; }
    }
    private uint _type = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint type
    {
      get { return _type; }
      set { _type = value; }
    }
    private ulong _uuid = default(ulong);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"uuid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong uuid
    {
      get { return _uuid; }
      set { _uuid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"FashionOperationResp")]
  public partial class FashionOperationResp : global::ProtoBuf.IExtensible
  {
    public FashionOperationResp() {}
    
    private readonly global::System.Collections.Generic.List<fogs.proto.msg.FashionOperationRespInfo> _resp_info = new global::System.Collections.Generic.List<fogs.proto.msg.FashionOperationRespInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"resp_info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<fogs.proto.msg.FashionOperationRespInfo> resp_info
    {
      get { return _resp_info; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    [global::ProtoBuf.ProtoContract(Name=@"FashionOperationType")]
    public enum FashionOperationType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"FOT_EQUIP", Value=1)]
      FOT_EQUIP = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"FOT_UNEQUIP", Value=2)]
      FOT_UNEQUIP = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"FOT_RENEW", Value=3)]
      FOT_RENEW = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"FOT_DELETE", Value=4)]
      FOT_DELETE = 4
    }
  
}