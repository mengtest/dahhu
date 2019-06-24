
using System;
using System.Collections.Generic;
using LuaInterface;

public class System_DelegateWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(System.Delegate), typeof(System.Object));
		L.RegFunction("CreateDelegate", CreateDelegate);
		L.RegFunction("DynamicInvoke", DynamicInvoke);
		L.RegFunction("Clone", Clone);
		L.RegFunction("GetObjectData", GetObjectData);
		L.RegFunction("GetInvocationList", GetInvocationList);
		L.RegFunction("Combine", Combine);
		L.RegFunction("Remove", Remove);
		L.RegFunction("RemoveAll", RemoveAll);
		L.RegFunction("Destroy", Destroy);
		L.RegFunction("GetHashCode", GetHashCode);
		L.RegFunction("Equals", Equals);
		L.RegFunction("__add", op_Addition);
		L.RegFunction("__sub", op_Subtraction);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("Method", get_Method, null);
		L.RegVar("Target", get_Target, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CreateDelegate(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				System.Type arg0 = ToLua.CheckMonoType(L, 1);
				System.Reflection.MethodInfo arg1 = (System.Reflection.MethodInfo)ToLua.CheckObject<System.Reflection.MethodInfo>(L, 2);
				System.Delegate o = System.Delegate.CreateDelegate(arg0, arg1);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 3 && TypeChecker.CheckTypes<System.Reflection.MethodInfo, bool>(L, 2))
			{
				System.Type arg0 = ToLua.CheckMonoType(L, 1);
				System.Reflection.MethodInfo arg1 = (System.Reflection.MethodInfo)ToLua.ToObject(L, 2);
				bool arg2 = LuaDLL.lua_toboolean(L, 3);
				System.Delegate o = System.Delegate.CreateDelegate(arg0, arg1, arg2);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 3 && TypeChecker.CheckTypes<System.Type, string>(L, 2))
			{
				System.Type arg0 = ToLua.CheckMonoType(L, 1);
				System.Type arg1 = (System.Type)ToLua.ToObject(L, 2);
				string arg2 = ToLua.ToString(L, 3);
				System.Delegate o = System.Delegate.CreateDelegate(arg0, arg1, arg2);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 3 && TypeChecker.CheckTypes<object, string>(L, 2))
			{
				System.Type arg0 = ToLua.CheckMonoType(L, 1);
				object arg1 = ToLua.ToVarObject(L, 2);
				string arg2 = ToLua.ToString(L, 3);
				System.Delegate o = System.Delegate.CreateDelegate(arg0, arg1, arg2);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 3 && TypeChecker.CheckTypes<object, System.Reflection.MethodInfo>(L, 2))
			{
				System.Type arg0 = ToLua.CheckMonoType(L, 1);
				object arg1 = ToLua.ToVarObject(L, 2);
				System.Reflection.MethodInfo arg2 = (System.Reflection.MethodInfo)ToLua.ToObject(L, 3);
				System.Delegate o = System.Delegate.CreateDelegate(arg0, arg1, arg2);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 4 && TypeChecker.CheckTypes<System.Type, string, bool>(L, 2))
			{
				System.Type arg0 = ToLua.CheckMonoType(L, 1);
				System.Type arg1 = (System.Type)ToLua.ToObject(L, 2);
				string arg2 = ToLua.ToString(L, 3);
				bool arg3 = LuaDLL.lua_toboolean(L, 4);
				System.Delegate o = System.Delegate.CreateDelegate(arg0, arg1, arg2, arg3);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 4 && TypeChecker.CheckTypes<object, string, bool>(L, 2))
			{
				System.Type arg0 = ToLua.CheckMonoType(L, 1);
				object arg1 = ToLua.ToVarObject(L, 2);
				string arg2 = ToLua.ToString(L, 3);
				bool arg3 = LuaDLL.lua_toboolean(L, 4);
				System.Delegate o = System.Delegate.CreateDelegate(arg0, arg1, arg2, arg3);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 4 && TypeChecker.CheckTypes<object, System.Reflection.MethodInfo, bool>(L, 2))
			{
				System.Type arg0 = ToLua.CheckMonoType(L, 1);
				object arg1 = ToLua.ToVarObject(L, 2);
				System.Reflection.MethodInfo arg2 = (System.Reflection.MethodInfo)ToLua.ToObject(L, 3);
				bool arg3 = LuaDLL.lua_toboolean(L, 4);
				System.Delegate o = System.Delegate.CreateDelegate(arg0, arg1, arg2, arg3);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 5 && TypeChecker.CheckTypes<System.Type, string, bool, bool>(L, 2))
			{
				System.Type arg0 = ToLua.CheckMonoType(L, 1);
				System.Type arg1 = (System.Type)ToLua.ToObject(L, 2);
				string arg2 = ToLua.ToString(L, 3);
				bool arg3 = LuaDLL.lua_toboolean(L, 4);
				bool arg4 = LuaDLL.lua_toboolean(L, 5);
				System.Delegate o = System.Delegate.CreateDelegate(arg0, arg1, arg2, arg3, arg4);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 5 && TypeChecker.CheckTypes<object, string, bool, bool>(L, 2))
			{
				System.Type arg0 = ToLua.CheckMonoType(L, 1);
				object arg1 = ToLua.ToVarObject(L, 2);
				string arg2 = ToLua.ToString(L, 3);
				bool arg3 = LuaDLL.lua_toboolean(L, 4);
				bool arg4 = LuaDLL.lua_toboolean(L, 5);
				System.Delegate o = System.Delegate.CreateDelegate(arg0, arg1, arg2, arg3, arg4);
				ToLua.Push(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: System.Delegate.CreateDelegate");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DynamicInvoke(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			System.Delegate obj = (System.Delegate)ToLua.CheckObject<System.Delegate>(L, 1);
			object[] arg0 = ToLua.ToParamsObject(L, 2, count - 1);
			object o = obj.DynamicInvoke(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Clone(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			System.Delegate obj = (System.Delegate)ToLua.CheckObject<System.Delegate>(L, 1);
			object o = obj.Clone();
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetObjectData(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			System.Delegate obj = (System.Delegate)ToLua.CheckObject<System.Delegate>(L, 1);
			System.Runtime.Serialization.SerializationInfo arg0 = (System.Runtime.Serialization.SerializationInfo)ToLua.CheckObject(L, 2, typeof(System.Runtime.Serialization.SerializationInfo));
			System.Runtime.Serialization.StreamingContext arg1 = StackTraits<System.Runtime.Serialization.StreamingContext>.Check(L, 3);
			obj.GetObjectData(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetInvocationList(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			System.Delegate obj = (System.Delegate)ToLua.CheckObject<System.Delegate>(L, 1);
			System.Delegate[] o = obj.GetInvocationList();
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Combine(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes<System.Delegate, System.Delegate>(L, 1))
			{
				System.Delegate arg0 = (System.Delegate)ToLua.ToObject(L, 1);
				System.Delegate arg1 = (System.Delegate)ToLua.ToObject(L, 2);
				System.Delegate o = System.Delegate.Combine(arg0, arg1);
				ToLua.Push(L, o);
				return 1;
			}
			else if (TypeChecker.CheckParamsType<System.Delegate>(L, 1, count))
			{
				System.Delegate[] arg0 = ToLua.ToParamsObject<System.Delegate>(L, 1, count);
				System.Delegate o = System.Delegate.Combine(arg0);
				ToLua.Push(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: System.Delegate.Combine");
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
			System.Delegate arg0 = (System.Delegate)ToLua.CheckObject<System.Delegate>(L, 1);
			System.Delegate arg1 = (System.Delegate)ToLua.CheckObject<System.Delegate>(L, 2);
			System.Delegate o = System.Delegate.Remove(arg0, arg1);
			ToLua.Push(L, o);
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
			System.Delegate arg0 = (System.Delegate)ToLua.CheckObject<System.Delegate>(L, 1);
			System.Delegate arg1 = (System.Delegate)ToLua.CheckObject<System.Delegate>(L, 2);
			System.Delegate o = System.Delegate.RemoveAll(arg0, arg1);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Subtraction(IntPtr L)
	{
        try
        {            
            Delegate arg0 = (Delegate)ToLua.CheckObject<Delegate>(L, 1);
            LuaTypes type = LuaDLL.lua_type(L, 2);

            if (type == LuaTypes.LUA_TFUNCTION)
            {
                LuaState state = LuaState.Get(L);
                LuaFunction func = ToLua.ToLuaFunction(L, 2);
                Delegate[] ds = arg0.GetInvocationList();

                for (int i = 0; i < ds.Length; i++)
                {
                    LuaDelegate ld = ds[i].Target as LuaDelegate;

                    if (ld != null && ld.func == func && ld.self == null)
                    {
                        arg0 = Delegate.Remove(arg0, ds[i]);
                        state.DelayDispose(ld.func);
                        break;
                    }
                }

                func.Dispose();
                ToLua.Push(L, arg0);
                return 1;
            }
            else
            {
                Delegate arg1 = (Delegate)ToLua.CheckObject<Delegate>(L, 2);
                arg0 = DelegateFactory.RemoveDelegate(arg0, arg1);                
                ToLua.Push(L, arg0);
                return 1;
            }
        }
        catch (Exception e)
        {
            return LuaDLL.toluaL_exception(L, e);
        }
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Addition(IntPtr L)
	{
        try
        {                        
            LuaTypes type = LuaDLL.lua_type(L, 1);

            switch (type)
            {
                case LuaTypes.LUA_TFUNCTION:
                    Delegate arg0 = ToLua.ToObject(L, 2) as Delegate;
                    LuaFunction func = ToLua.ToLuaFunction(L, 1);
                    Type t = arg0.GetType();
                    Delegate arg1 = DelegateFactory.CreateDelegate(t, func);
                    Delegate arg2 = Delegate.Combine(arg0, arg1);
                    ToLua.Push(L, arg2);
                    return 1;
                case LuaTypes.LUA_TNIL:
                    LuaDLL.lua_pushvalue(L, 2);
                    return 1;
                case LuaTypes.LUA_TUSERDATA:
                    Delegate a0 = ToLua.ToObject(L, 1) as Delegate;
                    Delegate a1 = ToLua.CheckDelegate(a0.GetType(), L, 2);
                    Delegate ret = Delegate.Combine(a0, a1);
                    ToLua.Push(L, ret);
                    return 1;
                default:
                    LuaDLL.luaL_typerror(L, 1, "Delegate");
                    return 0;
            }
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
			System.Delegate arg0 = (System.Delegate)ToLua.ToObject(L, 1);
			System.Delegate arg1 = (System.Delegate)ToLua.ToObject(L, 2);
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
	static int Destroy(IntPtr L)
	{
        Delegate arg0 = (Delegate)ToLua.CheckObject<Delegate>(L, 1);
        Delegate[] ds = arg0.GetInvocationList();

        for (int i = 0; i < ds.Length; i++)
        {
            LuaDelegate ld = ds[i].Target as LuaDelegate;

            if (ld != null)
            {                
                ld.Dispose();                
            }
        }

        return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetHashCode(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			System.Delegate obj = (System.Delegate)ToLua.CheckObject<System.Delegate>(L, 1);
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
	static int Equals(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			System.Delegate obj = (System.Delegate)ToLua.CheckObject<System.Delegate>(L, 1);
			object arg0 = ToLua.ToVarObject(L, 2);
			bool o = obj != null ? obj.Equals(arg0) : arg0 == null;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Method(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Delegate obj = (System.Delegate)o;
			System.Reflection.MethodInfo ret = obj.Method;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Method on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Target(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Delegate obj = (System.Delegate)o;
			object ret = obj.Target;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Target on a nil value");
		}
	}
}

