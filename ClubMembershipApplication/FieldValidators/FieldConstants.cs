using System;
using System.Collections.Generic;
using System.Text;

namespace ClubMembershipApplication.FieldValidators
{
    internal class FieldConstants
    {
        public enum UserRegistrationField
        {
            EmailAddress, FirstName, LastName, Password, PasswordCompare, DateOfBirth, PhoneNumber, AddressFirstLine, AddressSecondLine, AddressCity, PostalCode
        }
    }
}
