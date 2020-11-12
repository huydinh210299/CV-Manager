using System;
using System.Collections.Generic;
using System.Text;

namespace CVManager.Application.DTO
{
    public class BaseResponse
    {
        public BaseResponse(int statuscode, string responseText)
        {
            this.statusCode = statuscode;
            this.statusText = responseText;
        }

        public int statusCode { get; set; }
        public string statusText { get; set; }
    }
}
