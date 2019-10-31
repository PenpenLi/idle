﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class System_Collections_Generic_List_System_Xml_Linq_XElementWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(System.Collections.Generic.List<System.Xml.Linq.XElement>), typeof(System.Object), "List_System_Xml_Linq_XElement");
		L.RegFunction(".geti", get_Item);
		L.RegFunction("get_Item", get_Item);
		L.RegFunction(".seti", set_Item);
		L.RegFunction("set_Item", set_Item);
		L.RegFunction("Add", Add);
		L.RegFunction("AddRange", AddRange);
		L.RegFunction("AsReadOnly", AsReadOnly);
		L.RegFunction("BinarySearch", BinarySearch);
		L.RegFunction("Clear", Clear);
		L.RegFunction("Contains", Contains);
		L.RegFunction("CopyTo", CopyTo);
		L.RegFunction("Exists", Exists);
		L.RegFunction("Find", Find);
		L.RegFunction("FindAll", FindAll);
		L.RegFunction("FindIndex", FindIndex);
		L.RegFunction("FindLast", FindLast);
		L.RegFunction("FindLastIndex", FindLastIndex);
		L.RegFunction("ForEach", ForEach);
		L.RegFunction("GetEnumerator", GetEnumerator);
		L.RegFunction("GetRange", GetRange);
		L.RegFunction("IndexOf", IndexOf);
		L.RegFunction("Insert", Insert);
		L.RegFunction("InsertRange", InsertRange);
		L.RegFunction("LastIndexOf", LastIndexOf);
		L.RegFunction("Remove", Remove);
		L.RegFunction("RemoveAll", RemoveAll);
		L.RegFunction("RemoveAt", RemoveAt);
		L.RegFunction("RemoveRange", RemoveRange);
		L.RegFunction("Reverse", Reverse);
		L.RegFunction("Sort", Sort);
		L.RegFunction("ToArray", ToArray);
		L.RegFunction("TrimExcess", TrimExcess);
		L.RegFunction("TrueForAll", TrueForAll);
		L.RegFunction("New", _CreateSystem_Collections_Generic_List_System_Xml_Linq_XElement);
		L.RegVar("this", _this, null);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("Capacity", get_Capacity, set_Capacity);
		L.RegVar("Count", get_Count, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateSystem_Collections_Generic_List_System_Xml_Linq_XElement(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				System.Collections.Generic.List<System.Xml.Linq.XElement> obj = new System.Collections.Generic.List<System.Xml.Linq.XElement>();
				ToLua.PushSealed(L, obj);
				return 1;
			}
			else if (count == 1 && TypeChecker.CheckTypes<int>(L, 1))
			{
				int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
				System.Collections.Generic.List<System.Xml.Linq.XElement> obj = new System.Collections.Generic.List<System.Xml.Linq.XElement>(arg0);
				ToLua.PushSealed(L, obj);
				return 1;
			}
			else if (count == 1 && TypeChecker.CheckTypes<System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>>(L, 1))
			{
				System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> arg0 = (System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>)ToLua.ToObject(L, 1);
				System.Collections.Generic.List<System.Xml.Linq.XElement> obj = new System.Collections.Generic.List<System.Xml.Linq.XElement>(arg0);
				ToLua.PushSealed(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: System.Collections.Generic.List<System.Xml.Linq.XElement>.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _get_this(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			System.Collections.Generic.List<System.Xml.Linq.XElement> obj = (System.Collections.Generic.List<System.Xml.Linq.XElement>)ToLua.CheckObject(L, 1, typeof(System.Collections.Generic.List<System.Xml.Linq.XElement>));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			System.Xml.Linq.XElement o = obj[arg0];
			ToLua.PushObject(L, o);
			return 1;

		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _set_this(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			System.Collections.Generic.List<System.Xml.Linq.XElement> obj = (System.Collections.Generic.List<System.Xml.Linq.XElement>)ToLua.CheckObject(L, 1, typeof(System.Collections.Generic.List<System.Xml.Linq.XElement>));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			System.Xml.Linq.XElement arg1 = (System.Xml.Linq.XElement)ToLua.CheckObject<System.Xml.Linq.XElement>(L, 3);
			obj[arg0] = arg1;
			return 0;

		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _this(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushvalue(L, 1);
			LuaDLL.tolua_bindthis(L, _get_this, _set_this);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Item(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			System.Collections.Generic.List<System.Xml.Linq.XElement> obj = (System.Collections.Generic.List<System.Xml.Linq.XElement>)ToLua.CheckObject(L, 1, typeof(System.Collections.Generic.List<System.Xml.Linq.XElement>));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			System.Xml.Linq.XElement o = obj[arg0];
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Item(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			System.Collections.Generic.List<System.Xml.Linq.XElement> obj = (System.Collections.Generic.List<System.Xml.Linq.XElement>)ToLua.CheckObject(L, 1, typeof(System.Collections.Generic.List<System.Xml.Linq.XElement>));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			System.Xml.Linq.XElement arg1 = (System.Xml.Linq.XElement)ToLua.CheckObject<System.Xml.Linq.XElement>(L, 3);
			obj[arg0] = arg1;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Add(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			System.Collections.Generic.List<System.Xml.Linq.XElement> obj = (System.Collections.Generic.List<System.Xml.Linq.XElement>)ToLua.CheckObject(L, 1, typeof(System.Collections.Generic.List<System.Xml.Linq.XElement>));
			System.Xml.Linq.XElement arg0 = (System.Xml.Linq.XElement)ToLua.CheckObject<System.Xml.Linq.XElement>(L, 2);
			obj.Add(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddRange(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			System.Collections.Generic.List<System.Xml.Linq.XElement> obj = (System.Collections.Generic.List<System.Xml.Linq.XElement>)ToLua.CheckObject(L, 1, typeof(System.Collections.Generic.List<System.Xml.Linq.XElement>));
			System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> arg0 = (System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>)ToLua.CheckObject<System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>>(L, 2);
			obj.AddRange(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AsReadOnly(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			System.Collections.Generic.List<System.Xml.Linq.XElement> obj = (System.Collections.Generic.List<System.Xml.Linq.XElement>)ToLua.CheckObject(L, 1, typeof(System.Collections.Generic.List<System.Xml.Linq.XElement>));
			System.Collections.ObjectModel.ReadOnlyCollection<System.Xml.Linq.XElement> o = obj.AsReadOnly();
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int BinarySearch(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				System.Collections.Generic.List<System.Xml.Linq.XElement> obj = (System.Collections.Generic.List<System.Xml.Linq.XElement>)ToLua.CheckObject(L, 1, typeof(System.Collections.Generic.List<System.Xml.Linq.XElement>));
				System.Xml.Linq.XElement arg0 = (System.Xml.Linq.XElement)ToLua.CheckObject<System.Xml.Linq.XElement>(L, 2);
				int o = obj.BinarySearch(arg0);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (count == 3)
			{
				System.Collections.Generic.List<System.Xml.Linq.XElement> obj = (System.Collections.Generic.List<System.Xml.Linq.XElement>)ToLua.CheckObject(L, 1, typeof(System.Collections.Generic.List<System.Xml.Linq.XElement>));
				System.Xml.Linq.XElement arg0 = (System.Xml.Linq.XElement)ToLua.CheckObject<System.Xml.Linq.XElement>(L, 2);
				System.Collections.Generic.IComparer<System.Xml.Linq.XElement> arg1 = (System.Collections.Generic.IComparer<System.Xml.Linq.XElement>)ToLua.CheckObject<System.Collections.Generic.IComparer<System.Xml.Linq.XElement>>(L, 3);
				int o = obj.BinarySearch(arg0, arg1);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (count == 5)
			{
				System.Collections.Generic.List<System.Xml.Linq.XElement> obj = (System.Collections.Generic.List<System.Xml.Linq.XElement>)ToLua.CheckObject(L, 1, typeof(System.Collections.Generic.List<System.Xml.Linq.XElement>));
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
				int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
				System.Xml.Linq.XElement arg2 = (System.Xml.Linq.XElement)ToLua.CheckObject<System.Xml.Linq.XElement>(L, 4);
				System.Collections.Generic.IComparer<System.Xml.Linq.XElement> arg3 = (System.Collections.Generic.IComparer<System.Xml.Linq.XElement>)ToLua.CheckObject<System.Collections.Generic.IComparer<System.Xml.Linq.XElement>>(L, 5);
				int o = obj.BinarySearch(arg0, arg1, arg2, arg3);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: System.Collections.Generic.List<System.Xml.Linq.XElement>.BinarySearch");
			}
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
			System.Collections.Generic.List<System.Xml.Linq.XElement> obj = (System.Collections.Generic.List<System.Xml.Linq.XElement>)ToLua.CheckObject(L, 1, typeof(System.Collections.Generic.List<System.Xml.Linq.XElement>));
			obj.Clear();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Contains(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			System.Collections.Generic.List<System.Xml.Linq.XElement> obj = (System.Collections.Generic.List<System.Xml.Linq.XElement>)ToLua.CheckObject(L, 1, typeof(System.Collections.Generic.List<System.Xml.Linq.XElement>));
			System.Xml.Linq.XElement arg0 = (System.Xml.Linq.XElement)ToLua.CheckObject<System.Xml.Linq.XElement>(L, 2);
			bool o = obj.Contains(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CopyTo(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				System.Collections.Generic.List<System.Xml.Linq.XElement> obj = (System.Collections.Generic.List<System.Xml.Linq.XElement>)ToLua.CheckObject(L, 1, typeof(System.Collections.Generic.List<System.Xml.Linq.XElement>));
				System.Xml.Linq.XElement[] arg0 = ToLua.CheckObjectArray<System.Xml.Linq.XElement>(L, 2);
				obj.CopyTo(arg0);
				return 0;
			}
			else if (count == 3)
			{
				System.Collections.Generic.List<System.Xml.Linq.XElement> obj = (System.Collections.Generic.List<System.Xml.Linq.XElement>)ToLua.CheckObject(L, 1, typeof(System.Collections.Generic.List<System.Xml.Linq.XElement>));
				System.Xml.Linq.XElement[] arg0 = ToLua.CheckObjectArray<System.Xml.Linq.XElement>(L, 2);
				int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
				obj.CopyTo(arg0, arg1);
				return 0;
			}
			else if (count == 5)
			{
				System.Collections.Generic.List<System.Xml.Linq.XElement> obj = (System.Collections.Generic.List<System.Xml.Linq.XElement>)ToLua.CheckObject(L, 1, typeof(System.Collections.Generic.List<System.Xml.Linq.XElement>));
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
				System.Xml.Linq.XElement[] arg1 = ToLua.CheckObjectArray<System.Xml.Linq.XElement>(L, 3);
				int arg2 = (int)LuaDLL.luaL_checknumber(L, 4);
				int arg3 = (int)LuaDLL.luaL_checknumber(L, 5);
				obj.CopyTo(arg0, arg1, arg2, arg3);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: System.Collections.Generic.List<System.Xml.Linq.XElement>.CopyTo");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Exists(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			System.Collections.Generic.List<System.Xml.Linq.XElement> obj = (System.Collections.Generic.List<System.Xml.Linq.XElement>)ToLua.CheckObject(L, 1, typeof(System.Collections.Generic.List<System.Xml.Linq.XElement>));
			System.Predicate<System.Xml.Linq.XElement> arg0 = (System.Predicate<System.Xml.Linq.XElement>)ToLua.CheckDelegate<System.Predicate<System.Xml.Linq.XElement>>(L, 2);
			bool o = obj.Exists(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Find(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			System.Collections.Generic.List<System.Xml.Linq.XElement> obj = (System.Collections.Generic.List<System.Xml.Linq.XElement>)ToLua.CheckObject(L, 1, typeof(System.Collections.Generic.List<System.Xml.Linq.XElement>));
			System.Predicate<System.Xml.Linq.XElement> arg0 = (System.Predicate<System.Xml.Linq.XElement>)ToLua.CheckDelegate<System.Predicate<System.Xml.Linq.XElement>>(L, 2);
			System.Xml.Linq.XElement o = obj.Find(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FindAll(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			System.Collections.Generic.List<System.Xml.Linq.XElement> obj = (System.Collections.Generic.List<System.Xml.Linq.XElement>)ToLua.CheckObject(L, 1, typeof(System.Collections.Generic.List<System.Xml.Linq.XElement>));
			System.Predicate<System.Xml.Linq.XElement> arg0 = (System.Predicate<System.Xml.Linq.XElement>)ToLua.CheckDelegate<System.Predicate<System.Xml.Linq.XElement>>(L, 2);
			System.Collections.Generic.List<System.Xml.Linq.XElement> o = obj.FindAll(arg0);
			ToLua.PushSealed(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FindIndex(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				System.Collections.Generic.List<System.Xml.Linq.XElement> obj = (System.Collections.Generic.List<System.Xml.Linq.XElement>)ToLua.CheckObject(L, 1, typeof(System.Collections.Generic.List<System.Xml.Linq.XElement>));
				System.Predicate<System.Xml.Linq.XElement> arg0 = (System.Predicate<System.Xml.Linq.XElement>)ToLua.CheckDelegate<System.Predicate<System.Xml.Linq.XElement>>(L, 2);
				int o = obj.FindIndex(arg0);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (count == 3)
			{
				System.Collections.Generic.List<System.Xml.Linq.XElement> obj = (System.Collections.Generic.List<System.Xml.Linq.XElement>)ToLua.CheckObject(L, 1, typeof(System.Collections.Generic.List<System.Xml.Linq.XElement>));
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
				System.Predicate<System.Xml.Linq.XElement> arg1 = (System.Predicate<System.Xml.Linq.XElement>)ToLua.CheckDelegate<System.Predicate<System.Xml.Linq.XElement>>(L, 3);
				int o = obj.FindIndex(arg0, arg1);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (count == 4)
			{
				System.Collections.Generic.List<System.Xml.Linq.XElement> obj = (System.Collections.Generic.List<System.Xml.Linq.XElement>)ToLua.CheckObject(L, 1, typeof(System.Collections.Generic.List<System.Xml.Linq.XElement>));
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
				int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
				System.Predicate<System.Xml.Linq.XElement> arg2 = (System.Predicate<System.Xml.Linq.XElement>)ToLua.CheckDelegate<System.Predicate<System.Xml.Linq.XElement>>(L, 4);
				int o = obj.FindIndex(arg0, arg1, arg2);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: System.Collections.Generic.List<System.Xml.Linq.XElement>.FindIndex");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FindLast(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			System.Collections.Generic.List<System.Xml.Linq.XElement> obj = (System.Collections.Generic.List<System.Xml.Linq.XElement>)ToLua.CheckObject(L, 1, typeof(System.Collections.Generic.List<System.Xml.Linq.XElement>));
			System.Predicate<System.Xml.Linq.XElement> arg0 = (System.Predicate<System.Xml.Linq.XElement>)ToLua.CheckDelegate<System.Predicate<System.Xml.Linq.XElement>>(L, 2);
			System.Xml.Linq.XElement o = obj.FindLast(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FindLastIndex(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				System.Collections.Generic.List<System.Xml.Linq.XElement> obj = (System.Collections.Generic.List<System.Xml.Linq.XElement>)ToLua.CheckObject(L, 1, typeof(System.Collections.Generic.List<System.Xml.Linq.XElement>));
				System.Predicate<System.Xml.Linq.XElement> arg0 = (System.Predicate<System.Xml.Linq.XElement>)ToLua.CheckDelegate<System.Predicate<System.Xml.Linq.XElement>>(L, 2);
				int o = obj.FindLastIndex(arg0);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (count == 3)
			{
				System.Collections.Generic.List<System.Xml.Linq.XElement> obj = (System.Collections.Generic.List<System.Xml.Linq.XElement>)ToLua.CheckObject(L, 1, typeof(System.Collections.Generic.List<System.Xml.Linq.XElement>));
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
				System.Predicate<System.Xml.Linq.XElement> arg1 = (System.Predicate<System.Xml.Linq.XElement>)ToLua.CheckDelegate<System.Predicate<System.Xml.Linq.XElement>>(L, 3);
				int o = obj.FindLastIndex(arg0, arg1);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (count == 4)
			{
				System.Collections.Generic.List<System.Xml.Linq.XElement> obj = (System.Collections.Generic.List<System.Xml.Linq.XElement>)ToLua.CheckObject(L, 1, typeof(System.Collections.Generic.List<System.Xml.Linq.XElement>));
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
				int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
				System.Predicate<System.Xml.Linq.XElement> arg2 = (System.Predicate<System.Xml.Linq.XElement>)ToLua.CheckDelegate<System.Predicate<System.Xml.Linq.XElement>>(L, 4);
				int o = obj.FindLastIndex(arg0, arg1, arg2);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: System.Collections.Generic.List<System.Xml.Linq.XElement>.FindLastIndex");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ForEach(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			System.Collections.Generic.List<System.Xml.Linq.XElement> obj = (System.Collections.Generic.List<System.Xml.Linq.XElement>)ToLua.CheckObject(L, 1, typeof(System.Collections.Generic.List<System.Xml.Linq.XElement>));
			System.Action<System.Xml.Linq.XElement> arg0 = (System.Action<System.Xml.Linq.XElement>)ToLua.CheckDelegate<System.Action<System.Xml.Linq.XElement>>(L, 2);
			obj.ForEach(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetEnumerator(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			System.Collections.Generic.List<System.Xml.Linq.XElement> obj = (System.Collections.Generic.List<System.Xml.Linq.XElement>)ToLua.CheckObject(L, 1, typeof(System.Collections.Generic.List<System.Xml.Linq.XElement>));
			System.Collections.IEnumerator o = obj.GetEnumerator();
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRange(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			System.Collections.Generic.List<System.Xml.Linq.XElement> obj = (System.Collections.Generic.List<System.Xml.Linq.XElement>)ToLua.CheckObject(L, 1, typeof(System.Collections.Generic.List<System.Xml.Linq.XElement>));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
			System.Collections.Generic.List<System.Xml.Linq.XElement> o = obj.GetRange(arg0, arg1);
			ToLua.PushSealed(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IndexOf(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				System.Collections.Generic.List<System.Xml.Linq.XElement> obj = (System.Collections.Generic.List<System.Xml.Linq.XElement>)ToLua.CheckObject(L, 1, typeof(System.Collections.Generic.List<System.Xml.Linq.XElement>));
				System.Xml.Linq.XElement arg0 = (System.Xml.Linq.XElement)ToLua.CheckObject<System.Xml.Linq.XElement>(L, 2);
				int o = obj.IndexOf(arg0);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (count == 3)
			{
				System.Collections.Generic.List<System.Xml.Linq.XElement> obj = (System.Collections.Generic.List<System.Xml.Linq.XElement>)ToLua.CheckObject(L, 1, typeof(System.Collections.Generic.List<System.Xml.Linq.XElement>));
				System.Xml.Linq.XElement arg0 = (System.Xml.Linq.XElement)ToLua.CheckObject<System.Xml.Linq.XElement>(L, 2);
				int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
				int o = obj.IndexOf(arg0, arg1);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (count == 4)
			{
				System.Collections.Generic.List<System.Xml.Linq.XElement> obj = (System.Collections.Generic.List<System.Xml.Linq.XElement>)ToLua.CheckObject(L, 1, typeof(System.Collections.Generic.List<System.Xml.Linq.XElement>));
				System.Xml.Linq.XElement arg0 = (System.Xml.Linq.XElement)ToLua.CheckObject<System.Xml.Linq.XElement>(L, 2);
				int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
				int arg2 = (int)LuaDLL.luaL_checknumber(L, 4);
				int o = obj.IndexOf(arg0, arg1, arg2);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: System.Collections.Generic.List<System.Xml.Linq.XElement>.IndexOf");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Insert(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			System.Collections.Generic.List<System.Xml.Linq.XElement> obj = (System.Collections.Generic.List<System.Xml.Linq.XElement>)ToLua.CheckObject(L, 1, typeof(System.Collections.Generic.List<System.Xml.Linq.XElement>));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			System.Xml.Linq.XElement arg1 = (System.Xml.Linq.XElement)ToLua.CheckObject<System.Xml.Linq.XElement>(L, 3);
			obj.Insert(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int InsertRange(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			System.Collections.Generic.List<System.Xml.Linq.XElement> obj = (System.Collections.Generic.List<System.Xml.Linq.XElement>)ToLua.CheckObject(L, 1, typeof(System.Collections.Generic.List<System.Xml.Linq.XElement>));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> arg1 = (System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>)ToLua.CheckObject<System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>>(L, 3);
			obj.InsertRange(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LastIndexOf(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				System.Collections.Generic.List<System.Xml.Linq.XElement> obj = (System.Collections.Generic.List<System.Xml.Linq.XElement>)ToLua.CheckObject(L, 1, typeof(System.Collections.Generic.List<System.Xml.Linq.XElement>));
				System.Xml.Linq.XElement arg0 = (System.Xml.Linq.XElement)ToLua.CheckObject<System.Xml.Linq.XElement>(L, 2);
				int o = obj.LastIndexOf(arg0);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (count == 3)
			{
				System.Collections.Generic.List<System.Xml.Linq.XElement> obj = (System.Collections.Generic.List<System.Xml.Linq.XElement>)ToLua.CheckObject(L, 1, typeof(System.Collections.Generic.List<System.Xml.Linq.XElement>));
				System.Xml.Linq.XElement arg0 = (System.Xml.Linq.XElement)ToLua.CheckObject<System.Xml.Linq.XElement>(L, 2);
				int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
				int o = obj.LastIndexOf(arg0, arg1);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (count == 4)
			{
				System.Collections.Generic.List<System.Xml.Linq.XElement> obj = (System.Collections.Generic.List<System.Xml.Linq.XElement>)ToLua.CheckObject(L, 1, typeof(System.Collections.Generic.List<System.Xml.Linq.XElement>));
				System.Xml.Linq.XElement arg0 = (System.Xml.Linq.XElement)ToLua.CheckObject<System.Xml.Linq.XElement>(L, 2);
				int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
				int arg2 = (int)LuaDLL.luaL_checknumber(L, 4);
				int o = obj.LastIndexOf(arg0, arg1, arg2);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: System.Collections.Generic.List<System.Xml.Linq.XElement>.LastIndexOf");
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
			ToLua.CheckArgsCount(L, 2);
			System.Collections.Generic.List<System.Xml.Linq.XElement> obj = (System.Collections.Generic.List<System.Xml.Linq.XElement>)ToLua.CheckObject(L, 1, typeof(System.Collections.Generic.List<System.Xml.Linq.XElement>));
			System.Xml.Linq.XElement arg0 = (System.Xml.Linq.XElement)ToLua.CheckObject<System.Xml.Linq.XElement>(L, 2);
			bool o = obj.Remove(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveAll(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			System.Collections.Generic.List<System.Xml.Linq.XElement> obj = (System.Collections.Generic.List<System.Xml.Linq.XElement>)ToLua.CheckObject(L, 1, typeof(System.Collections.Generic.List<System.Xml.Linq.XElement>));
			System.Predicate<System.Xml.Linq.XElement> arg0 = (System.Predicate<System.Xml.Linq.XElement>)ToLua.CheckDelegate<System.Predicate<System.Xml.Linq.XElement>>(L, 2);
			int o = obj.RemoveAll(arg0);
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveAt(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			System.Collections.Generic.List<System.Xml.Linq.XElement> obj = (System.Collections.Generic.List<System.Xml.Linq.XElement>)ToLua.CheckObject(L, 1, typeof(System.Collections.Generic.List<System.Xml.Linq.XElement>));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.RemoveAt(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveRange(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			System.Collections.Generic.List<System.Xml.Linq.XElement> obj = (System.Collections.Generic.List<System.Xml.Linq.XElement>)ToLua.CheckObject(L, 1, typeof(System.Collections.Generic.List<System.Xml.Linq.XElement>));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
			obj.RemoveRange(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Reverse(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				System.Collections.Generic.List<System.Xml.Linq.XElement> obj = (System.Collections.Generic.List<System.Xml.Linq.XElement>)ToLua.CheckObject(L, 1, typeof(System.Collections.Generic.List<System.Xml.Linq.XElement>));
				obj.Reverse();
				return 0;
			}
			else if (count == 3)
			{
				System.Collections.Generic.List<System.Xml.Linq.XElement> obj = (System.Collections.Generic.List<System.Xml.Linq.XElement>)ToLua.CheckObject(L, 1, typeof(System.Collections.Generic.List<System.Xml.Linq.XElement>));
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
				int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
				obj.Reverse(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: System.Collections.Generic.List<System.Xml.Linq.XElement>.Reverse");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Sort(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				System.Collections.Generic.List<System.Xml.Linq.XElement> obj = (System.Collections.Generic.List<System.Xml.Linq.XElement>)ToLua.CheckObject(L, 1, typeof(System.Collections.Generic.List<System.Xml.Linq.XElement>));
				obj.Sort();
				return 0;
			}
			else if (count == 2 && TypeChecker.CheckTypes<System.Collections.Generic.IComparer<System.Xml.Linq.XElement>>(L, 2))
			{
				System.Collections.Generic.List<System.Xml.Linq.XElement> obj = (System.Collections.Generic.List<System.Xml.Linq.XElement>)ToLua.CheckObject(L, 1, typeof(System.Collections.Generic.List<System.Xml.Linq.XElement>));
				System.Collections.Generic.IComparer<System.Xml.Linq.XElement> arg0 = (System.Collections.Generic.IComparer<System.Xml.Linq.XElement>)ToLua.ToObject(L, 2);
				obj.Sort(arg0);
				return 0;
			}
			else if (count == 2 && TypeChecker.CheckTypes<System.Comparison<System.Xml.Linq.XElement>>(L, 2))
			{
				System.Collections.Generic.List<System.Xml.Linq.XElement> obj = (System.Collections.Generic.List<System.Xml.Linq.XElement>)ToLua.CheckObject(L, 1, typeof(System.Collections.Generic.List<System.Xml.Linq.XElement>));
				System.Comparison<System.Xml.Linq.XElement> arg0 = (System.Comparison<System.Xml.Linq.XElement>)ToLua.ToObject(L, 2);
				obj.Sort(arg0);
				return 0;
			}
			else if (count == 4)
			{
				System.Collections.Generic.List<System.Xml.Linq.XElement> obj = (System.Collections.Generic.List<System.Xml.Linq.XElement>)ToLua.CheckObject(L, 1, typeof(System.Collections.Generic.List<System.Xml.Linq.XElement>));
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
				int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
				System.Collections.Generic.IComparer<System.Xml.Linq.XElement> arg2 = (System.Collections.Generic.IComparer<System.Xml.Linq.XElement>)ToLua.CheckObject<System.Collections.Generic.IComparer<System.Xml.Linq.XElement>>(L, 4);
				obj.Sort(arg0, arg1, arg2);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: System.Collections.Generic.List<System.Xml.Linq.XElement>.Sort");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ToArray(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			System.Collections.Generic.List<System.Xml.Linq.XElement> obj = (System.Collections.Generic.List<System.Xml.Linq.XElement>)ToLua.CheckObject(L, 1, typeof(System.Collections.Generic.List<System.Xml.Linq.XElement>));
			System.Xml.Linq.XElement[] o = obj.ToArray();
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int TrimExcess(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			System.Collections.Generic.List<System.Xml.Linq.XElement> obj = (System.Collections.Generic.List<System.Xml.Linq.XElement>)ToLua.CheckObject(L, 1, typeof(System.Collections.Generic.List<System.Xml.Linq.XElement>));
			obj.TrimExcess();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int TrueForAll(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			System.Collections.Generic.List<System.Xml.Linq.XElement> obj = (System.Collections.Generic.List<System.Xml.Linq.XElement>)ToLua.CheckObject(L, 1, typeof(System.Collections.Generic.List<System.Xml.Linq.XElement>));
			System.Predicate<System.Xml.Linq.XElement> arg0 = (System.Predicate<System.Xml.Linq.XElement>)ToLua.CheckDelegate<System.Predicate<System.Xml.Linq.XElement>>(L, 2);
			bool o = obj.TrueForAll(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Capacity(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Collections.Generic.List<System.Xml.Linq.XElement> obj = (System.Collections.Generic.List<System.Xml.Linq.XElement>)o;
			int ret = obj.Capacity;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Capacity on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Count(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Collections.Generic.List<System.Xml.Linq.XElement> obj = (System.Collections.Generic.List<System.Xml.Linq.XElement>)o;
			int ret = obj.Count;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Count on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Capacity(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Collections.Generic.List<System.Xml.Linq.XElement> obj = (System.Collections.Generic.List<System.Xml.Linq.XElement>)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.Capacity = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Capacity on a nil value");
		}
	}
}

