using Cotd_Data.Models.Cards;

namespace Cotd_Data.Repositories.CardRepositories.Interfaces
{
    public interface ICommandCardRepository : IBaseRepository<CommandCardData>
    {
        CommandCardData GetOne(int id);
        void UpdateCard(int id, string name, string description, string image, int envoyCost);
    }
}