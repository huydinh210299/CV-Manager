using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CVManager.Application.DTO;
using CVManager.Application.Interface;
using CVManager.Data.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CVManager.WebApp.Controllers.API
{
    [Route("api/post")]
    [Authorize(Roles = "ROLE_ENTERPRISE")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostService _postService;
        private readonly IEnterpriseService _enterpriseService;
        public PostController(IPostService postService, IEnterpriseService enterpriseService)
        {
            this._postService = postService;
            this._enterpriseService = enterpriseService;
        }

        [Route("getid")]
        [HttpGet]
        public string getid()
        {
            return (User.Claims.FirstOrDefault(c => c.Type == "ID").Value);
        }

        [Route("create")]
        [HttpPost]
        public async Task<IActionResult> create([FromBody] PostInfo postInfo)
        {
            var acountID = User.Claims.FirstOrDefault(c => c.Type == "ID").Value;
            var ID = Guid.Parse(acountID);
            var rs = await _postService.createPost(ID, postInfo);
            if(rs == 0)
            {
                return Ok(new BaseResponse(400, "Tạo mới bài viết thất bại"));
            }
            else
            {
                return Ok(new BaseResponse(200, "Tạo mới bài viết thành công"));
            }
        }

        [AllowAnonymous]
        [Route("getpost")]
        public List<PostItem> get()
        {
            return _postService.listPost(1, "", "");
        }

        //[AllowAnonymous]
        [Route("listpost")]
        [HttpGet]
        public async Task<List<Post>> listPost()
        {
            var acountID = Guid.Parse(User.Claims.FirstOrDefault(c => c.Type == "ID").Value);
            return await _postService.getPostByEntID(acountID);
        }

        [Route("{id}")]
        [HttpGet]
        public Post getPostByID(string id)
        {
            Guid ID = Guid.Parse(id);
            return _postService.getPostByID(ID);
        }

        [Route("edit")]
        [HttpPost]
        public IActionResult editPost([FromBody] PostInfo postInfo)
        {
            var rs =  _postService.editPost(postInfo);
            if (rs == 0)
            {
                return Ok(new BaseResponse(400, "Sửa bài viết thất bại"));
            }
            else
            {
                return Ok(new BaseResponse(200, "Sửa bài viết thành công"));
            }
        }
    }
}
