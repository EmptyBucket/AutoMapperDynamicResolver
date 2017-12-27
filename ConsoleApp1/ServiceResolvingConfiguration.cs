using System;
using AutoMapper;

namespace ConsoleApp1
{
    public class ServiceResolvingConfiguration<TSource, TDest, TDestMember>
    {
        private readonly IMemberConfigurationExpression<TSource, TDest, TDestMember> configurationExpression;

        public ServiceResolvingConfiguration(IMemberConfigurationExpression<TSource, TDest, TDestMember> configurationExpression)
        {
            this.configurationExpression = configurationExpression;
        }

        public void FromService<TService>(Func<TService, Func<TSource, object>> func)
        {
            var dynamicResolver = new CurryDynamicResolver<TSource, TDest, TDestMember, TService>(func);
            configurationExpression.ResolveUsing(dynamicResolver);
        }

        public void FromService<TService>(Func<TService, TSource, object> func)
        {
            var dynamicResolver = new DynamicResolver<TSource, TDest, TDestMember, TService>(func);
            configurationExpression.ResolveUsing(dynamicResolver);
        }
    }
}