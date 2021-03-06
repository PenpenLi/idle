﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UIScrollGridWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UIScrollGrid), typeof(UnityEngine.MonoBehaviour));
		L.RegFunction("SetData", SetData);
		L.RegFunction("SetInsert", SetInsert);
		L.RegFunction("SetDataAndKeepLocation", SetDataAndKeepLocation);
		L.RegFunction("Clear", Clear);
		L.RegFunction("Init", Init);
		L.RegFunction("OnScroll", OnScroll);
		L.RegFunction("GetSelectedIndex", GetSelectedIndex);
		L.RegFunction("DisplayIndex", DisplayIndex);
		L.RegFunction("UpdateItemAt", UpdateItemAt);
		L.RegFunction("UpdateItemAll", UpdateItemAll);
		L.RegFunction("StopMovement", StopMovement);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("prefab", get_prefab, set_prefab);
		L.RegVar("IsReverseLayer", get_IsReverseLayer, set_IsReverseLayer);
		L.RegVar("IsReverseScroll", get_IsReverseScroll, set_IsReverseScroll);
		L.RegVar("SetDataHandle", get_SetDataHandle, set_SetDataHandle);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetData(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UIScrollGrid obj = (UIScrollGrid)ToLua.CheckObject<UIScrollGrid>(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.SetData(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetInsert(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			UIScrollGrid obj = (UIScrollGrid)ToLua.CheckObject<UIScrollGrid>(L, 1);
			int[] arg0 = ToLua.CheckNumberArray<int>(L, 2);
			UnityEngine.RectTransform[] arg1 = ToLua.CheckObjectArray<UnityEngine.RectTransform>(L, 3);
			obj.SetInsert(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetDataAndKeepLocation(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UIScrollGrid obj = (UIScrollGrid)ToLua.CheckObject<UIScrollGrid>(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.SetDataAndKeepLocation(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Clear(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UIScrollGrid obj = (UIScrollGrid)ToLua.CheckObject<UIScrollGrid>(L, 1);
			obj.Clear();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Init(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			UIScrollGrid obj = (UIScrollGrid)ToLua.CheckObject<UIScrollGrid>(L, 1);
			object[] arg0 = ToLua.ToParamsObject(L, 2, count - 1);
			obj.Init(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnScroll(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UIScrollGrid obj = (UIScrollGrid)ToLua.CheckObject<UIScrollGrid>(L, 1);
			UnityEngine.Vector2 arg0 = ToLua.ToVector2(L, 2);
			obj.OnScroll(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetSelectedIndex(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UIScrollGrid obj = (UIScrollGrid)ToLua.CheckObject<UIScrollGrid>(L, 1);
			int o = obj.GetSelectedIndex();
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DisplayIndex(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UIScrollGrid obj = (UIScrollGrid)ToLua.CheckObject<UIScrollGrid>(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.DisplayIndex(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UpdateItemAt(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UIScrollGrid obj = (UIScrollGrid)ToLua.CheckObject<UIScrollGrid>(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.UpdateItemAt(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UpdateItemAll(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UIScrollGrid obj = (UIScrollGrid)ToLua.CheckObject<UIScrollGrid>(L, 1);
			obj.UpdateItemAll();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int StopMovement(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UIScrollGrid obj = (UIScrollGrid)ToLua.CheckObject<UIScrollGrid>(L, 1);
			obj.StopMovement();
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
	static int get_prefab(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIScrollGrid obj = (UIScrollGrid)o;
			UnityEngine.GameObject ret = obj.prefab;
			ToLua.PushSealed(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index prefab on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_IsReverseLayer(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIScrollGrid obj = (UIScrollGrid)o;
			bool ret = obj.IsReverseLayer;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index IsReverseLayer on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_IsReverseScroll(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIScrollGrid obj = (UIScrollGrid)o;
			bool ret = obj.IsReverseScroll;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index IsReverseScroll on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_SetDataHandle(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIScrollGrid obj = (UIScrollGrid)o;
			LuaInterface.LuaFunction ret = obj.SetDataHandle;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index SetDataHandle on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_prefab(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIScrollGrid obj = (UIScrollGrid)o;
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckObject(L, 2, typeof(UnityEngine.GameObject));
			obj.prefab = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index prefab on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_IsReverseLayer(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIScrollGrid obj = (UIScrollGrid)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.IsReverseLayer = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index IsReverseLayer on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_IsReverseScroll(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIScrollGrid obj = (UIScrollGrid)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.IsReverseScroll = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index IsReverseScroll on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_SetDataHandle(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIScrollGrid obj = (UIScrollGrid)o;
			LuaFunction arg0 = ToLua.CheckLuaFunction(L, 2);
			obj.SetDataHandle = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index SetDataHandle on a nil value");
		}
	}
}

