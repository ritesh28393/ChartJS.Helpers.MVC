using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace ChartJS.Helpers.MVC
{
    class MyConverter
    {
        /// <summary>
        /// key => property name
        /// value => chart js object name
        /// </summary>
        private static Dictionary<string, string> _mapper = new Dictionary<string, string>()
        {
            {"LinearData","data" },
            {"XYData","data" },
            {"XYRData","data" },
            {"SFill","fill" },
            {"IFill","fill" },
            {"BFill","fill" },
            { "BSteppedLine","steppedLine"},
            { "SSteppedLine","steppedLine"},
        };
        private static FileStream stream = new FileStream(@"C:\Users\Ritesh Raj\Documents\temp.txt",FileMode.Append);
        /// <summary>
        /// convert to JSON
        /// </summary>
        /// <param name="data">only object having properties of complex type and primitve type(string[],int[],string,int,bool)</param>
        /// <param name="indent">specify the indent</param>
        /// <param name="skipKeys">specify the keys which need to be omitted</param>
        /// <returns>returns JSON of the object passed</returns>
        public static string ToJSON(object data, int indent = 0, string[] skipKeys = null)
        {
            skipKeys = skipKeys ?? new string[0];
            string json = "";
            Type instanceType = data.GetType();
            PropertyInfo[] properties = instanceType.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                string key = property.Name;
                if (skipKeys.Any(ele => ele.Contains(key)) || property.GetValue(data) == null)
                {
                    //if any string in skipKeys is key, then skip that property
                    //if the value of the property is null, then skip that property
                    continue;
                }
                //if property name is present in _mapper, substitute it for chart js object
                foreach (var pair in _mapper)
                {
                    if (pair.Key.Equals(key))
                    {
                        key = pair.Value;
                        break;
                    }
                }
                key = char.ToLower(key[0]).ToString() + key.Substring(1);

                string writeToFile = key + " : " + property.GetValue(data) + "\n";
                byte[] byteArray = System.Text.Encoding.ASCII.GetBytes(writeToFile);
                stream.Write(byteArray, 0, byteArray.Length);

                string value = "";
                if (property.PropertyType == typeof(string[]))
                {
                    string[] values = (string[])property.GetValue(data);
                    value += "[";
                    foreach (string item in values)
                    {
                        value += "'" + item + "',";
                    }
                    value = value.TrimEnd(',') + "]";
                }
                else if (property.PropertyType == typeof(int[]))
                {
                    int[] values = (int[])property.GetValue(data);
                    value += "[";
                    foreach (int item in values)
                    {
                        value += item + ",";
                    }
                    value = value.TrimEnd(',') + "]";
                }
                else if (property.PropertyType == typeof(int?) || property.PropertyType == typeof(double?))
                {
                    value = property.GetValue(data).ToString();
                }
                else if (property.PropertyType == typeof(bool?))
                {
                    value = property.GetValue(data).ToString();
                    value = char.ToLower(value[0]).ToString() + value.Substring(1);
                }
                else if (property.PropertyType == typeof(string))
                {
                    value = "'" + property.GetValue(data).ToString() + "'";
                }
                else if (property.PropertyType.ToString().Contains("[]")) //array of the complex_type (complex_type[])
                {
                    object[] objArray = (object[])property.GetValue(data);
                    value = "[";
                    foreach (object item in objArray)
                    {
                        value += "{\n" + ToJSON(item, ++indent, skipKeys) + Indent(indent) + "},";
                        --indent;
                    }
                    value = value.TrimEnd(',') + "]";
                }
                else//complex_type
                {
                    value = "{\n" + ToJSON(property.GetValue(data), ++indent, skipKeys);
                    --indent;
                    value += Indent(indent) + "}";
                }
                json += Indent(indent) + key + ":" + value + ",\n";
            }
            return json.TrimEnd(',');
        }
        /// <summary>
        /// to apply indent to the getting geneated JSON
        /// </summary>
        /// <param name="far">specify the number of tab's from left margin</param>
        /// <returns>returns no. of tabs</returns>
        private static string Indent(int far)
        {
            string indent = "";
            for (int i = 01; i <= far; i++)
            {
                indent += "\t";
            }
            return indent;
        }
    }
}