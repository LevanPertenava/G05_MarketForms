using DatabaseHelper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;


namespace Market.Repository.Extensions
{
    public static class ExtensionMethods
    {
        public static IEnumerable<string> GetProcedureParams(this string procedureName, Database<SqlConnection> database)
        {
            SqlParameter sqlParameter = new() { ParameterName = "@Name", Value = procedureName };

            var table = database.GetTable("GetParams_SP", CommandType.StoredProcedure, sqlParameter);

            return table.AsEnumerable().Select(row => row[0].ToString());
        }

        public static IEnumerable<SqlParameter> ToSqlParams<T>(this IEnumerable<string> procedureParams, T model)
        {
            var type = model.GetType();
            foreach (var item in procedureParams)
            {
                var modelProperty = type.GetProperty(item.Replace("@", ""));
                yield return new SqlParameter { ParameterName = item, Value = modelProperty.GetValue(model) };
            }
        }

        public static T MapToModel<T>(this DataRow dataRow) where T : new()
        {
            T obj = new();
            var properties = obj.GetType().GetProperties();

            foreach (var property in properties)
            {
                if (property.PropertyType.IsInterface)
                {
                    continue;
                }
                var value = dataRow[property.Name];
                if (value == DBNull.Value)
                {
                    continue;
                }
                property.SetValue(obj, value);
            }
            return obj;
        }

        public static object CreateListInstance(this string model)
        {
            var myList = typeof(List<>);
            var constructedList = myList.MakeGenericType(Type.GetType($"Market.Models.{model},Market.Models"));
            var instance = Activator.CreateInstance(constructedList);

            return instance;
        }

        public static Type GetRepositoryType(this string model)
        {
            return Type.GetType($"Market.Repository.{model}Repository,Market.Repository");
        }

        public static object CreateRepositoryInstance(this Type classType, string path)
        {
            return Activator.CreateInstance(classType, path);
        }

        public static bool HasProperty(this object model, string propertyName)
        {
            return model.GetType().GetProperty(propertyName) != null;
        }
    }
}