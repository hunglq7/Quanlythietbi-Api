﻿namespace WebApi.Models.Common
{
    public class PagedResult<T> : PagedResultBase
    {
        public List<T>? Items { set; get; }
    }
}
