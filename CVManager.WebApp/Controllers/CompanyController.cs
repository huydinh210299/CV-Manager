using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CVManager.Application.Interface;
using CVManager.WebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CVManager.WebApp.Controllers
{
    [Route("company")]
    public class CompanyController : Controller
    {
        private readonly IEnterpriseService _enterpriseService;
        public CompanyController(IEnterpriseService enterpriseService)
        {
            this._enterpriseService = enterpriseService;
        }
        public IActionResult Index()
        {
            var listCompany = _enterpriseService.getListEnt("","", 1);
            List<CompanyModel> model = new List<CompanyModel>();
            listCompany.ForEach(c =>
            {
                model.Add(new CompanyModel()
                {
                    EntID = c.ID,
                    CompanyName = c.EnterpriseInfo.Company_Name,
                    Area = c.EnterpriseInfo.Area,
                    Email = c.EnterpriseInfo.Email
                });
            });
            return View(model);
        }

        [Route("info/{entID}")]
        public IActionResult Info(string entID)
        {
            var ID = Guid.Parse(entID);
            var entInfo = _enterpriseService.getEntInfo(ID);
            CompanyInfoModel model = new CompanyInfoModel()
            {
                Area = entInfo.EnterpriseInfo.Area,
                CompanyName = entInfo.EnterpriseInfo.Company_Name,
                Email = entInfo.EnterpriseInfo.Email,
                Phone = entInfo.EnterpriseInfo.Phone,
                Posts = entInfo.Posts.ToList(),
                Website = entInfo.EnterpriseInfo.Website,
                Scale = entInfo.EnterpriseInfo.Scale
            };
            return View(model);
        }


        [HttpPost]
        [Route("search")]
        public IActionResult Search([FromForm] CompanySearch company)
        {
            var listCompany = _enterpriseService.getListEnt(company.CompanyName, company.Address, company.Page);
            List<CompanyModel> model = new List<CompanyModel>();
            listCompany.ForEach(c =>
            {
                model.Add(new CompanyModel()
                {
                    EntID = c.ID,
                    CompanyName = c.EnterpriseInfo.Company_Name,
                    Area = c.EnterpriseInfo.Area,
                    Email = c.EnterpriseInfo.Email
                });
            });
            var tupleModel = new Tuple<List<CompanyModel>, CompanySearch>(model, company);
            return View(tupleModel);
        }
    }
}
