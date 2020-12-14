using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CVManager.Application.DTO;
using CVManager.Application.Interface;
using CVManager.WebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CVManager.WebApp.Controllers
{
    [Route("post")]
    public class PostController : Controller
    {
        private readonly IUserService _userService;
        private readonly IPostService _postService;
        public PostController(IUserService userService, IPostService postService)
        {
            this._userService = userService;
            this._postService = postService;
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
                var listpost = _postService.listPost(1, "", "");
                List<PostModel> model = new List<PostModel>();
                listpost.ForEach(p =>
                {
                    model.Add(new PostModel()
                    {
                        Company_Name = p.Company_Name,
                        PostID = p.Post_ID,
                        Title = p.Title,
                        Address = p.Address,
                        ExactAddress = p.ExactAddress,
                        Position = p.Position,
                        Gender = p.Gender,
                        Salary = p.Salary,
                        Amount = p.Amount,
                        Experience = p.Experience,
                        Submit_Deadline = p.Submit_Deadline,
                        Reciever = p.Reciever,
                        Email_Reciever = p.Email_Reciever,
                        Phone_Reciever = p.Phone_Reciever,
                        Description = p.Description,
                        Require = p.Require,
                        Benefit = p.Benefit,
                        Skill = p.Skill
                    });
                });
                return View(model);
            }
        }

        [HttpGet]
        [Route("{postID}")]
        public IActionResult PostDetail(string postID)
        {
            var p = _postService.postInfo(postID);
            PostModel model = new PostModel()
            {
                Company_Name = p.Company_Name,
                Title = p.Title,
                Address = p.Address,
                ExactAddress = p.ExactAddress,
                Position = p.Position,
                Gender = p.Gender,
                Salary = p.Salary,
                Amount = p.Amount,
                Experience = p.Experience,
                Submit_Deadline = p.Submit_Deadline,
                Reciever = p.Reciever,
                Email_Reciever = p.Email_Reciever,
                Phone_Reciever = p.Phone_Reciever,
                Description = p.Description,
                Require = p.Require,
                Benefit = p.Benefit,
                Skill = p.Skill
            };
            return View(model);
        }

        [HttpPost]
        [Route("search")]
        public IActionResult Search([FromForm] PostSearch post)
        {
            var listpost = _postService.listPost(post.Page, post.Title, post.Address);
            List<PostModel> model = new List<PostModel>();
            listpost.ForEach(p =>
            {
                model.Add(new PostModel()
                {
                    Company_Name = p.Company_Name,
                    PostID = p.Post_ID,
                    Title = p.Title,
                    Address = p.Address,
                    ExactAddress = p.ExactAddress,
                    Position = p.Position,
                    Gender = p.Gender,
                    Salary = p.Salary,
                    Amount = p.Amount,
                    Experience = p.Experience,
                    Submit_Deadline = p.Submit_Deadline,
                    Reciever = p.Reciever,
                    Email_Reciever = p.Email_Reciever,
                    Phone_Reciever = p.Phone_Reciever,
                    Description = p.Description,
                    Require = p.Require,
                    Benefit = p.Benefit,
                    Skill = p.Skill
                });
            });
            var tupleModel = new Tuple<List<PostModel>, PostSearch>(model, post);
            return View(tupleModel);
        }
    }
}
