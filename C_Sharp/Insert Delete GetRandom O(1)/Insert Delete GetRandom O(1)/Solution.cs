using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insert_Delete_GetRandom_O_1_
{
    internal class Solution
    {
        private Dictionary<int, int> _dict = new Dictionary<int, int>();
        private List<int> _list = new List<int>();
        public bool Insert(int val)
        {
            if (_dict.ContainsKey(val))
            {
                return false;
            }
            _dict[val] = _list.Count;
            _list.Add(val);
            return true;
        }

        public bool Remove(int val)
        {
            if( !_dict.ContainsKey(val) )
            {
                return false;
            }
            int index = _dict[val];
            int lastElement = _list[_list.Count - 1];

            _list[index] = lastElement;
            _dict[lastElement] = index;

            _list.RemoveAt(_list.Count - 1);
            _dict.Remove(val);

            return true;
        }

        public int GetRandom()
        {
            Random random = new Random();
            int index = random.Next(_list.Count);
            return _list[index];
        }
    }
}
