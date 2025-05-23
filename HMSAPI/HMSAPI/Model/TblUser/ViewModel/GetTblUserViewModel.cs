﻿using System.ComponentModel.DataAnnotations;

namespace HMSAPI.Model.TblUser.ViewModel
{
    public class GetTblUserViewModel///:TblUserModel
    {
        [Key]
        public int UserId { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? RoleName { get; set; }
    }
}
