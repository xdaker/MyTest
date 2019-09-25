using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using OracleEfTest.CWWMS;
using OracleEfTest.JJWMS;
using OracleEfTest.WMSTak;
using OracleEfTest.WMSTakModelFirst;
using Tools;

namespace OracleEfTest
{
    class Program
    {
        public static WMSTakModel WmsTakModel { get; set; } =  new WMSTakModel();

        public static bool istrue = true;

        public static List<string> NotNameList { get; } = new List<string>();

        static void Main(string[] args) 
        {
            //Database.SetInitializer(new DropCreateDatabaseAlways<WMSTakModel>());
            ////Database.SetInitializer(new DropCreateDatabaseIfModelChanges<WMSTakModel>());
            //using (var wmsTakModel = new WMSTakModel())
            //{
            //    var q = wmsTakModel.BASE_BUTTON.FirstOrDefault();
            //}

            //using (var wms = new DB_WMS_TAKEntities())
            //{
            //    try
            //    {
            //        var infos = wms.GetPropertyInfos();
            //        infos.ForEach(v =>
            //        {
            //            if (v == null) return;
            //            //if(!istrue) return;
            //            var dbSetType = typeof(DbSet<>);
            //            if (v.PropertyType.Name != dbSetType.Name) return;
            //            var value = wms.GetPropertiesValue(v);

            //            if (!(value is IQueryable)) return;
            //            var queryable = value as IQueryable;
            //            var list = queryable.ToListAsync().Result;
            //            Console.WriteLine($"{v.Name}:" + list.Count);
            //            if (list.Count < 1)
            //            {
            //                return;
            //            }
            //            //istrue = false;
            //            //Console.WriteLine($"{v.PropertyType.ToString()}:" + list.Count);
            //            var olraceTypePropertyInfos = WmsTakModel.GetPropertyInfos();
            //            foreach (var info in list)
            //            {
            //                var olraceTypeInfos = olraceTypePropertyInfos.FirstOrDefault(v2 => v.Name.ToUpper().Equals(v2.Name.ToUpper()));
            //                if (olraceTypeInfos == null)
            //                {
            //                    Console.WriteLine($"找不到相关属性");
            //                    NotNameList.Add(v.Name);
            //                    return;
            //                }
            //                var olraceTypevalue = WmsTakModel.GetPropertiesValue(olraceTypeInfos);

            //                MethodInfo mi = olraceTypevalue.GetType().GetMethod("Add");
            //                var olraceType = mi?.ReturnType;
            //                if (olraceType == null) return;

            //                var json = info.ToJson();
            //                var olraceValue = json.ToObject(olraceType);

            //                if (olraceValue == null)
            //                {
            //                    Console.WriteLine($"导入值：{olraceType.FullName},为空");
            //                    continue;
            //                }
            //                Delete(olraceValue);
            //                if (Add(olraceValue)) continue;
            //                Console.WriteLine($"导入值：{olraceValue.ToJson()},失败");
            //                break;
            //            }
            //        });
            //        File.WriteAllText(@"./notName.txt", NotNameList.ToJson());
            //        Console.WriteLine("结束");
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine(e.ToString());
            //    }

            //}

            //string pattern = "\\[Table(.+)\\]";

            //DirectoryInfo theFolder = new DirectoryInfo(@"C:\Users\GX\Documents\Visual Studio 2015\Projects\OracleEfTest\OracleEfTest\WMSTakModelFirst");
            ////遍历文件夹
            //foreach (var nextFile in theFolder.GetFiles())
            //{
            //    var filePath = nextFile.FullName;
            //    var fileText = File.ReadAllText(filePath);
            //    foreach (Match match in Regex.Matches(fileText, pattern))
            //    {
            //        var value = match.Value;
            //        //var capitalization = value.ToUpper();
            //        //capitalization = capitalization.Replace("Table".ToUpper(), "Table");
            //        var capitalization = @"//" + value;
            //        Console.WriteLine(capitalization);
            //        fileText = fileText.Replace(value, capitalization);

            //    }
            //    File.WriteAllText(filePath, fileText);
            //}

            //var filePath = @"D:\新建文本文档.txt";
            //var fileText = File.ReadAllText(filePath);
            //fileText = fileText.ToUpper();
            //File.WriteAllText(filePath, fileText);

            Console.Read();
        }

        protected static void DirectoryInfos(string path)
        {
            DirectoryInfo theFolder = new DirectoryInfo(path);
            var nameList = new List<string> { "bin", "obj", ".vs" };
            if (nameList.Contains(theFolder.Name))
            {
                var path1 = theFolder.FullName.Replace(@"D:\WorkGit\惠州宙邦", "");
                path1 = path1.Replace(@"\", "/");
                Console.WriteLine(path1);
                return;
            }
            //遍历文件夹
            foreach (DirectoryInfo nextFolder in theFolder.GetDirectories())
            {
                DirectoryInfos(nextFolder.FullName);
            }
        }

        public static bool Add(object value)
        {

            try
            {
                int index = -1;
                //Console.WriteLine(value.GetType().FullName);
                WmsTakModel.Entry(value).State = EntityState.Added;
                index = WmsTakModel.SaveChanges();
                return index >= 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return false;
        }

        public static bool Delete<T>(T value) where T : class
        {
            try
            {
                int index = -1;
                //Console.WriteLine(value.GetType().FullName);
                WmsTakModel.Entry(value).State = EntityState.Deleted;
                index = WmsTakModel.SaveChanges();
                return index >= 0;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static bool Any(IQueryable queryable,object obj)
        {
            if (queryable ==null || obj == null) return false;
            var list =  queryable.ToListAsync().Result;
            Console.WriteLine($"1111111111111111111111111111111111:{list.Count}");
            return list.Any(value =>
            {
                var str1 = value.ToJson();
                var str2 = obj.ToJson();
                Console.WriteLine($"11111111:{str1}");
                Console.WriteLine($"22222222:{str2}");
                return str1 == str2;
            });
        }
    }
}
