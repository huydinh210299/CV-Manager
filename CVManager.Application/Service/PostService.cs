using CVManager.Application.DTO;
using CVManager.Application.Interface;
using CVManager.Data.EF;
using CVManager.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace CVManager.Application.Service
{
    public class PostService : IPostService
    {
        private readonly CVManagerDBContext _dbContext;
        private readonly IEnterpriseService _enterpriseService;

        public PostService(CVManagerDBContext dbContext, IEnterpriseService enterpriseService)
        {
            this._dbContext = dbContext;
            this._enterpriseService = enterpriseService;
        }

        public async Task<int> createPost(Guid ID, PostInfo info)
        {
            var ent = await _enterpriseService.getEnterpriseFromAcountID(ID);
            var post = new Post()
            {
                Title = info.Title,
                Address = info.Address,
                ExactAddress = info.ExactAddress,
                Position = info.Position,
                Gender = info.Gender,
                Salary = info.Salary,
                Amount = info.Amount,
                Experience = info.Experience,
                Reciever = info.Reciever,
                Phone_Reciever = info.Phone_Reciever,
                Email_Reciever = info.Email_Reciever,
                Description = info.Description,
                Require = info.Require,
                Benefit = info.Benefit,
                Skill = info.Skill,
                Submit_Deadline = DateTime.ParseExact(info.Submit_Deadline, "dd/MM/yyyy", null)
            };
            post.Type = 1;
            _dbContext.Posts.Add(post);
            post.Enterprise = ent;
            return await _dbContext.SaveChangesAsync();
        }

        public List<PostItem> listPost(int page, string title, string area)
        {
            var rs = (from p in _dbContext.Posts
                      join ef in _dbContext.EnterpriseInfos
                      on p.Enterprise.ID equals ef.ID_Enterprise
                      where (string.IsNullOrEmpty(title) || p.Title.ToLower().Contains(title.ToLower())) && (string.IsNullOrEmpty(area) || p.Address.ToLower() == area.ToLower())
                      select new PostItem()
                      {
                          Company_Name = ef.Company_Name,
                          Post_ID = p.ID,
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
                      }
                      ).Skip(10 * (page - 1)).Take(10).ToList();
            return rs;
        }

        public PostItem postInfo(string postID)
        {
            var ID = Guid.Parse(postID);
            var rs = (from p in _dbContext.Posts
                      join ef in _dbContext.EnterpriseInfos
                      on p.Enterprise.ID equals ef.ID_Enterprise
                      where p.ID == ID
                      select new PostItem()
                      {
                          Company_Name = ef.Company_Name,
                          Post_ID = p.ID,
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
                      }).FirstOrDefault();
            return rs;
        }
    }
}
