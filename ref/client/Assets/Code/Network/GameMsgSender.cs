using UnityEngine;
using System.IO;
using System.Collections.Generic;
using fogs.proto.msg;
using ProtoBuf;
using System;

public class GameMsgSender
{
	public GameMsgSender()
	{
	}

	static bool _FilterOutMsgByMatchState()
	{
		GameMatch match = GameSystem.Instance.mClient.mCurMatch;
		if( match == null || match.m_stateMachine.m_curState == null )
			return true;
		MatchState.State curState = match.m_stateMachine.m_curState.m_eState;
		if( curState == MatchState.State.eOpening || curState == MatchState.State.eOverTime || curState == MatchState.State.eOver )
			return true;
		return false;
	}

	public static void SendGameShortMsg(Player player, uint id, uint broadcastType)
	{
		NetworkConn conn = GameSystem.Instance.mNetworkManager.m_gameConn;
		if( conn == null )
			return;
		if( _FilterOutMsgByMatchState() )
			return;
		InstructionReq instReq = new InstructionReq();
		instReq.id = id;
		instReq.obj = broadcastType;
		instReq.char_id = player.m_roomPosId;

		NetworkConn server = GameSystem.Instance.mNetworkManager.m_gameConn;
		if( server != null )
			server.SendPack<InstructionReq>(0, instReq, MsgID.InstructionReqID);
	}

	public static void SendGameBegin()
	{
		NetworkConn conn = GameSystem.Instance.mNetworkManager.m_gameConn;
		if( conn == null)
			return;

		GameBeginReq gameBeginReq = new GameBeginReq();
		gameBeginReq.acc_id = MainPlayer.Instance.AccountID;

		GameSystem.Instance.mNetworkManager.m_gameConn.SendPack<GameBeginReq>(0, gameBeginReq, MsgID.GameBeginReqID);
	}

	public static void SendGameGoal(Player goaler, uint pt, bool bCritical)
	{
		if( GameSystem.Instance.mNetworkManager.m_gameConn == null )
			return;

		GameGoal goal = new GameGoal();
		goal.index = goaler.m_roomPosId;
		goal.score = pt;
		goal.kill_goal = Convert.ToUInt32( bCritical );
		
		GameSystem.Instance.mNetworkManager.m_gameConn.SendPack<GameGoal>(0, goal, MsgID.GameGoalID);
	}

	public static void SendTimeTracer(uint msgId, double dCurTime, NetworkConn server)
	{
		if( server == null || !server.IsConnected() )
			return;

		TimeTracer tracer = new TimeTracer();
		tracer.sendTimeStamp = dCurTime;
		tracer.id = msgId;
		server.SendPack<TimeTracer>(0, tracer, MsgID.TimeTracerID);
	}

    public static void SendPVPLoadProgress(uint perc)
    {
        if (GameSystem.Instance.mNetworkManager.m_gameConn == null)
            return;
        PVPLoadProgress obj = new PVPLoadProgress();
        obj.progress = perc;
        GameSystem.Instance.mNetworkManager.m_gameConn.SendPack<PVPLoadProgress>(0, obj, MsgID.PVPLoadProgressID);
    }

    public static void SendLoadingComplete(GameMatch.Type type)
	{
		if( GameSystem.Instance.mNetworkManager.m_gameConn == null )
			return;
		PVPLoadComplete obj = new PVPLoadComplete();
		obj.type = MatchType.MT_PVP_1V1_PLUS;
		if( type == GameMatch.Type.ePVP_3On3 )
			obj.type = MatchType.MT_PVP_3V3;
		GameSystem.Instance.mNetworkManager.m_gameConn.SendPack<PVPLoadComplete>(0, obj, MsgID.PVPLoadCompleteID);
	}

	public static void SendTipOff()
	{
		if( GameSystem.Instance.mNetworkManager.m_gameConn == null )
			return;
		BeginTipOffReq obj = new BeginTipOffReq();
		GameSystem.Instance.mNetworkManager.m_gameConn.SendPack<BeginTipOffReq>(0, obj, MsgID.BeginTipOffReqID);
	}

    public static void SendInput(InputDirection dir, Command cmd)
    {
		if( GameSystem.Instance.mNetworkManager.m_gameConn == null )
			return;
        ClientInput input = new ClientInput();
        input.acc_id = MainPlayer.Instance.AccountID;
        input.dir = (uint)dir;
        input.cmd = (uint)cmd;
		GameSystem.Instance.mNetworkManager.m_gameConn.SendPack<ClientInput>(0, input, MsgID.ClientInputID);
        //Logger.Log("SendInput " + dir + " " + cmd);
    }

    //For virtual game server
    public static void SendTurn(FrameInfo turn)
    {
        NetworkConn conn = GameSystem.Instance.mNetworkManager.m_gameConn;
		if( conn == null )
			return;
		conn.SendPack<FrameInfo>(0, turn, MsgID.FrameInfoID);
        //Logger.Log("VirtualGameServer, SendTurn " + turn.frameNum);

        //���ʹ�õ����������ӣ���֤��Ϣ�������ؿͻ���
        if (conn.m_type == NetworkConn.Type.eVirtualServer)
            conn.Update(0f);
    }

    //For virtual game server
    public static void SendGameBeginResp(GameBeginResp resp)
    {
		if( GameSystem.Instance.mNetworkManager.m_gameConn == null )
			return;
		GameSystem.Instance.mNetworkManager.m_gameConn.SendPack<GameBeginResp>(0, resp, MsgID.GameBeginRespID);
    }
}