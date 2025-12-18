using ClubMembershipApplication.FieldValidators;
using ClubMembershipApplication.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubMembershipApplication.Views
{
    internal class WelcomeUserView : IView
    {
        User _user = null;   
        public WelcomeUserView(User user)
        {
           _user = user;
        }

        public IFieldValidator FieldValidator => null;

        public void RunView()
        {
            CommonOutputFormat.ChangeFontColor(FontTheme.Success);
            Console.WriteLine($"Welcome {_user.FirstName}!!{Environment.NewLine}Welcome to the Cycling Club, buddy!!");
            CommonOutputFormat.ChangeFontColor(FontTheme.Default);
            Console.ReadKey();
        }

    }
}
