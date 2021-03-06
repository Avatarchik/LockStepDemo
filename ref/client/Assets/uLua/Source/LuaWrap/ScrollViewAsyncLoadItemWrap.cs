﻿using System;
using UnityEngine;
using LuaInterface;
using Object = UnityEngine.Object;

public class ScrollViewAsyncLoadItemWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("Refresh", Refresh),
			new LuaMethod("New", _CreateScrollViewAsyncLoadItem),
			new LuaMethod("GetClassType", GetClassType),
			new LuaMethod("__eq", Lua_Eq),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("OnCreateItem", get_OnCreateItem, set_OnCreateItem),
			new LuaField("LoadCountOnce", null, set_LoadCountOnce),
		};

		LuaScriptMgr.RegisterLib(L, "ScrollViewAsyncLoadItem", typeof(ScrollViewAsyncLoadItem), regs, fields, typeof(MonoBehaviour));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateScrollViewAsyncLoadItem(IntPtr L)
	{
		LuaDLL.luaL_error(L, "ScrollViewAsyncLoadItem class does not have a constructor function");
		return 0;
	}

	static Type classType = typeof(ScrollViewAsyncLoadItem);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_OnCreateItem(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ScrollViewAsyncLoadItem obj = (ScrollViewAsyncLoadItem)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name OnCreateItem");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index OnCreateItem on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.OnCreateItem);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_LoadCountOnce(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ScrollViewAsyncLoadItem obj = (ScrollViewAsyncLoadItem)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name LoadCountOnce");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index LoadCountOnce on a nil value");
			}
		}

		obj.LoadCountOnce = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_OnCreateItem(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ScrollViewAsyncLoadItem obj = (ScrollViewAsyncLoadItem)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name OnCreateItem");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index OnCreateItem on a nil value");
			}
		}

		LuaTypes funcType = LuaDLL.lua_type(L, 3);

		if (funcType != LuaTypes.LUA_TFUNCTION)
		{
			obj.OnCreateItem = (Func<int,Transform,GameObject>)LuaScriptMgr.GetNetObject(L, 3, typeof(Func<int,Transform,GameObject>));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.ToLuaFunction(L, 3);
			obj.OnCreateItem = (param0, param1) =>
			{
				int top = func.BeginPCall();
				LuaScriptMgr.Push(L, param0);
				LuaScriptMgr.Push(L, param1);
				func.PCall(top, 2);
				object[] objs = func.PopValues(top);
				func.EndPCall(top);
				return (GameObject)objs[0];
			};
		}
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Refresh(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		ScrollViewAsyncLoadItem obj = (ScrollViewAsyncLoadItem)LuaScriptMgr.GetUnityObjectSelf(L, 1, "ScrollViewAsyncLoadItem");
		int arg0 = (int)LuaScriptMgr.GetNumber(L, 2);
		obj.Refresh(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Lua_Eq(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Object arg0 = LuaScriptMgr.GetLuaObject(L, 1) as Object;
		Object arg1 = LuaScriptMgr.GetLuaObject(L, 2) as Object;
		bool o = arg0 == arg1;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

