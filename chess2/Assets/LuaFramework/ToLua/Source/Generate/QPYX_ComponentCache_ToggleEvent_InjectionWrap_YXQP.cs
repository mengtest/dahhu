﻿using System;
using LuaInterface;

public class QPYX_ComponentCache_ToggleEvent_InjectionWrap_YXQP
{
	public static void QPYX_Register_YXQP(LuaState L_YXQP)	{
		L_YXQP.BeginClass(typeof(ComponentCache.ToggleEvent_Injection), typeof(ComponentCache.Injection<UnityEngine.UI.Toggle.ToggleEvent>));
		L_YXQP.RegFunction("New", QPYX__CreateComponentCache_ToggleEvent_Injection_YXQP);
		L_YXQP.RegFunction("__tostring", ToLua.op_ToString);		L_YXQP.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int QPYX__CreateComponentCache_ToggleEvent_Injection_YXQP(IntPtr L_YXQP)
	{
		try
		{
			int QPYX_count_YXQP = LuaDLL.lua_gettop(L_YXQP);
			if (QPYX_count_YXQP == 0)
			{
				ComponentCache.ToggleEvent_Injection QPYX_obj_YXQP = new ComponentCache.ToggleEvent_Injection();
				ToLua.PushObject(L_YXQP, QPYX_obj_YXQP);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L_YXQP, "invalid arguments to ctor method: ComponentCache.ToggleEvent_Injection.New");
			}
		}
		catch (Exception e_YXQP)		{
			return LuaDLL.toluaL_exception(L_YXQP, e_YXQP);		}
	}
}

