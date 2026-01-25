using System.Data;
using System.Reflection;

namespace MONEY_FLOW_API.Repository
{
    public static class Helper
    {
        public static IList<T> ConvertDataTableToList<T>(this DataTable table)
        {
            if (table == null)
                return null;

            List<DataRow> rows = new List<DataRow>();

            foreach (DataRow row in table.Rows)
                rows.Add(row);

            return ConvertTo<T>(rows);
        }

        public static IList<T> ConvertTo<T>(IList<DataRow> rows)
        {
            IList<T> list = null;
            if (rows != null)
            {
                list = new List<T>();
                foreach (DataRow row in rows)
                {
                    T item = CreateItem<T>(row);
                    list.Add(item);
                }
            }
            return list;
        }

        public static T CreateItem<T>(this DataRow row)
        {
            string columnName;
            T obj = default(T);
            if (row != null)
            {
                //Create the instance of type T
                obj = Activator.CreateInstance<T>();
                foreach (DataColumn column in row.Table.Columns)
                {
                    columnName = column.ColumnName;
                    //Get property with same columnName
                    PropertyInfo prop = obj.GetType().GetProperty(columnName, BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance);
                    if (prop != null)
                    {
                        try
                        {
                            //Get value for the column
                            object value = (row[columnName].GetType() == typeof(DBNull)) ? null : row[columnName];
                            //Set property value
                            //prop.SetValue(obj, value, null);
                            var propType = prop.PropertyType;
                            if (value == null)
                                prop.SetValue(obj, null, null);
                            else if (propType.IsGenericType && propType.GetGenericTypeDefinition() == typeof(Nullable<>))
                            {
                                propType = propType.GetGenericArguments()[0];
                                prop.SetValue(obj, Convert.ChangeType(value, propType), null);
                            }
                            else
                            {
                                prop.SetValue(obj, value, null);
                            }
                        }
                        catch (Exception ex)
                        {
                            throw ex;
                            //Catch whatever here
                        }
                    }
                }
            }
            return obj;
        }
    }
}
