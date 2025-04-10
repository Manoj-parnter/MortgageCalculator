//using System.Collections.Generic;
//using System;
//using System.Linq;
//using MortgageCalculator.Data;
//using MortgageCalculator.Data.Models;

//namespace MortgageCalculator.Web.Repos
//{
//    public interface IMortgageRepo
//    {
//        List<Mortgage> GetAllMortgages();
//    }

//    public class MortgageRepo : IMortgageRepo
//    {
//        private readonly MortgageDataContext _context;

//        public MortgageRepo(MortgageDataContext context)
//        {
//            _context = context;
//        }

//        public List<Mortgage> GetAllMortgages()
//        {
//            return _context.Mortgages.ToList();
//        }
//        //public List<Mortgage> GetAllMortgages()
//        //{
//        //    using (var context = new MortgageDataContext())
//        //    {
//        //        var mortgages = context.Mortgages.ToList();
//        //        List<Mortgage> result = new List<Mortgage>();
//        //        foreach (var mortgage in mortgages)
//        //        {
//        //            result.Add(new Mortgage()
//        //            {
//        //                Name = mortgage.Name,
//        //                EffectiveStartDate = mortgage.EffectiveStartDate,
//        //                EffectiveEndDate = mortgage.EffectiveEndDate,
//        //                CancellationFee = mortgage.CancellationFee,
//        //                EstablishmentFee = mortgage.CancellationFee,
//        //                InterestRepayment = (InterestRepayment)Enum.Parse(typeof(InterestRepayment), mortgage.MortgageType.ToString()),
//        //                MortgageId = mortgage.MortgageId,
//        //                MortgageType = (MortgageType)Enum.Parse(typeof(MortgageType), mortgage.MortgageType.ToString()),
//        //                //TermsInMonths = mortgage.TermsInMonths
//        //            }
//        //            );
//        //        }
//        //        return result;
//        //    }
//        //}
//    }
//}