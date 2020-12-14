using CVManager.Application.DTO;
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
    }
}
