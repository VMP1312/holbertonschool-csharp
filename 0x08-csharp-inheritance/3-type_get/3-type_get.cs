using System;
using System.Reflection;
using System.Collections.Generic;
using System.Text;

/// <summary> Class Obj</summary>
class Obj
{
    /// <summary> Inherits from empty class Animal</summary>
    public static void Print(object myObj)
    {
        TypeInfo type = myObj.GetType().GetTypeInfo();
        IEnumerable<PropertyInfo> propList = type.GetProperties();
        IEnumerable<MethodInfo> methList = type.GetMethods();

        Console.WriteLine(type.Name + ' ' + "Properties:");
        foreach (PropertyInfo prop in propList)
        {
            Console.WriteLine(prop.Name);
        }

        Console.WriteLine(type.Name + ' ' + "Methods:");

        foreach (MethodInfo meth in methList)
        {
            Console.WriteLine(meth.Name);
        }
    }
}
