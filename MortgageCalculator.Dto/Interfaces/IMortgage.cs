using System.Collections.Generic;
using MortgageCalculator.Data.Models;

namespace MortgageCalculator.Dto.Interfaces
{
    public interface IMortgage
    {
        IEnumerable<Mortgage> GetAllMortgages();
        Mortgage GetMortgageById(int id);
        void AddMortgage(Mortgage mortgage);
        void UpdateMortgage(Mortgage mortgage);
        void DeleteMortgage(int id);
    }
}
