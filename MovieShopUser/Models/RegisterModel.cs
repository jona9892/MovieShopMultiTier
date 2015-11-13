﻿using DomainModel.DomainModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieShopUser.Models
{
    public class RegisterModel
    {
        private string _password;

        [StringLength(20, MinimumLength = 6, ErrorMessage = "The password needs to have a length of 6-20.")]
        public string Password
        {
            get { return _password; }
            set
            {
                if(_password == null)
                {
                    VerifiedPassword = value;
                }
                _password = value;
            }
        }
        [Compare("Password", ErrorMessage = "Passwords are not the same.")]
        public string VerifiedPassword { get; set; }
        public Customer Customer { get; set; }
    }
}