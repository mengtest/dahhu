
using System;
using LuaInterface;

public class System_TypeWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(System.Type), typeof(System.Object));
		L.RegFunction("Equals", Equals);
		L.RegFunction("GetType", GetType);
		L.RegFunction("GetTypeArray", GetTypeArray);
		L.RegFunction("GetTypeCode", GetTypeCode);
		L.RegFunction("GetTypeFromHandle", GetTypeFromHandle);
		L.RegFunction("GetTypeHandle", GetTypeHandle);
		L.RegFunction("IsSubclassOf", IsSubclassOf);
		L.RegFunction("FindInterfaces", FindInterfaces);
		L.RegFunction("GetInterface", GetInterface);
		L.RegFunction("GetInterfaceMap", GetInterfaceMap);
		L.RegFunction("GetInterfaces", GetInterfaces);
		L.RegFunction("IsAssignableFrom", IsAssignableFrom);
		L.RegFunction("IsInstanceOfType", IsInstanceOfType);
		L.RegFunction("GetArrayRank", GetArrayRank);
		L.RegFunction("GetElementType", GetElementType);
		L.RegFunction("GetHashCode", GetHashCode);
		L.RegFunction("GetNestedType", GetNestedType);
		L.RegFunction("GetNestedTypes", GetNestedTypes);
		L.RegFunction("GetDefaultMembers", GetDefaultMembers);
		L.RegFunction("FindMembers", FindMembers);
		L.RegFunction("InvokeMember", InvokeMember);
		L.RegFunction("ToString", ToString);
		L.RegFunction("GetGenericArguments", GetGenericArguments);
		L.RegFunction("GetGenericTypeDefinition", GetGenericTypeDefinition);
		L.RegFunction("MakeGenericType", MakeGenericType);
		L.RegFunction("GetGenericParameterConstraints", GetGenericParameterConstraints);
		L.RegFunction("MakeArrayType", MakeArrayType);
		L.RegFunction("MakeByRefType", MakeByRefType);
		L.RegFunction("MakePointerType", MakePointerType);
		L.RegFunction("ReflectionOnlyGetType", ReflectionOnlyGetType);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("Delimiter", get_Delimiter, null);
		L.RegVar("EmptyTypes", get_EmptyTypes, null);
		L.RegVar("FilterAttribute", get_FilterAttribute, null);
		L.RegVar("FilterName", get_FilterName, null);
		L.RegVar("FilterNameIgnoreCase", get_FilterNameIgnoreCase, null);
		L.RegVar("Missing", get_Missing, null);
		L.RegVar("Assembly", get_Assembly, null);
		L.RegVar("AssemblyQualifiedName", get_AssemblyQualifiedName, null);
		L.RegVar("Attributes", get_Attributes, null);
		L.RegVar("BaseType", get_BaseType, null);
		L.RegVar("DeclaringType", get_DeclaringType, null);
		L.RegVar("DefaultBinder", get_DefaultBinder, null);
		L.RegVar("FullName", get_FullName, null);
		L.RegVar("GUID", get_GUID, null);
		L.RegVar("HasElementType", get_HasElementType, null);
		L.RegVar("IsAbstract", get_IsAbstract, null);
		L.RegVar("IsAnsiClass", get_IsAnsiClass, null);
		L.RegVar("IsArray", get_IsArray, null);
		L.RegVar("IsAutoClass", get_IsAutoClass, null);
		L.RegVar("IsAutoLayout", get_IsAutoLayout, null);
		L.RegVar("IsByRef", get_IsByRef, null);
		L.RegVar("IsClass", get_IsClass, null);
		L.RegVar("IsCOMObject", get_IsCOMObject, null);
		L.RegVar("IsContextful", get_IsContextful, null);
		L.RegVar("IsEnum", get_IsEnum, null);
		L.RegVar("IsExplicitLayout", get_IsExplicitLayout, null);
		L.RegVar("IsImport", get_IsImport, null);
		L.RegVar("IsInterface", get_IsInterface, null);
		L.RegVar("IsLayoutSequential", get_IsLayoutSequential, null);
		L.RegVar("IsMarshalByRef", get_IsMarshalByRef, null);
		L.RegVar("IsNestedAssembly", get_IsNestedAssembly, null);
		L.RegVar("IsNestedFamANDAssem", get_IsNestedFamANDAssem, null);
		L.RegVar("IsNestedFamily", get_IsNestedFamily, null);
		L.RegVar("IsNestedFamORAssem", get_IsNestedFamORAssem, null);
		L.RegVar("IsNestedPrivate", get_IsNestedPrivate, null);
		L.RegVar("IsNestedPublic", get_IsNestedPublic, null);
		L.RegVar("IsNotPublic", get_IsNotPublic, null);
		L.RegVar("IsPointer", get_IsPointer, null);
		L.RegVar("IsPrimitive", get_IsPrimitive, null);
		L.RegVar("IsPublic", get_IsPublic, null);
		L.RegVar("IsSealed", get_IsSealed, null);
		L.RegVar("IsSerializable", get_IsSerializable, null);
		L.RegVar("IsSpecialName", get_IsSpecialName, null);
		L.RegVar("IsUnicodeClass", get_IsUnicodeClass, null);
		L.RegVar("IsValueType", get_IsValueType, null);
		L.RegVar("MemberType", get_MemberType, null);
		L.RegVar("Module", get_Module, null);
		L.RegVar("Namespace", get_Namespace, null);
		L.RegVar("ReflectedType", get_ReflectedType, null);
		L.RegVar("TypeHandle", get_TypeHandle, null);
		L.RegVar("TypeInitializer", get_TypeInitializer, null);
		L.RegVar("UnderlyingSystemType", get_UnderlyingSystemType, null);
		L.RegVar("ContainsGenericParameters", get_ContainsGenericParameters, null);
		L.RegVar("IsGenericTypeDefinition", get_IsGenericTypeDefinition, null);
		L.RegVar("IsGenericType", get_IsGenericType, null);
		L.RegVar("IsGenericParameter", get_IsGenericParameter, null);
		L.RegVar("IsNested", get_IsNested, null);
		L.RegVar("IsVisible", get_IsVisible, null);
		L.RegVar("GenericParameterPosition", get_GenericParameterPosition, null);
		L.RegVar("GenericParameterAttributes", get_GenericParameterAttributes, null);
		L.RegVar("DeclaringMethod", get_DeclaringMethod, null);
		L.RegVar("StructLayoutAttribute", get_StructLayoutAttribute, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Equals(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes<System.Type>(L, 2))
			{
				System.Type obj = ToLua.CheckMonoType(L, 1);
				System.Type arg0 = (System.Type)ToLua.ToObject(L, 2);
				bool o = obj != null ? obj.Equals(arg0) : arg0 == null;
				LuaDLL.lua_pushboolean(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes<object>(L, 2))
			{
				System.Type obj = ToLua.CheckMonoType(L, 1);
				object arg0 = ToLua.ToVarObject(L, 2);
				bool o = obj != null ? obj.Equals(arg0) : arg0 == null;
				LuaDLL.lua_pushboolean(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: System.Type.Equals");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetType(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1 && TypeChecker.CheckTypes<System.Type>(L, 1))
			{
				System.Type obj = (System.Type)ToLua.ToObject(L, 1);
				System.Type o = obj.GetType();
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 1 && TypeChecker.CheckTypes<string>(L, 1))
			{
				string arg0 = ToLua.ToString(L, 1);
				System.Type o = System.Type.GetType(arg0);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 2)
			{
				string arg0 = ToLua.CheckString(L, 1);
				bool arg1 = LuaDLL.luaL_checkboolean(L, 2);
				System.Type o = System.Type.GetType(arg0, arg1);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 3)
			{
				string arg0 = ToLua.CheckString(L, 1);
				bool arg1 = LuaDLL.luaL_checkboolean(L, 2);
				bool arg2 = LuaDLL.luaL_checkboolean(L, 3);
				System.Type o = System.Type.GetType(arg0, arg1, arg2);
				ToLua.Push(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: System.Type.GetType");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetTypeArray(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			object[] arg0 = ToLua.CheckObjectArray(L, 1);
			System.Type[] o = System.Type.GetTypeArray(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetTypeCode(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			System.Type arg0 = ToLua.CheckMonoType(L, 1);
			System.TypeCode o = System.Type.GetTypeCode(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetTypeFromHandle(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			System.RuntimeTypeHandle arg0 = StackTraits<System.RuntimeTypeHandle>.Check(L, 1);
			System.Type o = System.Type.GetTypeFromHandle(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetTypeHandle(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			object arg0 = ToLua.ToVarObject(L, 1);
			System.RuntimeTypeHandle o = System.Type.GetTypeHandle(arg0);
			ToLua.PushValue(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IsSubclassOf(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			System.Type obj = ToLua.CheckMonoType(L, 1);
			System.Type arg0 = ToLua.CheckMonoType(L, 2);
			bool o = obj.IsSubclassOf(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FindInterfaces(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			System.Type obj = ToLua.CheckMonoType(L, 1);
			System.Reflection.TypeFilter arg0 = (System.Reflection.TypeFilter)ToLua.CheckDelegate<System.Reflection.TypeFilter>(L, 2);
			object arg1 = ToLua.ToVarObject(L, 3);
			System.Type[] o = obj.FindInterfaces(arg0, arg1);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetInterface(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				System.Type obj = ToLua.CheckMonoType(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				System.Type o = obj.GetInterface(arg0);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 3)
			{
				System.Type obj = ToLua.CheckMonoType(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				bool arg1 = LuaDLL.luaL_checkboolean(L, 3);
				System.Type o = obj.GetInterface(arg0, arg1);
				ToLua.Push(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: System.Type.GetInterface");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetInterfaceMap(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			System.Type obj = ToLua.CheckMonoType(L, 1);
			System.Type arg0 = ToLua.CheckMonoType(L, 2);
			System.Reflection.InterfaceMapping o = obj.GetInterfaceMap(arg0);
			ToLua.PushValue(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetInterfaces(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			System.Type obj = ToLua.CheckMonoType(L, 1);
			System.Type[] o = obj.GetInterfaces();
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IsAssignableFrom(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			System.Type obj = ToLua.CheckMonoType(L, 1);
			System.Type arg0 = ToLua.CheckMonoType(L, 2);
			bool o = obj.IsAssignableFrom(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IsInstanceOfType(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			System.Type obj = ToLua.CheckMonoType(L, 1);
			object arg0 = ToLua.ToVarObject(L, 2);
			bool o = obj.IsInstanceOfType(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetArrayRank(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			System.Type obj = ToLua.CheckMonoType(L, 1);
			int o = obj.GetArrayRank();
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetElementType(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			System.Type obj = ToLua.CheckMonoType(L, 1);
			System.Type o = obj.GetElementType();
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetHashCode(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			System.Type obj = ToLua.CheckMonoType(L, 1);
			int o = obj.GetHashCode();
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetNestedType(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				System.Type obj = ToLua.CheckMonoType(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				System.Type o = obj.GetNestedType(arg0);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 3)
			{
				System.Type obj = ToLua.CheckMonoType(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				System.Reflection.BindingFlags arg1 = (System.Reflection.BindingFlags)LuaDLL.luaL_checknumber(L, 3);
				System.Type o = obj.GetNestedType(arg0, arg1);
				ToLua.Push(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: System.Type.GetNestedType");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetNestedTypes(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				System.Type obj = ToLua.CheckMonoType(L, 1);
				System.Type[] o = obj.GetNestedTypes();
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 2)
			{
				System.Type obj = ToLua.CheckMonoType(L, 1);
				System.Reflection.BindingFlags arg0 = (System.Reflection.BindingFlags)LuaDLL.luaL_checknumber(L, 2);
				System.Type[] o = obj.GetNestedTypes(arg0);
				ToLua.Push(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: System.Type.GetNestedTypes");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetDefaultMembers(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			System.Type obj = ToLua.CheckMonoType(L, 1);
			System.Reflection.MemberInfo[] o = obj.GetDefaultMembers();
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FindMembers(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 5);
			System.Type obj = ToLua.CheckMonoType(L, 1);
			System.Reflection.MemberTypes arg0 = (System.Reflection.MemberTypes)ToLua.CheckObject(L, 2, typeof(System.Reflection.MemberTypes));
			System.Reflection.BindingFlags arg1 = (System.Reflection.BindingFlags)LuaDLL.luaL_checknumber(L, 3);
			System.Reflection.MemberFilter arg2 = (System.Reflection.MemberFilter)ToLua.CheckDelegate<System.Reflection.MemberFilter>(L, 4);
			object arg3 = ToLua.ToVarObject(L, 5);
			System.Reflection.MemberInfo[] o = obj.FindMembers(arg0, arg1, arg2, arg3);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int InvokeMember(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 6)
			{
				System.Type obj = ToLua.CheckMonoType(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				System.Reflection.BindingFlags arg1 = (System.Reflection.BindingFlags)LuaDLL.luaL_checknumber(L, 3);
				System.Reflection.Binder arg2 = (System.Reflection.Binder)ToLua.CheckObject<System.Reflection.Binder>(L, 4);
				object arg3 = ToLua.ToVarObject(L, 5);
				object[] arg4 = ToLua.CheckObjectArray(L, 6);
				object o = obj.InvokeMember(arg0, arg1, arg2, arg3, arg4);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 7)
			{
				System.Type obj = ToLua.CheckMonoType(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				System.Reflection.BindingFlags arg1 = (System.Reflection.BindingFlags)LuaDLL.luaL_checknumber(L, 3);
				System.Reflection.Binder arg2 = (System.Reflection.Binder)ToLua.CheckObject<System.Reflection.Binder>(L, 4);
				object arg3 = ToLua.ToVarObject(L, 5);
				object[] arg4 = ToLua.CheckObjectArray(L, 6);
				System.Globalization.CultureInfo arg5 = (System.Globalization.CultureInfo)ToLua.CheckObject<System.Globalization.CultureInfo>(L, 7);
				object o = obj.InvokeMember(arg0, arg1, arg2, arg3, arg4, arg5);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 9)
			{
				System.Type obj = ToLua.CheckMonoType(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				System.Reflection.BindingFlags arg1 = (System.Reflection.BindingFlags)LuaDLL.luaL_checknumber(L, 3);
				System.Reflection.Binder arg2 = (System.Reflection.Binder)ToLua.CheckObject<System.Reflection.Binder>(L, 4);
				object arg3 = ToLua.ToVarObject(L, 5);
				object[] arg4 = ToLua.CheckObjectArray(L, 6);
				System.Reflection.ParameterModifier[] arg5 = ToLua.CheckStructArray<System.Reflection.ParameterModifier>(L, 7);
				System.Globalization.CultureInfo arg6 = (System.Globalization.CultureInfo)ToLua.CheckObject<System.Globalization.CultureInfo>(L, 8);
				string[] arg7 = ToLua.CheckStringArray(L, 9);
				object o = obj.InvokeMember(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
				ToLua.Push(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: System.Type.InvokeMember");
			}
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
			System.Type obj = ToLua.CheckMonoType(L, 1);
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
	static int GetGenericArguments(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			System.Type obj = ToLua.CheckMonoType(L, 1);
			System.Type[] o = obj.GetGenericArguments();
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetGenericTypeDefinition(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			System.Type obj = ToLua.CheckMonoType(L, 1);
			System.Type o = obj.GetGenericTypeDefinition();
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int MakeGenericType(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			System.Type obj = ToLua.CheckMonoType(L, 1);
			System.Type[] arg0 = ToLua.CheckParamsObject<System.Type>(L, 2, count - 1);
			System.Type o = obj.MakeGenericType(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetGenericParameterConstraints(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			System.Type obj = ToLua.CheckMonoType(L, 1);
			System.Type[] o = obj.GetGenericParameterConstraints();
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int MakeArrayType(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				System.Type obj = ToLua.CheckMonoType(L, 1);
				System.Type o = obj.MakeArrayType();
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 2)
			{
				System.Type obj = ToLua.CheckMonoType(L, 1);
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
				System.Type o = obj.MakeArrayType(arg0);
				ToLua.Push(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: System.Type.MakeArrayType");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int MakeByRefType(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			System.Type obj = ToLua.CheckMonoType(L, 1);
			System.Type o = obj.MakeByRefType();
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int MakePointerType(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			System.Type obj = ToLua.CheckMonoType(L, 1);
			System.Type o = obj.MakePointerType();
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ReflectionOnlyGetType(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			string arg0 = ToLua.CheckString(L, 1);
			bool arg1 = LuaDLL.luaL_checkboolean(L, 2);
			bool arg2 = LuaDLL.luaL_checkboolean(L, 3);
			System.Type o = System.Type.ReflectionOnlyGetType(arg0, arg1, arg2);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Delimiter(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushnumber(L, System.Type.Delimiter);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_EmptyTypes(IntPtr L)
	{
		try
		{
			ToLua.Push(L, System.Type.EmptyTypes);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_FilterAttribute(IntPtr L)
	{
		try
		{
			ToLua.Push(L, System.Type.FilterAttribute);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_FilterName(IntPtr L)
	{
		try
		{
			ToLua.Push(L, System.Type.FilterName);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_FilterNameIgnoreCase(IntPtr L)
	{
		try
		{
			ToLua.Push(L, System.Type.FilterNameIgnoreCase);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Missing(IntPtr L)
	{
		try
		{
			ToLua.Push(L, System.Type.Missing);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Assembly(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Type obj = (System.Type)o;
			System.Reflection.Assembly ret = obj.Assembly;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Assembly on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_AssemblyQualifiedName(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Type obj = (System.Type)o;
			string ret = obj.AssemblyQualifiedName;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index AssemblyQualifiedName on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Attributes(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Type obj = (System.Type)o;
			System.Reflection.TypeAttributes ret = obj.Attributes;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Attributes on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_BaseType(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Type obj = (System.Type)o;
			System.Type ret = obj.BaseType;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index BaseType on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_DeclaringType(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Type obj = (System.Type)o;
			System.Type ret = obj.DeclaringType;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index DeclaringType on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_DefaultBinder(IntPtr L)
	{
		try
		{
			ToLua.PushObject(L, System.Type.DefaultBinder);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_FullName(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Type obj = (System.Type)o;
			string ret = obj.FullName;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index FullName on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_GUID(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Type obj = (System.Type)o;
			System.Guid ret = obj.GUID;
			ToLua.PushValue(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index GUID on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_HasElementType(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Type obj = (System.Type)o;
			bool ret = obj.HasElementType;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index HasElementType on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_IsAbstract(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Type obj = (System.Type)o;
			bool ret = obj.IsAbstract;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index IsAbstract on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_IsAnsiClass(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Type obj = (System.Type)o;
			bool ret = obj.IsAnsiClass;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index IsAnsiClass on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_IsArray(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Type obj = (System.Type)o;
			bool ret = obj.IsArray;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index IsArray on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_IsAutoClass(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Type obj = (System.Type)o;
			bool ret = obj.IsAutoClass;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index IsAutoClass on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_IsAutoLayout(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Type obj = (System.Type)o;
			bool ret = obj.IsAutoLayout;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index IsAutoLayout on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_IsByRef(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Type obj = (System.Type)o;
			bool ret = obj.IsByRef;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index IsByRef on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_IsClass(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Type obj = (System.Type)o;
			bool ret = obj.IsClass;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index IsClass on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_IsCOMObject(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Type obj = (System.Type)o;
			bool ret = obj.IsCOMObject;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index IsCOMObject on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_IsContextful(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Type obj = (System.Type)o;
			bool ret = obj.IsContextful;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index IsContextful on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_IsEnum(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Type obj = (System.Type)o;
			bool ret = obj.IsEnum;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index IsEnum on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_IsExplicitLayout(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Type obj = (System.Type)o;
			bool ret = obj.IsExplicitLayout;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index IsExplicitLayout on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_IsImport(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Type obj = (System.Type)o;
			bool ret = obj.IsImport;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index IsImport on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_IsInterface(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Type obj = (System.Type)o;
			bool ret = obj.IsInterface;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index IsInterface on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_IsLayoutSequential(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Type obj = (System.Type)o;
			bool ret = obj.IsLayoutSequential;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index IsLayoutSequential on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_IsMarshalByRef(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Type obj = (System.Type)o;
			bool ret = obj.IsMarshalByRef;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index IsMarshalByRef on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_IsNestedAssembly(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Type obj = (System.Type)o;
			bool ret = obj.IsNestedAssembly;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index IsNestedAssembly on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_IsNestedFamANDAssem(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Type obj = (System.Type)o;
			bool ret = obj.IsNestedFamANDAssem;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index IsNestedFamANDAssem on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_IsNestedFamily(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Type obj = (System.Type)o;
			bool ret = obj.IsNestedFamily;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index IsNestedFamily on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_IsNestedFamORAssem(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Type obj = (System.Type)o;
			bool ret = obj.IsNestedFamORAssem;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index IsNestedFamORAssem on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_IsNestedPrivate(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Type obj = (System.Type)o;
			bool ret = obj.IsNestedPrivate;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index IsNestedPrivate on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_IsNestedPublic(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Type obj = (System.Type)o;
			bool ret = obj.IsNestedPublic;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index IsNestedPublic on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_IsNotPublic(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Type obj = (System.Type)o;
			bool ret = obj.IsNotPublic;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index IsNotPublic on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_IsPointer(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Type obj = (System.Type)o;
			bool ret = obj.IsPointer;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index IsPointer on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_IsPrimitive(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Type obj = (System.Type)o;
			bool ret = obj.IsPrimitive;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index IsPrimitive on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_IsPublic(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Type obj = (System.Type)o;
			bool ret = obj.IsPublic;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index IsPublic on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_IsSealed(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Type obj = (System.Type)o;
			bool ret = obj.IsSealed;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index IsSealed on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_IsSerializable(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Type obj = (System.Type)o;
			bool ret = obj.IsSerializable;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index IsSerializable on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_IsSpecialName(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Type obj = (System.Type)o;
			bool ret = obj.IsSpecialName;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index IsSpecialName on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_IsUnicodeClass(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Type obj = (System.Type)o;
			bool ret = obj.IsUnicodeClass;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index IsUnicodeClass on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_IsValueType(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Type obj = (System.Type)o;
			bool ret = obj.IsValueType;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index IsValueType on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_MemberType(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Type obj = (System.Type)o;
			System.Reflection.MemberTypes ret = obj.MemberType;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index MemberType on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Module(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Type obj = (System.Type)o;
			System.Reflection.Module ret = obj.Module;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Module on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Namespace(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Type obj = (System.Type)o;
			string ret = obj.Namespace;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Namespace on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_ReflectedType(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Type obj = (System.Type)o;
			System.Type ret = obj.ReflectedType;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index ReflectedType on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_TypeHandle(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Type obj = (System.Type)o;
			System.RuntimeTypeHandle ret = obj.TypeHandle;
			ToLua.PushValue(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index TypeHandle on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_TypeInitializer(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Type obj = (System.Type)o;
			System.Reflection.ConstructorInfo ret = obj.TypeInitializer;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index TypeInitializer on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_UnderlyingSystemType(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Type obj = (System.Type)o;
			System.Type ret = obj.UnderlyingSystemType;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index UnderlyingSystemType on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_ContainsGenericParameters(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Type obj = (System.Type)o;
			bool ret = obj.ContainsGenericParameters;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index ContainsGenericParameters on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_IsGenericTypeDefinition(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Type obj = (System.Type)o;
			bool ret = obj.IsGenericTypeDefinition;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index IsGenericTypeDefinition on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_IsGenericType(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Type obj = (System.Type)o;
			bool ret = obj.IsGenericType;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index IsGenericType on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_IsGenericParameter(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Type obj = (System.Type)o;
			bool ret = obj.IsGenericParameter;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index IsGenericParameter on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_IsNested(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Type obj = (System.Type)o;
			bool ret = obj.IsNested;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index IsNested on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_IsVisible(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Type obj = (System.Type)o;
			bool ret = obj.IsVisible;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index IsVisible on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_GenericParameterPosition(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Type obj = (System.Type)o;
			int ret = obj.GenericParameterPosition;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index GenericParameterPosition on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_GenericParameterAttributes(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Type obj = (System.Type)o;
			System.Reflection.GenericParameterAttributes ret = obj.GenericParameterAttributes;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index GenericParameterAttributes on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_DeclaringMethod(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Type obj = (System.Type)o;
			System.Reflection.MethodBase ret = obj.DeclaringMethod;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index DeclaringMethod on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_StructLayoutAttribute(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Type obj = (System.Type)o;
			System.Runtime.InteropServices.StructLayoutAttribute ret = obj.StructLayoutAttribute;
			ToLua.PushSealed(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index StructLayoutAttribute on a nil value");
		}
	}
}

