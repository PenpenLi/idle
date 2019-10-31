﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class platform_config_commonWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(platform_config_common), typeof(System.Object));
		L.RegFunction("New", _Createplatform_config_common);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegConstant("Version", 1);
		L.RegVar("ResVersion", get_ResVersion, set_ResVersion);
		L.RegVar("DebugMode", get_DebugMode, set_DebugMode);
		L.RegVar("UpdateMode", get_UpdateMode, set_UpdateMode);
		L.RegConstant("GameFrameRate", 60);
		L.RegVar("AppName", get_AppName, null);
		L.RegVar("LuaTempDir", get_LuaTempDir, null);
		L.RegVar("ExtName", get_ExtName, null);
		L.RegVar("AssetDir", get_AssetDir, null);
		L.RegVar("test", get_test, set_test);
		L.RegVar("platform", get_platform, set_platform);
		L.RegVar("oss_url", get_oss_url, set_oss_url);
		L.RegVar("third_login", get_third_login, set_third_login);
		L.RegVar("lang", get_lang, set_lang);
		L.RegVar("hostIp", get_hostIp, set_hostIp);
		L.RegVar("updateBuildUrl", get_updateBuildUrl, set_updateBuildUrl);
		L.RegVar("updateResUrl", get_updateResUrl, set_updateResUrl);
		L.RegVar("LuaFrameworkRoot", get_LuaFrameworkRoot, null);
		L.RegVar("login_url", get_login_url, null);
		L.RegVar("storage_url", get_storage_url, null);
		L.RegVar("libao_url", get_libao_url, null);
		L.RegVar("pay_url", get_pay_url, null);
		L.RegVar("exception_url", get_exception_url, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _Createplatform_config_common(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				platform_config_common obj = new platform_config_common();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: platform_config_common.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_ResVersion(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, platform_config_common.ResVersion);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_DebugMode(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, platform_config_common.DebugMode);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_UpdateMode(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, platform_config_common.UpdateMode);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_AppName(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, platform_config_common.AppName);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_LuaTempDir(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, platform_config_common.LuaTempDir);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_ExtName(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, platform_config_common.ExtName);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_AssetDir(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, platform_config_common.AssetDir);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_test(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, platform_config_common.test);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_platform(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, platform_config_common.platform);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_oss_url(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, platform_config_common.oss_url);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_third_login(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, platform_config_common.third_login);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_lang(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, platform_config_common.lang);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_hostIp(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, platform_config_common.hostIp);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_updateBuildUrl(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, platform_config_common.updateBuildUrl);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_updateResUrl(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, platform_config_common.updateResUrl);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_LuaFrameworkRoot(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, platform_config_common.LuaFrameworkRoot);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_login_url(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, platform_config_common.login_url);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_storage_url(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, platform_config_common.storage_url);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_libao_url(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, platform_config_common.libao_url);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_pay_url(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, platform_config_common.pay_url);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_exception_url(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, platform_config_common.exception_url);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_ResVersion(IntPtr L)
	{
		try
		{
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			platform_config_common.ResVersion = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_DebugMode(IntPtr L)
	{
		try
		{
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			platform_config_common.DebugMode = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_UpdateMode(IntPtr L)
	{
		try
		{
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			platform_config_common.UpdateMode = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_test(IntPtr L)
	{
		try
		{
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			platform_config_common.test = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_platform(IntPtr L)
	{
		try
		{
			string arg0 = ToLua.CheckString(L, 2);
			platform_config_common.platform = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_oss_url(IntPtr L)
	{
		try
		{
			string arg0 = ToLua.CheckString(L, 2);
			platform_config_common.oss_url = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_third_login(IntPtr L)
	{
		try
		{
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			platform_config_common.third_login = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_lang(IntPtr L)
	{
		try
		{
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			platform_config_common.lang = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_hostIp(IntPtr L)
	{
		try
		{
			string arg0 = ToLua.CheckString(L, 2);
			platform_config_common.hostIp = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_updateBuildUrl(IntPtr L)
	{
		try
		{
			string arg0 = ToLua.CheckString(L, 2);
			platform_config_common.updateBuildUrl = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_updateResUrl(IntPtr L)
	{
		try
		{
			string arg0 = ToLua.CheckString(L, 2);
			platform_config_common.updateResUrl = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}
