using ClubMembershipApplication.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubMembershipApplication.Data
{
    internal interface ILogin
    {
        User Login(string emailAddress, string password);
    }
}
