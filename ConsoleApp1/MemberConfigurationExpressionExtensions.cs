using AutoMapper;

namespace ConsoleApp1
{
    public static class MemberConfigurationExpressionExtensions
    {
        public static ServiceResolvingConfiguration<TSource, TDest, TDestMember> ResolveUsing<TSource, TDest, TDestMember>(
            this IMemberConfigurationExpression<TSource, TDest, TDestMember> configurationExpression)
        {
            return new ServiceResolvingConfiguration<TSource, TDest, TDestMember>(configurationExpression);
        }
    }
}