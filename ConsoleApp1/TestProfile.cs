using AutoMapper;
using WebApplication2;

namespace ConsoleApp1
{
    public class TestProfile : Profile
    {
        public TestProfile()
        {
            CreateMap<Test, TestM>()
                .ForMember(m => m.First, expression => expression.ResolveUsing().FromService<TestService>(service => service.GetFirst))
                .ForMember(m => m.First, expression => expression.ResolveUsing().FromService<TestService>((service, test) => service.GetFirst(test)));
        }
    }
}