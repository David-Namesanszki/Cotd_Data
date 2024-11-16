using Cotd_Data.Models.Captains;

namespace Cotd_Data._Interfaces
{
    public interface ICaptainRepository : IBaseRepository<CaptainData>
    {
        void UpdateCaptain(string id, string name, int health, int power, int armor, string image, IList<string> cardIds);
    }
}