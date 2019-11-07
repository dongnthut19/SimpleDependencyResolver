using SimpleDependencyResolver.Abstracts.Data;

namespace SimpleDependencyResolver.Data
{
    public class TypeA : ITypeA
    {
        private readonly ITypeB _typeB;
        public TypeA(ITypeB typeB)
        {
            _typeB = typeB;
        }
        public string RequireTypeBToGetValue()
        {
            return _typeB.RequireTypeCToGetValue();
        }
    }
}