using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace THS.WebAPI.Helper
{
    class HelperBiz
    {
        public HelperBiz()
        {

        }

        public object ConvertJson(DataTable dt)
        {
            JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
            javaScriptSerializer.MaxJsonLength = Int32.MaxValue; //取得最大数值
            ArrayList arrayList = new ArrayList();
            foreach (DataRow dataRow in dt.Rows)
            {
                Dictionary<string, object> dictionary = new Dictionary<string, object>();  //实例化一个参数集合
                foreach (DataColumn dataColumn in dt.Columns)
                {
                    dictionary.Add(dataColumn.ColumnName, dataRow[dataColumn.ColumnName].ToString());
                }
                arrayList.Add(dictionary); //ArrayList集合中添加键值
            }
            return javaScriptSerializer.Deserialize<object>(javaScriptSerializer.Serialize(arrayList));

        }
        public List<string> GetPropertyList(object obj)
        {
            List<string> propertyList = new List<string>();

            Type type = obj.GetType();
            PropertyInfo[] properties = type.GetProperties(BindingFlags.Instance | BindingFlags.Public);
            string p;
            foreach (PropertyInfo property in properties)
            {
                object o = property.GetValue(obj, null);
                if (o == null)
                    p = "";
                else if (o != null && o.GetType() == typeof(bool))
                    p = (bool)o ? "是" : "否";
                else
                    p = o.ToString();
                //propertyList.Add(o == null ? "" : o.ToString());
                propertyList.Add(p);
            }

            return propertyList;
        }
        public DataTable ConvertListToDataTable(List<string[]> list)
        {
            // New table.
            DataTable table = new DataTable();

            // Get max columns.
            int columns = 0;
            foreach (var array in list)
            {
                if (array.Length > columns)
                {
                    columns = array.Length;
                }
            }

            // Add columns.
            for (int i = 0; i < columns; i++)
            {
                table.Columns.Add();
            }

            // Add rows.
            foreach (var array in list)
            {
                table.Rows.Add(array);
            }

            return table;

        }
    }
}
