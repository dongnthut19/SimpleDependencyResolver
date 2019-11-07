using SimpleDependencyResolver.Abstracts.Data;

namespace SimpleDependencyResolver.Data
{
    public class TypeB : ITypeB
    {
        private readonly ITypeC _typeC;
        public TypeB(ITypeC typeC)
        {
            _typeC = typeC;
        }
        public string RequireTypeCToGetValue()
        {
            return _typeC.GetTypeC();
        }
    }
}