﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class GameManagerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(GameManager), typeof(UnityEngine.MonoBehaviour));
		L.RegFunction("CheckVerInfo", CheckVerInfo);
		L.RegFunction("CheckExtractResource", CheckExtractResource);
		L.RegFunction("EnterLoginState", EnterLoginState);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("OnCheckVerStart", get_OnCheckVerStart, set_OnCheckVerStart);
		L.RegVar("OnCheckVerEnd", get_OnCheckVerEnd, set_OnCheckVerEnd);
		L.RegVar("OnCheckVerFail", get_OnCheckVerFail, set_OnCheckVerFail);
		L.RegVar("OnBuildUpdate", get_OnBuildUpdate, set_OnBuildUpdate);
		L.RegVar("OnDecompressDirStart", get_OnDecompressDirStart, set_OnDecompressDirStart);
		L.RegVar("OnDecompressDir", get_OnDecompressDir, set_OnDecompressDir);
		L.RegVar("OnDecompressDirEnd", get_OnDecompressDirEnd, set_OnDecompressDirEnd);
		L.RegVar("OnGetVerFileStart", get_OnGetVerFileStart, set_OnGetVerFileStart);
		L.RegVar("OnGetVerFileEnd", get_OnGetVerFileEnd, set_OnGetVerFileEnd);
		L.RegVar("OnCheckUpdateStart", get_OnCheckUpdateStart, set_OnCheckUpdateStart);
		L.RegVar("OnCheckUpdateFail", get_OnCheckUpdateFail, set_OnCheckUpdateFail);
		L.RegVar("OnCheckUpdateEnd", get_OnCheckUpdateEnd, set_OnCheckUpdateEnd);
		L.RegVar("OnUpdateStart", get_OnUpdateStart, set_OnUpdateStart);
		L.RegVar("OnUpdate", get_OnUpdate, set_OnUpdate);
		L.RegVar("OnUpdateFail", get_OnUpdateFail, set_OnUpdateFail);
		L.RegVar("OnUpdateEnd", get_OnUpdateEnd, set_OnUpdateEnd);
		L.RegVar("OnGetNewVerFileStart", get_OnGetNewVerFileStart, set_OnGetNewVerFileStart);
		L.RegVar("OnGetNewVerFileFail", get_OnGetNewVerFileFail, set_OnGetNewVerFileFail);
		L.RegVar("OnGetNewVerFileEnd", get_OnGetNewVerFileEnd, set_OnGetNewVerFileEnd);
		L.RegVar("OnChangeLocalResVer", get_OnChangeLocalResVer, set_OnChangeLocalResVer);
		L.RegVar("OnGoLoginFileEnd", get_OnGoLoginFileEnd, set_OnGoLoginFileEnd);
		L.RegVar("OnReGoLogin", get_OnReGoLogin, set_OnReGoLogin);
		L.RegVar("OnEnterGame", get_OnEnterGame, set_OnEnterGame);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CheckVerInfo(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			GameManager obj = (GameManager)ToLua.CheckObject<GameManager>(L, 1);
			obj.CheckVerInfo();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CheckExtractResource(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			GameManager obj = (GameManager)ToLua.CheckObject<GameManager>(L, 1);
			obj.CheckExtractResource();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int EnterLoginState(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			GameManager obj = (GameManager)ToLua.CheckObject<GameManager>(L, 1);
			obj.EnterLoginState();
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
	static int get_OnCheckVerStart(IntPtr L)
	{
		ToLua.Push(L, new EventObject(typeof(System.Action)));
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_OnCheckVerEnd(IntPtr L)
	{
		ToLua.Push(L, new EventObject(typeof(System.Action)));
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_OnCheckVerFail(IntPtr L)
	{
		ToLua.Push(L, new EventObject(typeof(System.Action)));
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_OnBuildUpdate(IntPtr L)
	{
		ToLua.Push(L, new EventObject(typeof(System.Action)));
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_OnDecompressDirStart(IntPtr L)
	{
		ToLua.Push(L, new EventObject(typeof(System.Action)));
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_OnDecompressDir(IntPtr L)
	{
		ToLua.Push(L, new EventObject(typeof(System.Action<string,float>)));
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_OnDecompressDirEnd(IntPtr L)
	{
		ToLua.Push(L, new EventObject(typeof(System.Action)));
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_OnGetVerFileStart(IntPtr L)
	{
		ToLua.Push(L, new EventObject(typeof(System.Action)));
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_OnGetVerFileEnd(IntPtr L)
	{
		ToLua.Push(L, new EventObject(typeof(System.Action)));
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_OnCheckUpdateStart(IntPtr L)
	{
		ToLua.Push(L, new EventObject(typeof(System.Action)));
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_OnCheckUpdateFail(IntPtr L)
	{
		ToLua.Push(L, new EventObject(typeof(System.Action)));
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_OnCheckUpdateEnd(IntPtr L)
	{
		ToLua.Push(L, new EventObject(typeof(System.Action<float>)));
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_OnUpdateStart(IntPtr L)
	{
		ToLua.Push(L, new EventObject(typeof(System.Action)));
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_OnUpdate(IntPtr L)
	{
		ToLua.Push(L, new EventObject(typeof(System.Action<float>)));
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_OnUpdateFail(IntPtr L)
	{
		ToLua.Push(L, new EventObject(typeof(System.Action<string>)));
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_OnUpdateEnd(IntPtr L)
	{
		ToLua.Push(L, new EventObject(typeof(System.Action)));
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_OnGetNewVerFileStart(IntPtr L)
	{
		ToLua.Push(L, new EventObject(typeof(System.Action)));
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_OnGetNewVerFileFail(IntPtr L)
	{
		ToLua.Push(L, new EventObject(typeof(System.Action)));
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_OnGetNewVerFileEnd(IntPtr L)
	{
		ToLua.Push(L, new EventObject(typeof(System.Action)));
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_OnChangeLocalResVer(IntPtr L)
	{
		ToLua.Push(L, new EventObject(typeof(System.Action<int>)));
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_OnGoLoginFileEnd(IntPtr L)
	{
		ToLua.Push(L, new EventObject(typeof(System.Action)));
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_OnReGoLogin(IntPtr L)
	{
		ToLua.Push(L, new EventObject(typeof(System.Action)));
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_OnEnterGame(IntPtr L)
	{
		ToLua.Push(L, new EventObject(typeof(System.Action)));
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_OnCheckVerStart(IntPtr L)
	{
		try
		{
			GameManager obj = (GameManager)ToLua.CheckObject(L, 1, typeof(GameManager));
			EventObject arg0 = null;

			if (LuaDLL.lua_isuserdata(L, 2) != 0)
			{
				arg0 = (EventObject)ToLua.ToObject(L, 2);
			}
			else
			{
				return LuaDLL.luaL_throw(L, "The event 'GameManager.OnCheckVerStart' can only appear on the left hand side of += or -= when used outside of the type 'GameManager'");
			}

			if (arg0.op == EventOp.Add)
			{
				System.Action ev = (System.Action)arg0.func;
				obj.OnCheckVerStart += ev;
			}
			else if (arg0.op == EventOp.Sub)
			{
				System.Action ev = (System.Action)arg0.func;
				obj.OnCheckVerStart -= ev;
			}

			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_OnCheckVerEnd(IntPtr L)
	{
		try
		{
			GameManager obj = (GameManager)ToLua.CheckObject(L, 1, typeof(GameManager));
			EventObject arg0 = null;

			if (LuaDLL.lua_isuserdata(L, 2) != 0)
			{
				arg0 = (EventObject)ToLua.ToObject(L, 2);
			}
			else
			{
				return LuaDLL.luaL_throw(L, "The event 'GameManager.OnCheckVerEnd' can only appear on the left hand side of += or -= when used outside of the type 'GameManager'");
			}

			if (arg0.op == EventOp.Add)
			{
				System.Action ev = (System.Action)arg0.func;
				obj.OnCheckVerEnd += ev;
			}
			else if (arg0.op == EventOp.Sub)
			{
				System.Action ev = (System.Action)arg0.func;
				obj.OnCheckVerEnd -= ev;
			}

			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_OnCheckVerFail(IntPtr L)
	{
		try
		{
			GameManager obj = (GameManager)ToLua.CheckObject(L, 1, typeof(GameManager));
			EventObject arg0 = null;

			if (LuaDLL.lua_isuserdata(L, 2) != 0)
			{
				arg0 = (EventObject)ToLua.ToObject(L, 2);
			}
			else
			{
				return LuaDLL.luaL_throw(L, "The event 'GameManager.OnCheckVerFail' can only appear on the left hand side of += or -= when used outside of the type 'GameManager'");
			}

			if (arg0.op == EventOp.Add)
			{
				System.Action ev = (System.Action)arg0.func;
				obj.OnCheckVerFail += ev;
			}
			else if (arg0.op == EventOp.Sub)
			{
				System.Action ev = (System.Action)arg0.func;
				obj.OnCheckVerFail -= ev;
			}

			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_OnBuildUpdate(IntPtr L)
	{
		try
		{
			GameManager obj = (GameManager)ToLua.CheckObject(L, 1, typeof(GameManager));
			EventObject arg0 = null;

			if (LuaDLL.lua_isuserdata(L, 2) != 0)
			{
				arg0 = (EventObject)ToLua.ToObject(L, 2);
			}
			else
			{
				return LuaDLL.luaL_throw(L, "The event 'GameManager.OnBuildUpdate' can only appear on the left hand side of += or -= when used outside of the type 'GameManager'");
			}

			if (arg0.op == EventOp.Add)
			{
				System.Action ev = (System.Action)arg0.func;
				obj.OnBuildUpdate += ev;
			}
			else if (arg0.op == EventOp.Sub)
			{
				System.Action ev = (System.Action)arg0.func;
				obj.OnBuildUpdate -= ev;
			}

			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_OnDecompressDirStart(IntPtr L)
	{
		try
		{
			GameManager obj = (GameManager)ToLua.CheckObject(L, 1, typeof(GameManager));
			EventObject arg0 = null;

			if (LuaDLL.lua_isuserdata(L, 2) != 0)
			{
				arg0 = (EventObject)ToLua.ToObject(L, 2);
			}
			else
			{
				return LuaDLL.luaL_throw(L, "The event 'GameManager.OnDecompressDirStart' can only appear on the left hand side of += or -= when used outside of the type 'GameManager'");
			}

			if (arg0.op == EventOp.Add)
			{
				System.Action ev = (System.Action)arg0.func;
				obj.OnDecompressDirStart += ev;
			}
			else if (arg0.op == EventOp.Sub)
			{
				System.Action ev = (System.Action)arg0.func;
				obj.OnDecompressDirStart -= ev;
			}

			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_OnDecompressDir(IntPtr L)
	{
		try
		{
			GameManager obj = (GameManager)ToLua.CheckObject(L, 1, typeof(GameManager));
			EventObject arg0 = null;

			if (LuaDLL.lua_isuserdata(L, 2) != 0)
			{
				arg0 = (EventObject)ToLua.ToObject(L, 2);
			}
			else
			{
				return LuaDLL.luaL_throw(L, "The event 'GameManager.OnDecompressDir' can only appear on the left hand side of += or -= when used outside of the type 'GameManager'");
			}

			if (arg0.op == EventOp.Add)
			{
				System.Action<string,float> ev = (System.Action<string,float>)arg0.func;
				obj.OnDecompressDir += ev;
			}
			else if (arg0.op == EventOp.Sub)
			{
				System.Action<string,float> ev = (System.Action<string,float>)arg0.func;
				obj.OnDecompressDir -= ev;
			}

			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_OnDecompressDirEnd(IntPtr L)
	{
		try
		{
			GameManager obj = (GameManager)ToLua.CheckObject(L, 1, typeof(GameManager));
			EventObject arg0 = null;

			if (LuaDLL.lua_isuserdata(L, 2) != 0)
			{
				arg0 = (EventObject)ToLua.ToObject(L, 2);
			}
			else
			{
				return LuaDLL.luaL_throw(L, "The event 'GameManager.OnDecompressDirEnd' can only appear on the left hand side of += or -= when used outside of the type 'GameManager'");
			}

			if (arg0.op == EventOp.Add)
			{
				System.Action ev = (System.Action)arg0.func;
				obj.OnDecompressDirEnd += ev;
			}
			else if (arg0.op == EventOp.Sub)
			{
				System.Action ev = (System.Action)arg0.func;
				obj.OnDecompressDirEnd -= ev;
			}

			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_OnGetVerFileStart(IntPtr L)
	{
		try
		{
			GameManager obj = (GameManager)ToLua.CheckObject(L, 1, typeof(GameManager));
			EventObject arg0 = null;

			if (LuaDLL.lua_isuserdata(L, 2) != 0)
			{
				arg0 = (EventObject)ToLua.ToObject(L, 2);
			}
			else
			{
				return LuaDLL.luaL_throw(L, "The event 'GameManager.OnGetVerFileStart' can only appear on the left hand side of += or -= when used outside of the type 'GameManager'");
			}

			if (arg0.op == EventOp.Add)
			{
				System.Action ev = (System.Action)arg0.func;
				obj.OnGetVerFileStart += ev;
			}
			else if (arg0.op == EventOp.Sub)
			{
				System.Action ev = (System.Action)arg0.func;
				obj.OnGetVerFileStart -= ev;
			}

			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_OnGetVerFileEnd(IntPtr L)
	{
		try
		{
			GameManager obj = (GameManager)ToLua.CheckObject(L, 1, typeof(GameManager));
			EventObject arg0 = null;

			if (LuaDLL.lua_isuserdata(L, 2) != 0)
			{
				arg0 = (EventObject)ToLua.ToObject(L, 2);
			}
			else
			{
				return LuaDLL.luaL_throw(L, "The event 'GameManager.OnGetVerFileEnd' can only appear on the left hand side of += or -= when used outside of the type 'GameManager'");
			}

			if (arg0.op == EventOp.Add)
			{
				System.Action ev = (System.Action)arg0.func;
				obj.OnGetVerFileEnd += ev;
			}
			else if (arg0.op == EventOp.Sub)
			{
				System.Action ev = (System.Action)arg0.func;
				obj.OnGetVerFileEnd -= ev;
			}

			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_OnCheckUpdateStart(IntPtr L)
	{
		try
		{
			GameManager obj = (GameManager)ToLua.CheckObject(L, 1, typeof(GameManager));
			EventObject arg0 = null;

			if (LuaDLL.lua_isuserdata(L, 2) != 0)
			{
				arg0 = (EventObject)ToLua.ToObject(L, 2);
			}
			else
			{
				return LuaDLL.luaL_throw(L, "The event 'GameManager.OnCheckUpdateStart' can only appear on the left hand side of += or -= when used outside of the type 'GameManager'");
			}

			if (arg0.op == EventOp.Add)
			{
				System.Action ev = (System.Action)arg0.func;
				obj.OnCheckUpdateStart += ev;
			}
			else if (arg0.op == EventOp.Sub)
			{
				System.Action ev = (System.Action)arg0.func;
				obj.OnCheckUpdateStart -= ev;
			}

			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_OnCheckUpdateFail(IntPtr L)
	{
		try
		{
			GameManager obj = (GameManager)ToLua.CheckObject(L, 1, typeof(GameManager));
			EventObject arg0 = null;

			if (LuaDLL.lua_isuserdata(L, 2) != 0)
			{
				arg0 = (EventObject)ToLua.ToObject(L, 2);
			}
			else
			{
				return LuaDLL.luaL_throw(L, "The event 'GameManager.OnCheckUpdateFail' can only appear on the left hand side of += or -= when used outside of the type 'GameManager'");
			}

			if (arg0.op == EventOp.Add)
			{
				System.Action ev = (System.Action)arg0.func;
				obj.OnCheckUpdateFail += ev;
			}
			else if (arg0.op == EventOp.Sub)
			{
				System.Action ev = (System.Action)arg0.func;
				obj.OnCheckUpdateFail -= ev;
			}

			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_OnCheckUpdateEnd(IntPtr L)
	{
		try
		{
			GameManager obj = (GameManager)ToLua.CheckObject(L, 1, typeof(GameManager));
			EventObject arg0 = null;

			if (LuaDLL.lua_isuserdata(L, 2) != 0)
			{
				arg0 = (EventObject)ToLua.ToObject(L, 2);
			}
			else
			{
				return LuaDLL.luaL_throw(L, "The event 'GameManager.OnCheckUpdateEnd' can only appear on the left hand side of += or -= when used outside of the type 'GameManager'");
			}

			if (arg0.op == EventOp.Add)
			{
				System.Action<float> ev = (System.Action<float>)arg0.func;
				obj.OnCheckUpdateEnd += ev;
			}
			else if (arg0.op == EventOp.Sub)
			{
				System.Action<float> ev = (System.Action<float>)arg0.func;
				obj.OnCheckUpdateEnd -= ev;
			}

			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_OnUpdateStart(IntPtr L)
	{
		try
		{
			GameManager obj = (GameManager)ToLua.CheckObject(L, 1, typeof(GameManager));
			EventObject arg0 = null;

			if (LuaDLL.lua_isuserdata(L, 2) != 0)
			{
				arg0 = (EventObject)ToLua.ToObject(L, 2);
			}
			else
			{
				return LuaDLL.luaL_throw(L, "The event 'GameManager.OnUpdateStart' can only appear on the left hand side of += or -= when used outside of the type 'GameManager'");
			}

			if (arg0.op == EventOp.Add)
			{
				System.Action ev = (System.Action)arg0.func;
				obj.OnUpdateStart += ev;
			}
			else if (arg0.op == EventOp.Sub)
			{
				System.Action ev = (System.Action)arg0.func;
				obj.OnUpdateStart -= ev;
			}

			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_OnUpdate(IntPtr L)
	{
		try
		{
			GameManager obj = (GameManager)ToLua.CheckObject(L, 1, typeof(GameManager));
			EventObject arg0 = null;

			if (LuaDLL.lua_isuserdata(L, 2) != 0)
			{
				arg0 = (EventObject)ToLua.ToObject(L, 2);
			}
			else
			{
				return LuaDLL.luaL_throw(L, "The event 'GameManager.OnUpdate' can only appear on the left hand side of += or -= when used outside of the type 'GameManager'");
			}

			if (arg0.op == EventOp.Add)
			{
				System.Action<float> ev = (System.Action<float>)arg0.func;
				obj.OnUpdate += ev;
			}
			else if (arg0.op == EventOp.Sub)
			{
				System.Action<float> ev = (System.Action<float>)arg0.func;
				obj.OnUpdate -= ev;
			}

			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_OnUpdateFail(IntPtr L)
	{
		try
		{
			GameManager obj = (GameManager)ToLua.CheckObject(L, 1, typeof(GameManager));
			EventObject arg0 = null;

			if (LuaDLL.lua_isuserdata(L, 2) != 0)
			{
				arg0 = (EventObject)ToLua.ToObject(L, 2);
			}
			else
			{
				return LuaDLL.luaL_throw(L, "The event 'GameManager.OnUpdateFail' can only appear on the left hand side of += or -= when used outside of the type 'GameManager'");
			}

			if (arg0.op == EventOp.Add)
			{
				System.Action<string> ev = (System.Action<string>)arg0.func;
				obj.OnUpdateFail += ev;
			}
			else if (arg0.op == EventOp.Sub)
			{
				System.Action<string> ev = (System.Action<string>)arg0.func;
				obj.OnUpdateFail -= ev;
			}

			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_OnUpdateEnd(IntPtr L)
	{
		try
		{
			GameManager obj = (GameManager)ToLua.CheckObject(L, 1, typeof(GameManager));
			EventObject arg0 = null;

			if (LuaDLL.lua_isuserdata(L, 2) != 0)
			{
				arg0 = (EventObject)ToLua.ToObject(L, 2);
			}
			else
			{
				return LuaDLL.luaL_throw(L, "The event 'GameManager.OnUpdateEnd' can only appear on the left hand side of += or -= when used outside of the type 'GameManager'");
			}

			if (arg0.op == EventOp.Add)
			{
				System.Action ev = (System.Action)arg0.func;
				obj.OnUpdateEnd += ev;
			}
			else if (arg0.op == EventOp.Sub)
			{
				System.Action ev = (System.Action)arg0.func;
				obj.OnUpdateEnd -= ev;
			}

			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_OnGetNewVerFileStart(IntPtr L)
	{
		try
		{
			GameManager obj = (GameManager)ToLua.CheckObject(L, 1, typeof(GameManager));
			EventObject arg0 = null;

			if (LuaDLL.lua_isuserdata(L, 2) != 0)
			{
				arg0 = (EventObject)ToLua.ToObject(L, 2);
			}
			else
			{
				return LuaDLL.luaL_throw(L, "The event 'GameManager.OnGetNewVerFileStart' can only appear on the left hand side of += or -= when used outside of the type 'GameManager'");
			}

			if (arg0.op == EventOp.Add)
			{
				System.Action ev = (System.Action)arg0.func;
				obj.OnGetNewVerFileStart += ev;
			}
			else if (arg0.op == EventOp.Sub)
			{
				System.Action ev = (System.Action)arg0.func;
				obj.OnGetNewVerFileStart -= ev;
			}

			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_OnGetNewVerFileFail(IntPtr L)
	{
		try
		{
			GameManager obj = (GameManager)ToLua.CheckObject(L, 1, typeof(GameManager));
			EventObject arg0 = null;

			if (LuaDLL.lua_isuserdata(L, 2) != 0)
			{
				arg0 = (EventObject)ToLua.ToObject(L, 2);
			}
			else
			{
				return LuaDLL.luaL_throw(L, "The event 'GameManager.OnGetNewVerFileFail' can only appear on the left hand side of += or -= when used outside of the type 'GameManager'");
			}

			if (arg0.op == EventOp.Add)
			{
				System.Action ev = (System.Action)arg0.func;
				obj.OnGetNewVerFileFail += ev;
			}
			else if (arg0.op == EventOp.Sub)
			{
				System.Action ev = (System.Action)arg0.func;
				obj.OnGetNewVerFileFail -= ev;
			}

			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_OnGetNewVerFileEnd(IntPtr L)
	{
		try
		{
			GameManager obj = (GameManager)ToLua.CheckObject(L, 1, typeof(GameManager));
			EventObject arg0 = null;

			if (LuaDLL.lua_isuserdata(L, 2) != 0)
			{
				arg0 = (EventObject)ToLua.ToObject(L, 2);
			}
			else
			{
				return LuaDLL.luaL_throw(L, "The event 'GameManager.OnGetNewVerFileEnd' can only appear on the left hand side of += or -= when used outside of the type 'GameManager'");
			}

			if (arg0.op == EventOp.Add)
			{
				System.Action ev = (System.Action)arg0.func;
				obj.OnGetNewVerFileEnd += ev;
			}
			else if (arg0.op == EventOp.Sub)
			{
				System.Action ev = (System.Action)arg0.func;
				obj.OnGetNewVerFileEnd -= ev;
			}

			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_OnChangeLocalResVer(IntPtr L)
	{
		try
		{
			GameManager obj = (GameManager)ToLua.CheckObject(L, 1, typeof(GameManager));
			EventObject arg0 = null;

			if (LuaDLL.lua_isuserdata(L, 2) != 0)
			{
				arg0 = (EventObject)ToLua.ToObject(L, 2);
			}
			else
			{
				return LuaDLL.luaL_throw(L, "The event 'GameManager.OnChangeLocalResVer' can only appear on the left hand side of += or -= when used outside of the type 'GameManager'");
			}

			if (arg0.op == EventOp.Add)
			{
				System.Action<int> ev = (System.Action<int>)arg0.func;
				obj.OnChangeLocalResVer += ev;
			}
			else if (arg0.op == EventOp.Sub)
			{
				System.Action<int> ev = (System.Action<int>)arg0.func;
				obj.OnChangeLocalResVer -= ev;
			}

			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_OnGoLoginFileEnd(IntPtr L)
	{
		try
		{
			GameManager obj = (GameManager)ToLua.CheckObject(L, 1, typeof(GameManager));
			EventObject arg0 = null;

			if (LuaDLL.lua_isuserdata(L, 2) != 0)
			{
				arg0 = (EventObject)ToLua.ToObject(L, 2);
			}
			else
			{
				return LuaDLL.luaL_throw(L, "The event 'GameManager.OnGoLoginFileEnd' can only appear on the left hand side of += or -= when used outside of the type 'GameManager'");
			}

			if (arg0.op == EventOp.Add)
			{
				System.Action ev = (System.Action)arg0.func;
				obj.OnGoLoginFileEnd += ev;
			}
			else if (arg0.op == EventOp.Sub)
			{
				System.Action ev = (System.Action)arg0.func;
				obj.OnGoLoginFileEnd -= ev;
			}

			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_OnReGoLogin(IntPtr L)
	{
		try
		{
			GameManager obj = (GameManager)ToLua.CheckObject(L, 1, typeof(GameManager));
			EventObject arg0 = null;

			if (LuaDLL.lua_isuserdata(L, 2) != 0)
			{
				arg0 = (EventObject)ToLua.ToObject(L, 2);
			}
			else
			{
				return LuaDLL.luaL_throw(L, "The event 'GameManager.OnReGoLogin' can only appear on the left hand side of += or -= when used outside of the type 'GameManager'");
			}

			if (arg0.op == EventOp.Add)
			{
				System.Action ev = (System.Action)arg0.func;
				obj.OnReGoLogin += ev;
			}
			else if (arg0.op == EventOp.Sub)
			{
				System.Action ev = (System.Action)arg0.func;
				obj.OnReGoLogin -= ev;
			}

			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_OnEnterGame(IntPtr L)
	{
		try
		{
			GameManager obj = (GameManager)ToLua.CheckObject(L, 1, typeof(GameManager));
			EventObject arg0 = null;

			if (LuaDLL.lua_isuserdata(L, 2) != 0)
			{
				arg0 = (EventObject)ToLua.ToObject(L, 2);
			}
			else
			{
				return LuaDLL.luaL_throw(L, "The event 'GameManager.OnEnterGame' can only appear on the left hand side of += or -= when used outside of the type 'GameManager'");
			}

			if (arg0.op == EventOp.Add)
			{
				System.Action ev = (System.Action)arg0.func;
				obj.OnEnterGame += ev;
			}
			else if (arg0.op == EventOp.Sub)
			{
				System.Action ev = (System.Action)arg0.func;
				obj.OnEnterGame -= ev;
			}

			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}
