﻿using System;
using System.Collections.Generic;
using LuaInterface;

public class NewComerTotalDataKeyValuePairWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("ToString", ToString),
			new LuaMethod("New", _CreateNewComerTotalDataKeyValuePair),
			new LuaMethod("GetClassType", GetClassType),
			new LuaMethod("__tostring", Lua_ToString),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("Key", get_Key, null),
			new LuaField("Value", get_Value, null),
		};

		LuaScriptMgr.RegisterLib(L, "NewComerTotalDataKeyValuePair", typeof(KeyValuePair<uint,NewComerTotalData>), regs, fields, null);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateNewComerTotalDataKeyValuePair(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2)
		{
			uint arg0 = (uint)LuaScriptMgr.GetNumber(L, 1);
			NewComerTotalData arg1 = (NewComerTotalData)LuaScriptMgr.GetNetObject(L, 2, typeof(NewComerTotalData));
			KeyValuePair<uint,NewComerTotalData> obj = new KeyValuePair<uint,NewComerTotalData>(arg0,arg1);
			LuaScriptMgr.PushValue(L, obj);
			return 1;
		}
		else if (count == 0)
		{
			KeyValuePair<uint,NewComerTotalData> obj = new KeyValuePair<uint,NewComerTotalData>();
			LuaScriptMgr.PushValue(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: KeyValuePair<uint,NewComerTotalData>.New");
		}

		return 0;
	}

	static Type classType = typeof(KeyValuePair<uint,NewComerTotalData>);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Key(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Key");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Key on a nil value");
			}
		}

		KeyValuePair<uint,NewComerTotalData> obj = (KeyValuePair<uint,NewComerTotalData>)o;
		LuaScriptMgr.Push(L, obj.Key);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Value(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Value");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Value on a nil value");
			}
		}

		KeyValuePair<uint,NewComerTotalData> obj = (KeyValuePair<uint,NewComerTotalData>)o;
		LuaScriptMgr.PushObject(L, obj.Value);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Lua_ToString(IntPtr L)
	{
		object obj = LuaScriptMgr.GetLuaObject(L, 1);

		if (obj != null)
		{
			LuaScriptMgr.Push(L, obj.ToString());
		}
		else
		{
			LuaScriptMgr.Push(L, "Table: NewComerTotalDataKeyValuePair");
		}

		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ToString(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		KeyValuePair<uint,NewComerTotalData> obj = (KeyValuePair<uint,NewComerTotalData>)LuaScriptMgr.GetNetObjectSelf(L, 1, "KeyValuePair<uint,NewComerTotalData>");
		string o = obj.ToString();
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

