//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: Practice.proto
// Note: requires additional types generated from: Base.proto
namespace fogs.proto.msg
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PracticeInfo")]
  public partial class PracticeInfo : global::ProtoBuf.IExtensible
  {
    public PracticeInfo() {}
    
    private uint _id = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint id
    {
      get { return _id; }
      set { _id = value; }
    }
    private uint _finished = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"finished", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint finished
    {
      get { return _finished; }
      set { _finished = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BeginPractice")]
  public partial class BeginPractice : global::ProtoBuf.IExtensible
  {
    public BeginPractice() {}
    
    private uint _id = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint id
    {
      get { return _id; }
      set { _id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BeginPracticeResp")]
  public partial class BeginPracticeResp : global::ProtoBuf.IExtensible
  {
    public BeginPracticeResp() {}
    
    private uint _result = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint result
    {
      get { return _result; }
      set { _result = value; }
    }
    private uint _id = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint id
    {
      get { return _id; }
      set { _id = value; }
    }
    private ulong _session_id = default(ulong);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"session_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong session_id
    {
      get { return _session_id; }
      set { _session_id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"EndPractice")]
  public partial class EndPractice : global::ProtoBuf.IExtensible
  {
    public EndPractice() {}
    
    private ulong _session_id = default(ulong);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"session_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong session_id
    {
      get { return _session_id; }
      set { _session_id = value; }
    }
    private uint _goal_times = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"goal_times", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint goal_times
    {
      get { return _goal_times; }
      set { _goal_times = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"EndPracticeResp")]
  public partial class EndPracticeResp : global::ProtoBuf.IExtensible
  {
    public EndPracticeResp() {}
    
    private uint _result = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint result
    {
      get { return _result; }
      set { _result = value; }
    }
    private uint _time = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"time", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint time
    {
      get { return _time; }
      set { _time = value; }
    }
    private readonly global::System.Collections.Generic.List<fogs.proto.msg.KeyValueData> _awards = new global::System.Collections.Generic.List<fogs.proto.msg.KeyValueData>();
    [global::ProtoBuf.ProtoMember(3, Name=@"awards", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<fogs.proto.msg.KeyValueData> awards
    {
      get { return _awards; }
    }
  
    private uint _id = default(uint);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint id
    {
      get { return _id; }
      set { _id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ExitPractice")]
  public partial class ExitPractice : global::ProtoBuf.IExtensible
  {
    public ExitPractice() {}
    
    private ulong _session_id = default(ulong);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"session_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong session_id
    {
      get { return _session_id; }
      set { _session_id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ExitPracticeResp")]
  public partial class ExitPracticeResp : global::ProtoBuf.IExtensible
  {
    public ExitPracticeResp() {}
    
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
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PracticePveInfo")]
  public partial class PracticePveInfo : global::ProtoBuf.IExtensible
  {
    public PracticePveInfo() {}
    
    private uint _id = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint id
    {
      get { return _id; }
      set { _id = value; }
    }
    private uint _race_times = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"race_times", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint race_times
    {
      get { return _race_times; }
      set { _race_times = value; }
    }
    private uint _win_times = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"win_times", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint win_times
    {
      get { return _win_times; }
      set { _win_times = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BeginPracticePve")]
  public partial class BeginPracticePve : global::ProtoBuf.IExtensible
  {
    public BeginPracticePve() {}
    
    private uint _id = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint id
    {
      get { return _id; }
      set { _id = value; }
    }
    private fogs.proto.msg.FightRoleInfo _fight_list = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"fight_list", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public fogs.proto.msg.FightRoleInfo fight_list
    {
      get { return _fight_list; }
      set { _fight_list = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BeginPracticePveResp")]
  public partial class BeginPracticePveResp : global::ProtoBuf.IExtensible
  {
    public BeginPracticePveResp() {}
    
    private uint _result = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint result
    {
      get { return _result; }
      set { _result = value; }
    }
    private uint _id = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint id
    {
      get { return _id; }
      set { _id = value; }
    }
    private ulong _session_id = default(ulong);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"session_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong session_id
    {
      get { return _session_id; }
      set { _session_id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"EndPracticePve")]
  public partial class EndPracticePve : global::ProtoBuf.IExtensible
  {
    public EndPracticePve() {}
    
    private ulong _session_id = default(ulong);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"session_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong session_id
    {
      get { return _session_id; }
      set { _session_id = value; }
    }
    private uint _main_role_side = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"main_role_side", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint main_role_side
    {
      get { return _main_role_side; }
      set { _main_role_side = value; }
    }
    private uint _score_home = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"score_home", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint score_home
    {
      get { return _score_home; }
      set { _score_home = value; }
    }
    private uint _score_away = default(uint);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"score_away", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint score_away
    {
      get { return _score_away; }
      set { _score_away = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"EndPracticePveResp")]
  public partial class EndPracticePveResp : global::ProtoBuf.IExtensible
  {
    public EndPracticePveResp() {}
    
    private uint _result = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint result
    {
      get { return _result; }
      set { _result = value; }
    }
    private readonly global::System.Collections.Generic.List<fogs.proto.msg.KeyValueData> _awards = new global::System.Collections.Generic.List<fogs.proto.msg.KeyValueData>();
    [global::ProtoBuf.ProtoMember(2, Name=@"awards", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<fogs.proto.msg.KeyValueData> awards
    {
      get { return _awards; }
    }
  
    private uint _id = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint id
    {
      get { return _id; }
      set { _id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}