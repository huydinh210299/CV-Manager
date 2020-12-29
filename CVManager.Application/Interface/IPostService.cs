using CVManager.Application.DTO;
using CVManager.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CVManager.Application.Interface
{
    public interface IPostService
    {
        Task<int> createPost(Guid entID, PostInfo info);
        List<PostItem> listPost(int page,string title, string area);
        PostItem postInfo(string postID);
        Task<List<Post>> getPostByEntID(Guid entID);
        Post getPostByID(Guid postID);
        int editPost(PostInfo info);
    }
}
