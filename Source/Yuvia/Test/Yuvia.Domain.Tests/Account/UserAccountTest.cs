﻿using System;
using Xunit;
using Yuvia.Domain.Account.Entities;

namespace Yuvia.Domain.Tests.Account
{
    public class UserAccountTest
    {
        [Fact]
        public void ValidateUserAccount()
        {
            // Arrange
            var invalidUserAccount = new UserAccount
            {
                Username = null,
                Password = "abc12",
                FirstName = "Johny",
                LastName = "Rulan"
            };


            var validUserAccount = new UserAccount
            {
                Username = "johnyrulan",
                Password = "abc12345",
                FirstName = "Johny",
                LastName = "Rulan",
                Email = "johny@codehuntsman.com",
                HasSignedLatestTerms = true,
                SignUpDate = DateTime.Now
            };

            // Act
            // Assert
            Assert.True( validUserAccount.IsValid );
            Assert.False( invalidUserAccount.IsValid );
        }
    }
}
