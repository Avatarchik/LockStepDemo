//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: Pvp.proto
// Note: requires additional types generated from: Base.proto
// Note: requires additional types generated from: Player.proto
namespace fogs.proto.msg
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ClientInput")]
  public partial class ClientInput : global::ProtoBuf.IExtensible
  {
    public ClientInput() {}
    
    private uint _dir = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"dir", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint dir
    {
      get { return _dir; }
      set { _dir = value; }
    }
    private uint _cmd = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"cmd", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint cmd
    {
      get { return _cmd; }
      set { _cmd = value; }
    }
    private uint _acc_id = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"acc_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ClientStateChanged")]
  public partial class ClientStateChanged : global::ProtoBuf.IExtensible
  {
    public ClientStateChanged() {}
    
    private uint _acc_id = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"acc_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint acc_id
    {
      get { return _acc_id; }
      set { _acc_id = value; }
    }
    private uint _state = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"state", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint state
    {
      get { return _state; }
      set { _state = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"FrameInfo")]
  public partial class FrameInfo : global::ProtoBuf.IExtensible
  {
    public FrameInfo() {}
    
    private readonly global::System.Collections.Generic.List<fogs.proto.msg.ClientInput> _info = new global::System.Collections.Generic.List<fogs.proto.msg.ClientInput>();
    [global::ProtoBuf.ProtoMember(1, Name=@"info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<fogs.proto.msg.ClientInput> info
    {
      get { return _info; }
    }
  
    private uint _frameNum = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"frameNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint frameNum
    {
      get { return _frameNum; }
      set { _frameNum = value; }
    }
    private double _time = default(double);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"time", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(double))]
    public double time
    {
      get { return _time; }
      set { _time = value; }
    }
    private readonly global::System.Collections.Generic.List<fogs.proto.msg.ClientStateChanged> _client_state_list = new global::System.Collections.Generic.List<fogs.proto.msg.ClientStateChanged>();
    [global::ProtoBuf.ProtoMember(4, Name=@"client_state_list", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<fogs.proto.msg.ClientStateChanged> client_state_list
    {
      get { return _client_state_list; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"MissFrameReq")]
  public partial class MissFrameReq : global::ProtoBuf.IExtensible
  {
    public MissFrameReq() {}
    
    private uint _acc_id = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"acc_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint acc_id
    {
      get { return _acc_id; }
      set { _acc_id = value; }
    }
    private readonly global::System.Collections.Generic.List<uint> _frame_num = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(2, Name=@"frame_num", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> frame_num
    {
      get { return _frame_num; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PlayFrame")]
  public partial class PlayFrame : global::ProtoBuf.IExtensible
  {
    public PlayFrame() {}
    
    private readonly global::System.Collections.Generic.List<fogs.proto.msg.FrameInfo> _frames = new global::System.Collections.Generic.List<fogs.proto.msg.FrameInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"frames", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<fogs.proto.msg.FrameInfo> frames
    {
      get { return _frames; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CheckFrame")]
  public partial class CheckFrame : global::ProtoBuf.IExtensible
  {
    public CheckFrame() {}
    
    private uint _frameNum;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"frameNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint frameNum
    {
      get { return _frameNum; }
      set { _frameNum = value; }
    }
    private readonly global::System.Collections.Generic.List<fogs.proto.msg.RoleKeyState> _roleDatas = new global::System.Collections.Generic.List<fogs.proto.msg.RoleKeyState>();
    [global::ProtoBuf.ProtoMember(2, Name=@"roleDatas", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<fogs.proto.msg.RoleKeyState> roleDatas
    {
      get { return _roleDatas; }
    }
  
    private readonly global::System.Collections.Generic.List<fogs.proto.msg.BallKeyState> _ballDatas = new global::System.Collections.Generic.List<fogs.proto.msg.BallKeyState>();
    [global::ProtoBuf.ProtoMember(3, Name=@"ballDatas", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<fogs.proto.msg.BallKeyState> ballDatas
    {
      get { return _ballDatas; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RoleKeyState")]
  public partial class RoleKeyState : global::ProtoBuf.IExtensible
  {
    public RoleKeyState() {}
    
    private uint _index;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"index", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint index
    {
      get { return _index; }
      set { _index = value; }
    }
    private fogs.proto.msg.SVector3 _position;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"position", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public fogs.proto.msg.SVector3 position
    {
      get { return _position; }
      set { _position = value; }
    }
    private int _hori_angle;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"hori_angle", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int hori_angle
    {
      get { return _hori_angle; }
      set { _hori_angle = value; }
    }
    private int _state;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"state", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int state
    {
      get { return _state; }
      set { _state = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BallKeyState")]
  public partial class BallKeyState : global::ProtoBuf.IExtensible
  {
    public BallKeyState() {}
    
    private uint _index;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"index", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint index
    {
      get { return _index; }
      set { _index = value; }
    }
    private fogs.proto.msg.SVector3 _position;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"position", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public fogs.proto.msg.SVector3 position
    {
      get { return _position; }
      set { _position = value; }
    }
    private int _state;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"state", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int state
    {
      get { return _state; }
      set { _state = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"NotifyOutSync")]
  public partial class NotifyOutSync : global::ProtoBuf.IExtensible
  {
    public NotifyOutSync() {}
    
    private uint _frameNum;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"frameNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint frameNum
    {
      get { return _frameNum; }
      set { _frameNum = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PlayerMatchData")]
  public partial class PlayerMatchData : global::ProtoBuf.IExtensible
  {
    public PlayerMatchData() {}
    
    private uint _acc_id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"acc_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint acc_id
    {
      get { return _acc_id; }
      set { _acc_id = value; }
    }
    private fogs.proto.msg.ExitMatchType _exit_type;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"exit_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public fogs.proto.msg.ExitMatchType exit_type
    {
      get { return _exit_type; }
      set { _exit_type = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TeamMatchData")]
  public partial class TeamMatchData : global::ProtoBuf.IExtensible
  {
    public TeamMatchData() {}
    
    private uint _acc_id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"acc_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint acc_id
    {
      get { return _acc_id; }
      set { _acc_id = value; }
    }
    private uint _race_time = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"race_time", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint race_time
    {
      get { return _race_time; }
      set { _race_time = value; }
    }
    private readonly global::System.Collections.Generic.List<fogs.proto.msg.PlayerMatchData> _player_data = new global::System.Collections.Generic.List<fogs.proto.msg.PlayerMatchData>();
    [global::ProtoBuf.ProtoMember(3, Name=@"player_data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<fogs.proto.msg.PlayerMatchData> player_data
    {
      get { return _player_data; }
    }
  
    private readonly global::System.Collections.Generic.List<fogs.proto.msg.MatchRoleData> _role_data = new global::System.Collections.Generic.List<fogs.proto.msg.MatchRoleData>();
    [global::ProtoBuf.ProtoMember(4, Name=@"role_data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<fogs.proto.msg.MatchRoleData> role_data
    {
      get { return _role_data; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TeamMatchDataResp")]
  public partial class TeamMatchDataResp : global::ProtoBuf.IExtensible
  {
    public TeamMatchDataResp() {}
    
    private uint _acc_id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"acc_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint acc_id
    {
      get { return _acc_id; }
      set { _acc_id = value; }
    }
    private uint _result;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint result
    {
      get { return _result; }
      set { _result = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}