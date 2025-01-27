
namespace SIPConnector.Domain.Buy.Repositories
{
    public interface IBuyRepository
    {
        public Task<Buy> GetBuyAsync(int id);
        public Task<Guid> CreateBuyAsync(Buy buy);
        public Task<bool> AnnularBuyAsync(Guid id);
    }
}
