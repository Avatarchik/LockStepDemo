﻿using System;
using LuaInterface;

public class GameMatch_1ON1Wrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("OnGameBegin", OnGameBegin),
			new LuaMethod("GameUpdate", GameUpdate),
			new LuaMethod("EnableMatchAchievement", EnableMatchAchievement),
			new LuaMethod("EnableMatchTips", EnableMatchTips),
			new LuaMethod("EnablePlayerTips", EnablePlayerTips),
			new LuaMethod("EnableTakeOver", EnableTakeOver),
			new LuaMethod("EnableEnhanceAttr", EnableEnhanceAttr),
			new LuaMethod("InitBallHolder", InitBallHolder),
			new LuaMethod("OnMatchStateChange", OnMatchStateChange),
			new LuaMethod("New", _CreateGameMatch_1ON1),
			new LuaMethod("GetClassType", GetClassType),
		};

		LuaField[] fields = new LuaField[]
		{
		};

		LuaScriptMgr.RegisterLib(L, "GameMatch_1ON1", typeof(GameMatch_1ON1), regs, fields, typeof(GameMatch));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateGameMatch_1ON1(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 1)
		{
			GameMatch.Config arg0 = (GameMatch.Config)LuaScriptMgr.GetNetObject(L, 1, typeof(GameMatch.Config));
			GameMatch_1ON1 obj = new GameMatch_1ON1(arg0);
			LuaScriptMgr.PushObject(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: GameMatch_1ON1.New");
		}

		return 0;
	}

	static Type classType = typeof(GameMatch_1ON1);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnGameBegin(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		GameMatch_1ON1 obj = (GameMatch_1ON1)LuaScriptMgr.GetNetObjectSelf(L, 1, "GameMatch_1ON1");
		fogs.proto.msg.GameBeginResp arg0 = (fogs.proto.msg.GameBeginResp)LuaScriptMgr.GetNetObject(L, 2, typeof(fogs.proto.msg.GameBeginResp));
		obj.OnGameBegin(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GameUpdate(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		GameMatch_1ON1 obj = (GameMatch_1ON1)LuaScriptMgr.GetNetObjectSelf(L, 1, "GameMatch_1ON1");
		IM.Number arg0 = (IM.Number)LuaScriptMgr.GetNetObject(L, 2, typeof(IM.Number));
		obj.GameUpdate(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int EnableMatchAchievement(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		GameMatch_1ON1 obj = (GameMatch_1ON1)LuaScriptMgr.GetNetObjectSelf(L, 1, "GameMatch_1ON1");
		bool o = obj.EnableMatchAchievement();
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int EnableMatchTips(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		GameMatch_1ON1 obj = (GameMatch_1ON1)LuaScriptMgr.GetNetObjectSelf(L, 1, "GameMatch_1ON1");
		bool o = obj.EnableMatchTips();
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int EnablePlayerTips(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		GameMatch_1ON1 obj = (GameMatch_1ON1)LuaScriptMgr.GetNetObjectSelf(L, 1, "GameMatch_1ON1");
		bool o = obj.EnablePlayerTips();
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int EnableTakeOver(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		GameMatch_1ON1 obj = (GameMatch_1ON1)LuaScriptMgr.GetNetObjectSelf(L, 1, "GameMatch_1ON1");
		bool o = obj.EnableTakeOver();
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int EnableEnhanceAttr(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		GameMatch_1ON1 obj = (GameMatch_1ON1)LuaScriptMgr.GetNetObjectSelf(L, 1, "GameMatch_1ON1");
		bool o = obj.EnableEnhanceAttr();
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int InitBallHolder(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		GameMatch_1ON1 obj = (GameMatch_1ON1)LuaScriptMgr.GetNetObjectSelf(L, 1, "GameMatch_1ON1");
		obj.InitBallHolder();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnMatchStateChange(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 3);
		GameMatch_1ON1 obj = (GameMatch_1ON1)LuaScriptMgr.GetNetObjectSelf(L, 1, "GameMatch_1ON1");
		MatchState arg0 = (MatchState)LuaScriptMgr.GetNetObject(L, 2, typeof(MatchState));
		MatchState arg1 = (MatchState)LuaScriptMgr.GetNetObject(L, 3, typeof(MatchState));
		obj.OnMatchStateChange(arg0,arg1);
		return 0;
	}
}

