﻿using System;
using LuaInterface;

public class PlayerState_DefenseWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("OnEnter", OnEnter),
			new LuaMethod("Update", Update),
			new LuaMethod("New", _CreatePlayerState_Defense),
			new LuaMethod("GetClassType", GetClassType),
		};

		LuaField[] fields = new LuaField[]
		{
		};

		LuaScriptMgr.RegisterLib(L, "PlayerState_Defense", typeof(PlayerState_Defense), regs, fields, typeof(PlayerState));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreatePlayerState_Defense(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2)
		{
			PlayerStateMachine arg0 = (PlayerStateMachine)LuaScriptMgr.GetNetObject(L, 1, typeof(PlayerStateMachine));
			GameMatch arg1 = (GameMatch)LuaScriptMgr.GetNetObject(L, 2, typeof(GameMatch));
			PlayerState_Defense obj = new PlayerState_Defense(arg0,arg1);
			LuaScriptMgr.PushObject(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: PlayerState_Defense.New");
		}

		return 0;
	}

	static Type classType = typeof(PlayerState_Defense);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnEnter(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		PlayerState_Defense obj = (PlayerState_Defense)LuaScriptMgr.GetNetObjectSelf(L, 1, "PlayerState_Defense");
		PlayerState arg0 = (PlayerState)LuaScriptMgr.GetNetObject(L, 2, typeof(PlayerState));
		obj.OnEnter(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Update(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		PlayerState_Defense obj = (PlayerState_Defense)LuaScriptMgr.GetNetObjectSelf(L, 1, "PlayerState_Defense");
		IM.Number arg0 = (IM.Number)LuaScriptMgr.GetNetObject(L, 2, typeof(IM.Number));
		obj.Update(arg0);
		return 0;
	}
}

