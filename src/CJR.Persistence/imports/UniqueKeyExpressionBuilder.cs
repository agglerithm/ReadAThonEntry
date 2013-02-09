namespace CJR.Persistence.imports
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Reflection;
    using FluentNHibernate.Data;
    using NCommon.Extensions;

    public interface IUniqueKeyExpressionBuilder
    {
        Expression<Func<T,bool>> BuildExpressionFor<T>(T e) where T: Entity;
    }

    public class UniqueKeyExpressionBuilder : IUniqueKeyExpressionBuilder
    {
        public  Expression<Func<T,bool>> BuildExpressionFor<T>(T e) where T: Entity
        {

            var info = new TypeDelegator(e.GetType());
            var props = info.GetProperties();
            var uniqueKeyList = props.Where<PropertyInfo>(p =>
                                            {
                                                var attrs = p.GetCustomAttributes(true);
                                                return(attrs.Length > 0 && attrs.Where(a => a.GetType() == typeof(CompositeIdAttribute)).Count() > 0)
                                                    ;
                                            });
            if (uniqueKeyList == null || uniqueKeyList.Count() == 0) return null;
            var parentExpression = Expression.Parameter(e.GetType(), "e"); 
            Expression exp = null;
            uniqueKeyList.ForEach(f =>
                                      {
                                          var meth = f.GetGetMethod();
                                          var parm = Expression.Property(parentExpression,meth);
                                          var cnst =
                                              Expression.Constant(f.GetValue(e, BindingFlags.GetProperty, null, null, null), f.PropertyType);
                                          exp = appendExpression(exp, Expression.Equal(parm, cnst));
                                      });
            return Expression.Lambda < Func<T, bool>>(exp, parentExpression);
            
        }

        private Expression appendExpression(Expression  exp, BinaryExpression equal)
        {
            if (exp == null)
                return  equal;
            return  Expression.AndAlso(exp, equal);

        }
    }
}
