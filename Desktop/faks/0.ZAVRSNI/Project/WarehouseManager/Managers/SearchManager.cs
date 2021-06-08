using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManager.Managers
{
    public static class SearchManager
    {
        public static List<string> getOptions()
        {
            return new List<string>
            {
                "Starts with",
                "Ends with",
                "Greater than",
                "Less than"
            };
        }

        public static List<T> StartsWith<T>(string value, string propertyName, List<T> list)
        {
            List<T> found = new List<T>();
            foreach (var item in list)
            {
                   if(item.GetType().GetProperty(propertyName).GetValue(item).ToString().ToUpper().StartsWith(value.ToUpper())) 
                        found.Add(item);                
            }

            return found;
            

        }
        public static List<T> EndsWith<T>(string value, string propertyName, List<T> list)
        {
            List<T> found = new List<T>();
            foreach (var item in list)
            {
                if (item.GetType().GetProperty(propertyName).GetValue(item).ToString().ToUpper().EndsWith(value.ToUpper()))
                    found.Add(item);
            }

            return found;


        }

        public static List<T> GreaterThan<T>(string value, string propertyName, List<T> list)
        {
            if (string.IsNullOrEmpty(value))
            {
                return list;
            }
            List<T> found = new List<T>();
            foreach (var item in list)
            {
                double number = 0, toCompareWith = 0;
                double.TryParse(item.GetType().GetProperty(propertyName).GetValue(item).ToString(),out number);
                double.TryParse(value, out toCompareWith);
                if (number > toCompareWith)
                    found.Add(item);
            }
            return found;
        }

        public static List<T> LessThan<T>(string value, string propertyName, List<T> list)
        {
            if (string.IsNullOrEmpty(value))
            {
                return list;
            }
            List<T> found = new List<T>();
            foreach (var item in list)
            {
                double number = 0, toCompareWith = 0;
                double.TryParse(item.GetType().GetProperty(propertyName).GetValue(item).ToString(), out number);
                double.TryParse(value, out toCompareWith);
                if (number < toCompareWith)
                    found.Add(item);
            }
            return found;
        }
    }
}
