using System;
using System.Collections.Generic;
using System.Linq;
using MortgageCalculator.Data;
using MortgageCalculator.Data.Models;
using MortgageCalculator.Dto.Interfaces;

namespace MortgageCalculator.Dto.Repos
{
    public class MortgageRepos : IMortgage
    {
        private readonly MortgageDataContext _context;

        public MortgageRepos(MortgageDataContext context)
        {
            _context = context;
        }

        public void AddMortgage(Mortgage mortgage)
        {
            if (mortgage == null) throw new ArgumentNullException(nameof(mortgage));

            _context.Mortgage.Add(mortgage);
            _context.SaveChanges();
        }

        public void DeleteMortgage(int id)
        {
            var mortgage = _context.Mortgage.Find(id);
            if (mortgage == null) return;

            _context.Mortgage.Remove(mortgage);
            _context.SaveChanges();
        }

        public IEnumerable<Mortgage> GetAllMortgages()
        {
            return _context.Mortgage.ToList();
        }

        public Mortgage GetMortgageById(int id)
        {
            return _context.Mortgage.FirstOrDefault(m => m.MortgageId == id);
        }

        public void UpdateMortgage(Mortgage mortgage)
        {
            if (mortgage == null) throw new ArgumentNullException(nameof(mortgage));

            var existingMortgage = _context.Mortgage.Find(mortgage.MortgageId);
            if (existingMortgage == null) return;

            existingMortgage.Name = mortgage.Name;
            existingMortgage.MortgageType = mortgage.MortgageType;
            existingMortgage.InterestRepayment = mortgage.InterestRepayment;
            existingMortgage.EffectiveStartDate = mortgage.EffectiveStartDate;
            existingMortgage.EffectiveEndDate = mortgage.EffectiveEndDate;
            existingMortgage.TermsInMonths = mortgage.TermsInMonths;
            existingMortgage.CancellationFee = mortgage.CancellationFee;
            existingMortgage.EstablishmentFee = mortgage.EstablishmentFee;

            _context.SaveChanges();
        }
    }
}
