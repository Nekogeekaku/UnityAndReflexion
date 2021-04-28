using System;
namespace Example1.Attributes
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public class Selectables : Attribute
    {
       
    }
}
