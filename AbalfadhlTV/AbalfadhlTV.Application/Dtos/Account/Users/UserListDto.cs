﻿using AbalfadhlTV.Common.Contracts;

namespace AbalfadhlTV.Application.Dtos.Account.Users
{
    public class UserListDto
    {
        public long Id { get; set; }
        public string Email { get; set; }
        public List<Link> Links { get; set; }

    }
}
