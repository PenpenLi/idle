﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class SoundManagerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(SoundManager), typeof(UnityEngine.MonoBehaviour));
		L.RegFunction("play_mus", play_mus);
		L.RegFunction("play_sound", play_sound);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("SoundVolume", get_SoundVolume, set_SoundVolume);
		L.RegVar("SoundEffectVolume", get_SoundEffectVolume, set_SoundEffectVolume);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int play_mus(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			SoundManager obj = (SoundManager)ToLua.CheckObject<SoundManager>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			obj.play_mus(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int play_sound(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			SoundManager obj = (SoundManager)ToLua.CheckObject<SoundManager>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			obj.play_sound(arg0);
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
	static int get_SoundVolume(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SoundManager obj = (SoundManager)o;
			float ret = obj.SoundVolume;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index SoundVolume on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_SoundEffectVolume(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SoundManager obj = (SoundManager)o;
			float ret = obj.SoundEffectVolume;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index SoundEffectVolume on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_SoundVolume(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SoundManager obj = (SoundManager)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.SoundVolume = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index SoundVolume on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_SoundEffectVolume(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SoundManager obj = (SoundManager)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.SoundEffectVolume = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index SoundEffectVolume on a nil value");
		}
	}
}

