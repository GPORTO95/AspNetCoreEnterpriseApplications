using SE.Core.DomainObjects;

namespace SE.Core.Data
{
    public interface IRepository<T> : IDisposable where T : IAggregateRoot
    {

    }
}
