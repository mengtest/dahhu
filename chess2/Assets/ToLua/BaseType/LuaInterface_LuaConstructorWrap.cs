
using System;
using LuaInterface;

public class LuaInterface_LuaConstructorWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(LuaInterface.LuaConstructor), typeof(System.Object));
		L.RegFunction("Call", Call);
		L.RegFunction("Destroy", Destroy);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Call(IntPtr L)
	{
		try
		{			
			LuaConstructor obj = (LuaConstructor)ToLua.CheckObject(L, 1, typeof(LuaConstructor));            
			return obj.Call(L);						
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Destroy(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			LuaConstructor obj = (LuaConstructor)ToLua.CheckObject(L, 1, typeof(LuaConstructor));
			obj.Destroy();
            ToLua.Destroy(L);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

