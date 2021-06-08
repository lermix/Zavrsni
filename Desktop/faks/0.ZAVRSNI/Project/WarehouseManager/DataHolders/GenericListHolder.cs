using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Models.Enums;

namespace WarehouseManager.DataHolders
{
    /*interface IGenericListHolder<T>
    {
        IList GetList();
        void SetList(List<T> genericList);
    }

    class GenericListHolder<T> : IGenericListHolder<T>
    {
        List<T> genericList;

        public IList GetList()
        {
            if (genericList == null)
            {
                return new List<T>();
            }

            return genericList;
        }

        public void SetList(List<T> genericList)
        {
            this.genericList = genericList;
        }

    }*/

    public class GenericListHolder<T>
    {

        public static List<T> _list { get; set; }


        public static List<T> GetList()
        {
            return _list;
        }

        public static void setList(List<T> list)
        {
            _list = list;
        }



    }
}
