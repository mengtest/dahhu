

using System;
using System.Collections.Generic;

namespace LuaInterface
{
    public class LuaObjectPool
    {        
        class PoolNode
        {
            public int index;
            public object obj;

            public PoolNode(int index, object obj)
            {
                this.index = index;
                this.obj = obj;
            }
        }

        private List<PoolNode> list;
        //同lua_ref策略，0作为一个回收链表头，不使用这个位置
        private PoolNode head = null;   
        private int count = 0;

        public LuaObjectPool()
        {
            list = new List<PoolNode>(1024);
            head = new PoolNode(0, null);
            list.Add(head);
            list.Add(new PoolNode(1, null));
            count = list.Count;
        }

        public object this[int i]
        {
            get 
            {
                if (i > 0 && i < count)
                {
                    return list[i].obj;
                }

                return null;
            }
        }

        public void Clear()
        {
            list.Clear();
            head = null;
            count = 0;
        }

        public int Add(object obj)
        {
            int pos = -1;

            if (head.index != 0)
            {
                pos = head.index;
                list[pos].obj = obj;
                head.index = list[pos].index;
            }
            else
            {
                pos = list.Count;
                list.Add(new PoolNode(pos, obj));
                count = pos + 1;
            }

            return pos;
        }

        public object TryGetValue(int index)
        {
            if (index > 0 && index < count)
            {
                return list[index].obj;                
            }
            
            return null;
        }

        public object Remove(int pos)
        {
            if (pos > 0 && pos < count)
            {
                object o = list[pos].obj;
                list[pos].obj = null;                
                list[pos].index = head.index;
                head.index = pos;

                return o;
            }

            return null;
        }

        public object Destroy(int pos)
        {
            if (pos > 0 && pos < count)
            {
                object o = list[pos].obj;
                list[pos].obj = null;
                return o;
            }

            return null;
        }

        public object Replace(int pos, object o)
        {
            if (pos > 0 && pos < count)
            {
                object obj = list[pos].obj;
                list[pos].obj = o;
                return obj;
            }

            return null;
        }
    }
}