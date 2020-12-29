using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CVManager.Application.Interface;
using CVManager.WebApp.Authentication;
using CVManager.WebApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CVManager.WebApp.Controllers
{
    [Route("cvmanager")]
    public class CVManagerController : Controller
    {
        private readonly IUserService _userService;
        private readonly ICVService _cVService;

        public CVManagerController(IUserService userService, ICVService cVService)
        {
            this._userService = userService;
            this._cVService = cVService;
        }

        public IActionResult Index()
        {
            var user = _userService.checkUserFromToken();
            if (user == null)
            {
                return Redirect("/redirect");
            }
            else
            {
                var listCV = _cVService.getCVbyUserID(user);
                List<CVManagerModal> model = new List<CVManagerModal>();
                listCV.ForEach(cv =>
                {
                    model.Add(new CVManagerModal()
                    {
                        CVID = cv.ID,
                        CVName = cv.CvName,
                        CVImage = cv.Type,
                        CreateDate = (DateTime)cv.createDate,
                        isChoosen = cv.Is_choosen
                    });
                });
                return View(model);
            }
        }

        [Route("edit/{ID}")]
        public IActionResult Edit(Guid ID)
        {
            var user = _userService.checkUserFromToken();
            if (user == null)
            {
                return Redirect("/redirect");
            }
            else
            {
                var cvInfo = _cVService.getByID(ID);
                var cvDetailModal = new CVDetailModal()
                {
                    Html = cvInfo.Html,
                    Css = cvInfo.Css,
                    ID = cvInfo.ID,
                };
                return View(cvDetailModal);
            }
        }

        [Route("detail/{ID}")]
        public IActionResult CVDetail(Guid ID)
        {
            var user = _userService.checkUserFromToken();
            if (user == null)
            {
                return Redirect("/redirect");
            }
            else
            {
                var cvInfo = _cVService.getByID(ID);
                var cvDetail = new CVDetailModal()
                {
                    Html = cvInfo.Html,
                    Css = cvInfo.Css,
                    ID = cvInfo.ID
                };
                return View(cvDetail);
            }
        }

        [Route("mainCVdetail/{ID}")]
        public IActionResult MainCVDetail(Guid ID)
        {
            var cvInfo = _cVService.getByID(ID);
            var cvDetail = new CVDetailModal()
            {
                Html = cvInfo.Html,
                Css = cvInfo.Css,
                ID = cvInfo.ID
            };
            return View(cvDetail);
        }
    }
}
