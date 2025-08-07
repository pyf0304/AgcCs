using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestTree
{
  public  class clsPubFun
    {
        public static object GetObjectProperty(object obj, string strPropName)
        {
            Type t = obj.GetType();//获取Obj的类型
            System.Reflection.PropertyInfo propertyInfo = t.GetProperty(strPropName);//通过字符串"Value"访问Obj的类型的属性Value的属性信息（propertyInfo）
            //propertyInfo.SetValue(obj, "BB", null);//通过属性信息，使用对象实例赋值。


            object myObj = propertyInfo.GetValue(obj, null);//通过属性信息，使用对象实例赋值。
            return myObj;
        }

        public static object GetObjectFieldValue(object obj, string strPropName)
        {
            Type t = obj.GetType();//获取Obj的类型
            System.Reflection.FieldInfo fieldInfo = t.GetField(strPropName);//通过字符串"Value"访问Obj的类型的属性Value的属性信息（propertyInfo）
            //propertyInfo.SetValue(obj, "BB", null);//通过属性信息，使用对象实例赋值。


            object myObj = fieldInfo.GetValue(obj);//通过属性信息，使用对象实例赋值。
            return myObj;
        }
  
      public static object GetObjectProperty2(object obj, string strPropName)
      {
          Type t = obj.GetType();//获取Obj的类型
          System.Reflection.PropertyInfo[] arrPropertyInfo = t.GetProperties();// t.GetProperty(strPropName);//通过字符串"Value"访问Obj的类型的属性Value的属性信息（propertyInfo）

          //propertyInfo.SetValue(obj, "BB", null);//通过属性信息，使用对象实例赋值。


          object myObj = arrPropertyInfo[0].GetValue(obj, null);//通过属性信息，使用对象实例赋值。
          return myObj;
      }
       public static List<string> GetObjectMembers(object obj)
      {
          Type t = obj.GetType();//获取Obj的类型
          System.Reflection.MemberInfo[] arrPropertyInfo = t.GetMembers();// t.GetProperty(strPropName);//通过字符串"Value"访问Obj的类型的属性Value的属性信息（propertyInfo）

          //propertyInfo.SetValue(obj, "BB", null);//通过属性信息，使用对象实例赋值。
          List<string> arrMembers = new List<string>();
          foreach (System.Reflection.MemberInfo member in arrPropertyInfo)
          {
              arrMembers.Add(member.Name + ":" + member.MemberType.ToString());
          }
          return arrMembers;
      }
      public static void SetObjectProperty(object obj, string strPropName, object objValue)
      {
          Type t = obj.GetType();//获取Obj的类型
          System.Reflection.PropertyInfo propertyInfo = t.GetProperty(strPropName);//通过字符串"Value"访问Obj的类型的属性Value的属性信息（propertyInfo）
          propertyInfo.SetValue(obj, objValue, null);//通过属性信息，使用对象实例赋值。

      }

    }
}
