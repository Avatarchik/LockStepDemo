//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: Chat.proto
// Note: requires additional types generated from: Base.proto
namespace fogs.proto.msg
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ChatReq")]
  public partial class ChatReq : global::ProtoBuf.IExtensible
  {
    public ChatReq() {}
    
    private uint _type;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint type
    {
      get { return _type; }
      set { _type = value; }
    }
    private string _content = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"content", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string content
    {
      get { return _content; }
      set { _content = value; }
    }
    private string _target_name = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"target_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string target_name
    {
      get { return _target_name; }
      set { _target_name = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ChatResp")]
  public partial class ChatResp : global::ProtoBuf.IExtensible
  {
    public ChatResp() {}
    
    private uint _result = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint result
    {
      get { return _result; }
      set { _result = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ChatContent")]
  public partial class ChatContent : global::ProtoBuf.IExtensible
  {
    public ChatContent() {}
    
    private string _content = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"content", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string content
    {
      get { return _content; }
      set { _content = value; }
    }
    private string _ogri_name = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"ogri_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string ogri_name
    {
      get { return _ogri_name; }
      set { _ogri_name = value; }
    }
    private uint _acc_id = default(uint);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"acc_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint acc_id
    {
      get { return _acc_id; }
      set { _acc_id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ChatBroadcast")]
  public partial class ChatBroadcast : global::ProtoBuf.IExtensible
  {
    public ChatBroadcast() {}
    
    private uint _type;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint type
    {
      get { return _type; }
      set { _type = value; }
    }
    private uint _pos = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"pos", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint pos
    {
      get { return _pos; }
      set { _pos = value; }
    }
    private fogs.proto.msg.ChatContent _info = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public fogs.proto.msg.ChatContent info
    {
      get { return _info; }
      set { _info = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"QueryPlayerInfoReq")]
  public partial class QueryPlayerInfoReq : global::ProtoBuf.IExtensible
  {
    public QueryPlayerInfoReq() {}
    
    private uint _acc_id = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"acc_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint acc_id
    {
      get { return _acc_id; }
      set { _acc_id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"QueryPlayerInfoResp")]
  public partial class QueryPlayerInfoResp : global::ProtoBuf.IExtensible
  {
    public QueryPlayerInfoResp() {}
    
    private uint _id = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint id
    {
      get { return _id; }
      set { _id = value; }
    }
    private string _name = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }
    private uint _level = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint level
    {
      get { return _level; }
      set { _level = value; }
    }
    private readonly global::System.Collections.Generic.List<fogs.proto.msg.FightRole> _squad = new global::System.Collections.Generic.List<fogs.proto.msg.FightRole>();
    [global::ProtoBuf.ProtoMember(4, Name=@"squad", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<fogs.proto.msg.FightRole> squad
    {
      get { return _squad; }
    }
  
    private uint _plat_id = default(uint);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"plat_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint plat_id
    {
      get { return _plat_id; }
      set { _plat_id = value; }
    }
    private string _icon = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"icon", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string icon
    {
      get { return _icon; }
      set { _icon = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ChatLatestInfoReq")]
  public partial class ChatLatestInfoReq : global::ProtoBuf.IExtensible
  {
    public ChatLatestInfoReq() {}
    
    private uint _type = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint type
    {
      get { return _type; }
      set { _type = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ChatLatestInfoResp")]
  public partial class ChatLatestInfoResp : global::ProtoBuf.IExtensible
  {
    public ChatLatestInfoResp() {}
    
    private uint _type = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint type
    {
      get { return _type; }
      set { _type = value; }
    }
    private readonly global::System.Collections.Generic.List<fogs.proto.msg.ChatContent> _info = new global::System.Collections.Generic.List<fogs.proto.msg.ChatContent>();
    [global::ProtoBuf.ProtoMember(2, Name=@"info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<fogs.proto.msg.ChatContent> info
    {
      get { return _info; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    [global::ProtoBuf.ProtoContract(Name=@"ChatChannelType")]
    public enum ChatChannelType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"CCT_WORLD", Value=1)]
      CCT_WORLD = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CCT_SYSTEM", Value=2)]
      CCT_SYSTEM = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CCT_LEAGUE", Value=3)]
      CCT_LEAGUE = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CCT_TEAM", Value=4)]
      CCT_TEAM = 4
    }
  
}