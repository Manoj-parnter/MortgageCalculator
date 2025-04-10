//using MortgageCalculator.Dto;
//using MortgageCalculator.Web.Repos;
//using System.Collections.Generic;

//namespace MortgageCalculator.Web.Services
//{
//    public interface IMortgageService
//    {
//        List<MortgageDto> GetAllMortgages();
//    }

//    public class MortgageService : IMortgageService
//    {

//        private readonly IMortgageRepo _mortgageRepo;
//        public MortgageService() : this(new MortgageRepo())
//        { }

//        public MortgageService(IMortgageRepo mortgageRepo)
//        {
//            this._mortgageRepo = mortgageRepo;
//        }

//        public List<MortgageDto> GetAllMortgages()
//        {
//            return _mortgageRepo.GetAllMortgages();
//        }
//    }
//}