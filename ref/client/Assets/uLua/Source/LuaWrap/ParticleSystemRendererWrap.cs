﻿using System;
using UnityEngine;
using LuaInterface;
using Object = UnityEngine.Object;

public class ParticleSystemRendererWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("New", _CreateParticleSystemRenderer),
			new LuaMethod("GetClassType", GetClassType),
			new LuaMethod("__eq", Lua_Eq),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("renderMode", get_renderMode, set_renderMode),
			new LuaField("lengthScale", get_lengthScale, set_lengthScale),
			new LuaField("velocityScale", get_velocityScale, set_velocityScale),
			new LuaField("cameraVelocityScale", get_cameraVelocityScale, set_cameraVelocityScale),
			new LuaField("normalDirection", get_normalDirection, set_normalDirection),
			new LuaField("alignment", get_alignment, set_alignment),
			new LuaField("pivot", get_pivot, set_pivot),
			new LuaField("sortMode", get_sortMode, set_sortMode),
			new LuaField("sortingFudge", get_sortingFudge, set_sortingFudge),
			new LuaField("minParticleSize", get_minParticleSize, set_minParticleSize),
			new LuaField("maxParticleSize", get_maxParticleSize, set_maxParticleSize),
			new LuaField("mesh", get_mesh, set_mesh),
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.ParticleSystemRenderer", typeof(ParticleSystemRenderer), regs, fields, typeof(Renderer));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateParticleSystemRenderer(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			ParticleSystemRenderer obj = new ParticleSystemRenderer();
			LuaScriptMgr.Push(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: ParticleSystemRenderer.New");
		}

		return 0;
	}

	static Type classType = typeof(ParticleSystemRenderer);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_renderMode(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleSystemRenderer obj = (ParticleSystemRenderer)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name renderMode");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index renderMode on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.renderMode);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_lengthScale(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleSystemRenderer obj = (ParticleSystemRenderer)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name lengthScale");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index lengthScale on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.lengthScale);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_velocityScale(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleSystemRenderer obj = (ParticleSystemRenderer)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name velocityScale");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index velocityScale on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.velocityScale);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_cameraVelocityScale(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleSystemRenderer obj = (ParticleSystemRenderer)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name cameraVelocityScale");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index cameraVelocityScale on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.cameraVelocityScale);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_normalDirection(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleSystemRenderer obj = (ParticleSystemRenderer)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name normalDirection");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index normalDirection on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.normalDirection);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_alignment(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleSystemRenderer obj = (ParticleSystemRenderer)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name alignment");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index alignment on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.alignment);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_pivot(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleSystemRenderer obj = (ParticleSystemRenderer)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name pivot");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index pivot on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.pivot);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_sortMode(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleSystemRenderer obj = (ParticleSystemRenderer)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name sortMode");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index sortMode on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.sortMode);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_sortingFudge(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleSystemRenderer obj = (ParticleSystemRenderer)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name sortingFudge");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index sortingFudge on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.sortingFudge);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_minParticleSize(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleSystemRenderer obj = (ParticleSystemRenderer)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name minParticleSize");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index minParticleSize on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.minParticleSize);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_maxParticleSize(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleSystemRenderer obj = (ParticleSystemRenderer)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name maxParticleSize");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index maxParticleSize on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.maxParticleSize);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_mesh(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleSystemRenderer obj = (ParticleSystemRenderer)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name mesh");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index mesh on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.mesh);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_renderMode(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleSystemRenderer obj = (ParticleSystemRenderer)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name renderMode");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index renderMode on a nil value");
			}
		}

		obj.renderMode = (ParticleSystemRenderMode)LuaScriptMgr.GetNetObject(L, 3, typeof(ParticleSystemRenderMode));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_lengthScale(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleSystemRenderer obj = (ParticleSystemRenderer)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name lengthScale");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index lengthScale on a nil value");
			}
		}

		obj.lengthScale = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_velocityScale(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleSystemRenderer obj = (ParticleSystemRenderer)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name velocityScale");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index velocityScale on a nil value");
			}
		}

		obj.velocityScale = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_cameraVelocityScale(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleSystemRenderer obj = (ParticleSystemRenderer)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name cameraVelocityScale");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index cameraVelocityScale on a nil value");
			}
		}

		obj.cameraVelocityScale = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_normalDirection(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleSystemRenderer obj = (ParticleSystemRenderer)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name normalDirection");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index normalDirection on a nil value");
			}
		}

		obj.normalDirection = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_alignment(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleSystemRenderer obj = (ParticleSystemRenderer)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name alignment");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index alignment on a nil value");
			}
		}

		obj.alignment = (ParticleSystemRenderSpace)LuaScriptMgr.GetNetObject(L, 3, typeof(ParticleSystemRenderSpace));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_pivot(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleSystemRenderer obj = (ParticleSystemRenderer)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name pivot");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index pivot on a nil value");
			}
		}

		obj.pivot = LuaScriptMgr.GetVector3(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_sortMode(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleSystemRenderer obj = (ParticleSystemRenderer)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name sortMode");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index sortMode on a nil value");
			}
		}

		obj.sortMode = (ParticleSystemSortMode)LuaScriptMgr.GetNetObject(L, 3, typeof(ParticleSystemSortMode));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_sortingFudge(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleSystemRenderer obj = (ParticleSystemRenderer)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name sortingFudge");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index sortingFudge on a nil value");
			}
		}

		obj.sortingFudge = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_minParticleSize(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleSystemRenderer obj = (ParticleSystemRenderer)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name minParticleSize");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index minParticleSize on a nil value");
			}
		}

		obj.minParticleSize = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_maxParticleSize(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleSystemRenderer obj = (ParticleSystemRenderer)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name maxParticleSize");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index maxParticleSize on a nil value");
			}
		}

		obj.maxParticleSize = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_mesh(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleSystemRenderer obj = (ParticleSystemRenderer)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name mesh");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index mesh on a nil value");
			}
		}

		obj.mesh = (Mesh)LuaScriptMgr.GetUnityObject(L, 3, typeof(Mesh));
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

