using CJR.Common.Extensions;

namespace CJR.Persistence
{
    using System.Reflection;
    using FluentNHibernate.Data; 

    public static class EntityExtensions
    {
        public static string GetLogMessage(this Entity obj)
        {
            var tpe = obj.GetType();
            var val = string.Format("Entity name:{0};", tpe.Name);
            var info = new TypeDelegator(tpe);
            var props = info.GetProperties();
            props.ForEach(p => val += string.Format("{0}='{1}',", p.Name, tpe.InvokeMember(p.Name, BindingFlags.GetProperty, null, obj, null)));
            return val;
        }
    }
}
