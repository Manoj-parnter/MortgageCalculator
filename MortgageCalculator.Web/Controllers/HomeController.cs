using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MortgageCalculator.Data.Models;
using MortgageCalculator.Dto;
using MortgageCalculator.Dto.Interfaces;

namespace MortgageCalculator.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMortgage _iMortgage;

        public HomeController(IMortgage iMortgage)
        {
            _iMortgage = iMortgage;
        }

        public ActionResult Index()
        {
            var mortgages = _iMortgage.GetAllMortgages();

            ViewBag.MortgageTypes = GetMortgageTypes();
            ViewBag.InterestRepayments = GetInterestRepayments();

            return View(mortgages);
        }
        public ActionResult Create()
        {
            ViewBag.MortgageTypes = GetMortgageTypes();
            ViewBag.InterestRepayments = GetInterestRepayments();

            var model = new Mortgage();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Mortgage mortgage)
        {
            if (ModelState.IsValid)
            {
                _iMortgage.AddMortgage(mortgage);
                return RedirectToAction("Index");
            }

            ViewBag.MortgageTypes = GetMortgageTypes();
            ViewBag.InterestRepayments = GetInterestRepayments();

            return View(mortgage);
        }

        public ActionResult Edit(int id)
        {
            var mortgage = _iMortgage.GetMortgageById(id);
            if (mortgage == null)
            {
                return HttpNotFound();
            }

            var mortgageTypes = Enum.GetValues(typeof(MortgageType))
                .Cast<MortgageType>()
                .Select(m => new SelectListItem
                {
                    Text = m.ToString(),
                    Value = ((int)m).ToString(),
                    Selected = (int)m == mortgage.MortgageType
                }).ToList();

            var interestRepayments = Enum.GetValues(typeof(InterestRepayment))
                .Cast<InterestRepayment>()
                .Select(ir => new SelectListItem
                {
                    Text = ir.ToString(),
                    Value = ((int)ir).ToString(),
                    Selected = (int)ir == mortgage.InterestRepayment
                }).ToList();

            ViewBag.MortgageTypes = mortgageTypes;
            ViewBag.InterestRepayments = interestRepayments;

            return View(mortgage);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Mortgage mortgage)
        {
            if (ModelState.IsValid)
            {
                _iMortgage.UpdateMortgage(mortgage);
                return RedirectToAction("Index");
            }

            ViewBag.MortgageTypes = GetMortgageTypes();
            ViewBag.InterestRepayments = GetInterestRepayments();

            return View(mortgage);
        }

        public ActionResult Delete(int id)
        {
            var mortgage = _iMortgage.GetMortgageById(id);
            if (mortgage != null)
            {
                _iMortgage.DeleteMortgage(id);
            }

            return RedirectToAction("Index");
        }
        private List<SelectListItem> GetMortgageTypes()
        {
            return new List<SelectListItem>
            {
                new SelectListItem { Text = "Fixed", Value = "1" },
                new SelectListItem { Text = "Variable", Value = "2" },
                new SelectListItem { Text = "Adjustable", Value = "3" }
            };
        }

        private List<SelectListItem> GetInterestRepayments()
        {
            return new List<SelectListItem>
            {
                new SelectListItem { Text = "Monthly", Value = "1" },
                new SelectListItem { Text = "Quarterly", Value = "2" },
                new SelectListItem { Text = "Annually", Value = "3" }
            };
        }

        //public decimal CalculateTotalRepayment(decimal loanAmount, decimal interestRate, int loanDurationInMonths)
        //{
        //    decimal monthlyRate = interestRate / 12 / 100;
        //    decimal monthlyPayment = loanAmount * monthlyRate / (1 - (decimal)Math.Pow((double)(1 + monthlyRate), -loanDurationInMonths));
        //    return monthlyPayment * loanDurationInMonths;
        //}

        //public decimal CalculateTotalInterest(decimal loanAmount, decimal totalRepayment)
        //{
        //    return totalRepayment - loanAmount;
        //}
    }
}