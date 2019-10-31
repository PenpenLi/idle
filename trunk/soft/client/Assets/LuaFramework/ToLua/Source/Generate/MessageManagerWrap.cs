﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class MessageManagerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(MessageManager), typeof(UnityEngine.MonoBehaviour));
		L.RegFunction("RegisterMsgHandle", RegisterMsgHandle);
		L.RegFunction("RemoveMsgHandle", RemoveMsgHandle);
		L.RegFunction("AddCommonMessage", AddCommonMessage);
		L.RegFunction("AddNetMessage", AddNetMessage);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RegisterMsgHandle(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			MessageManager obj = (MessageManager)ToLua.CheckObject<MessageManager>(L, 1);
			IMsgHandle arg0 = (IMsgHandle)ToLua.CheckObject<IMsgHandle>(L, 2);
			obj.RegisterMsgHandle(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveMsgHandle(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			MessageManager obj = (MessageManager)ToLua.CheckObject<MessageManager>(L, 1);
			IMsgHandle arg0 = (IMsgHandle)ToLua.CheckObject<IMsgHandle>(L, 2);
			obj.RemoveMsgHandle(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddCommonMessage(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			MessageManager obj = (MessageManager)ToLua.CheckObject<MessageManager>(L, 1);
			CommonMessage arg0 = (CommonMessage)ToLua.CheckObject<CommonMessage>(L, 2);
			obj.AddCommonMessage(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddNetMessage(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			MessageManager obj = (MessageManager)ToLua.CheckObject<MessageManager>(L, 1);
			NetMessage arg0 = (NetMessage)ToLua.CheckObject<NetMessage>(L, 2);
			obj.AddNetMessage(arg0);
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
}

