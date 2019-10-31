﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class LuaManagerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(LuaManager), typeof(UnityEngine.MonoBehaviour));
		L.RegFunction("InitStart", InitStart);
		L.RegFunction("OtherTestStart", OtherTestStart);
		L.RegFunction("DoFile", DoFile);
		L.RegFunction("CallLuaFunction", CallLuaFunction);
		L.RegFunction("LuaGC", LuaGC);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("Lua", get_Lua, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int InitStart(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			LuaManager obj = (LuaManager)ToLua.CheckObject<LuaManager>(L, 1);
			obj.InitStart();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OtherTestStart(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaManager obj = (LuaManager)ToLua.CheckObject<LuaManager>(L, 1);
			object[] arg0 = ToLua.ToParamsObject(L, 2, count - 1);
			obj.OtherTestStart(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DoFile(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			LuaManager obj = (LuaManager)ToLua.CheckObject<LuaManager>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			obj.DoFile(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CallLuaFunction(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			LuaManager obj = (LuaManager)ToLua.CheckObject<LuaManager>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			string arg1 = ToLua.CheckString(L, 3);
			obj.CallLuaFunction(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LuaGC(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			LuaManager obj = (LuaManager)ToLua.CheckObject<LuaManager>(L, 1);
			obj.LuaGC();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Lua(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			LuaManager obj = (LuaManager)o;
			LuaInterface.LuaState ret = obj.Lua;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Lua on a nil value");
		}
	}
}

