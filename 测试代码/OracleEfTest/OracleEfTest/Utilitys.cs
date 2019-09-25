using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OracleEfTest
{
    public static class Utilitys
    {
        /// <summary>
        /// 获取类中的属性值
        /// </summary>
        /// <param name="fieldName"></param>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string GetModelValue(string fieldName, object obj)
        {
            try
            {
                Type ts = obj.GetType();
                var propertyInfo = ts.GetProperty(fieldName);
                if (propertyInfo != null)
                {
                    object o = propertyInfo.GetValue(obj, null);
                    string value = Convert.ToString(o);
                    if (string.IsNullOrEmpty(value)) return null;
                    return value;
                }
                return null;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// 设置类中的属性值
        /// </summary>
        /// <param name="fieldName"></param>
        /// <param name="value"></param>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static bool SetModelValue(string fieldName, object value, object obj)
        {
            try
            {
                Type ts = obj.GetType();
                var propertyInfo = ts.GetProperty(fieldName);
                if (propertyInfo == null) return false;
                //object v = Convert.ChangeType(value, propertyInfo.PropertyType);
                propertyInfo.SetValue(obj, value, null);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 获取一个对象下的所有公共属性
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static List<PropertyInfo> GetPropertyInfos(this object obj)
        {
            try
            {
                Type ts = obj.GetType();
                var baseTypes = ts.BaseType?.GetProperties().ToList();
                var thisTypes = ts.GetProperties().ToList();
                return
                    thisTypes.Where(
                        propertyInfo =>
                        {
                            return baseTypes != null && !baseTypes.Any(v => v.Name.Equals(propertyInfo.Name));
                        }).ToList();
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// 获取一个对象下，某个公共属性的值
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="propertyInfo">属性信息</param>
        /// <returns></returns>
        public static object GetPropertiesValue(this object obj, PropertyInfo propertyInfo)
        {
            if (propertyInfo == null) return default(object);
            try
            {
                object o = propertyInfo.GetValue(obj, null);
                return o;
            }
            catch (Exception e)
            {
                return default(object);
            }

        }
    }
}
