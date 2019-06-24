
using System;
using LuaInterface;

public class LuaInterface_EventObjectWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(LuaInterface.EventObject), typeof(System.Object));
		L.RegFunction("__add", op_Addition);
		L.RegFunction("__sub", op_Subtraction);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Subtraction(IntPtr L)
	{
        try
        {
            EventObject arg0 = (EventObject)ToLua.CheckObject(L, 1, typeof(EventObject));
            arg0.func = ToLua.CheckDelegate(arg0.type, L, 2);
            arg0.op = EventOp.Sub;
            ToLua.Push(L, arg0);
            return 1;
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
            EventObject arg0 = (EventObject)ToLua.CheckObject(L, 1, typeof(EventObject));
            arg0.func = ToLua.CheckDelegate(arg0.type, L, 2);
            arg0.op = EventOp.Add;
            ToLua.Push(L, arg0);
            return 1;
        }
        catch (Exception e)
        {
            return LuaDLL.toluaL_exception(L, e);
        }
	}
}

