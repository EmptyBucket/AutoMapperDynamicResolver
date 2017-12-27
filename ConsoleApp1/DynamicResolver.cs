using System;
using AutoMapper;

namespace ConsoleApp1
{
    public class DynamicResolver<TSource, TDest, TDestMember, TService>
        : IValueResolver<TSource, TDest, TDestMember>
    {
        private readonly Func<TService, TSource, object> func;

        public DynamicResolver(Func<TService, TSource, object> func)
        {
            this.func = func;
        }

        public TDestMember Resolve(TSource source, TDest destination, TDestMember destMember, ResolutionContext context)
        {
            var service = context.Options.CreateInstance<TService>();
            return context.Mapper.Map<TDestMember>(func(service, source));
        }
    }
}