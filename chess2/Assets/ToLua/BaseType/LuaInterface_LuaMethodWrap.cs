
using System;
using LuaInterface;

public class LuaInterface_LuaMethodWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(LuaInterface.LuaMethod), typeof(System.Object));
		L.RegFunction("Destroy", Destroy);
		L.RegFunction("Call", Call);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Destroy(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			LuaMethod obj = (LuaMethod)ToLua.CheckObject(L, 1, typeof(LuaMethod));
			obj.Destroy();
            ToLua.Destroy(L);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Call(IntPtr L)
	{
		try
		{			
			LuaMethod obj = (LuaMethod)ToLua.CheckObject(L, 1, typeof(LuaMethod));            
			return obj.Call(L);						
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

