﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class System_Xml_Linq_XAttributeWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(System.Xml.Linq.XAttribute), typeof(System.Xml.Linq.XObject));
		L.RegFunction("Remove", Remove);
		L.RegFunction("SetValue", SetValue);
		L.RegFunction("ToString", ToString);
		L.RegFunction("New", _CreateSystem_Xml_Linq_XAttribute);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("EmptySequence", get_EmptySequence, null);
		L.RegVar("IsNamespaceDeclaration", get_IsNamespaceDeclaration, null);
		L.RegVar("Name", get_Name, null);
		L.RegVar("NextAttribute", get_NextAttribute, null);
		L.RegVar("NodeType", get_NodeType, null);
		L.RegVar("PreviousAttribute", get_PreviousAttribute, null);
		L.RegVar("Value", get_Value, set_Value);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateSystem_Xml_Linq_XAttribute(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				System.Xml.Linq.XAttribute arg0 = (System.Xml.Linq.XAttribute)ToLua.CheckObject<System.Xml.Linq.XAttribute>(L, 1);
				System.Xml.Linq.XAttribute obj = new System.Xml.Linq.XAttribute(arg0);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else if (count == 2)
			{
				System.Xml.Linq.XName arg0 = (System.Xml.Linq.XName)ToLua.CheckObject(L, 1, typeof(System.Xml.Linq.XName));
				object arg1 = ToLua.ToVarObject(L, 2);
				System.Xml.Linq.XAttribute obj = new System.Xml.Linq.XAttribute(arg0, arg1);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: System.Xml.Linq.XAttribute.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Remove(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			System.Xml.Linq.XAttribute obj = (System.Xml.Linq.XAttribute)ToLua.CheckObject<System.Xml.Linq.XAttribute>(L, 1);
			obj.Remove();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetValue(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			System.Xml.Linq.XAttribute obj = (System.Xml.Linq.XAttribute)ToLua.CheckObject<System.Xml.Linq.XAttribute>(L, 1);
			object arg0 = ToLua.ToVarObject(L, 2);
			obj.SetValue(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ToString(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			System.Xml.Linq.XAttribute obj = (System.Xml.Linq.XAttribute)ToLua.CheckObject<System.Xml.Linq.XAttribute>(L, 1);
			string o = obj.ToString();
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_EmptySequence(IntPtr L)
	{
		try
		{
			ToLua.PushObject(L, System.Xml.Linq.XAttribute.EmptySequence);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_IsNamespaceDeclaration(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Xml.Linq.XAttribute obj = (System.Xml.Linq.XAttribute)o;
			bool ret = obj.IsNamespaceDeclaration;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index IsNamespaceDeclaration on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Name(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Xml.Linq.XAttribute obj = (System.Xml.Linq.XAttribute)o;
			System.Xml.Linq.XName ret = obj.Name;
			ToLua.PushSealed(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Name on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_NextAttribute(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Xml.Linq.XAttribute obj = (System.Xml.Linq.XAttribute)o;
			System.Xml.Linq.XAttribute ret = obj.NextAttribute;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index NextAttribute on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_NodeType(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Xml.Linq.XAttribute obj = (System.Xml.Linq.XAttribute)o;
			System.Xml.XmlNodeType ret = obj.NodeType;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index NodeType on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_PreviousAttribute(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Xml.Linq.XAttribute obj = (System.Xml.Linq.XAttribute)o;
			System.Xml.Linq.XAttribute ret = obj.PreviousAttribute;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index PreviousAttribute on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Value(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Xml.Linq.XAttribute obj = (System.Xml.Linq.XAttribute)o;
			string ret = obj.Value;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Value on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Value(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Xml.Linq.XAttribute obj = (System.Xml.Linq.XAttribute)o;
			string arg0 = ToLua.CheckString(L, 2);
			obj.Value = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Value on a nil value");
		}
	}
}

