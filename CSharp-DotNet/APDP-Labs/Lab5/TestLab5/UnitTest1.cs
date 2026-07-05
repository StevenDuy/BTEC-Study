using Lab5;
using System;
using System.Collections.Generic;
using Xunit;

namespace TestLab5
{
    public class UserManagerTests
    {
        [Fact]
        public void Register_ShouldReturnTrue_ForNewUser()
        {
            var userManager = new UserManager();
            var result = userManager.Register("testUser", "password123");
            Assert.True(result);
        }

        [Fact]
        public void Register_ShouldReturnFalse_ForDuplicateUsername()
        {
            var userManager = new UserManager();
            userManager.Register("testUser", "password123");
            var result = userManager.Register("testUser", "anotherPassword");
            Assert.False(result);
        }

        [Fact]
        public void Register_ShouldThrowException_ForEmptyUsernameOrPassword()
        {
            var userManager = new UserManager();
            Assert.Throws<ArgumentException>(() => userManager.Register("", "password123"));
            Assert.Throws<ArgumentException>(() => userManager.Register("testUser", ""));
        }

        [Fact]
        public void Login_ShouldReturnTrue_ForValidCredentials()
        {
            var userManager = new UserManager();
            userManager.Register("testUser", "password123");
            var result = userManager.Login("testUser", "password123");
            Assert.True(result);
        }

        [Fact]
        public void Login_ShouldReturnFalse_ForInvalidCredentials()
        {
            var userManager = new UserManager();
            userManager.Register("testUser", "password123");
            var result = userManager.Login("testUser", "wrongPassword");
            Assert.False(result);
        }

        [Fact]
        public void Register_ShouldHandleCaseSensitivity_ForUsername()
        {
            var userManager = new UserManager();
            userManager.Register("testUser", "password123");
            var result = userManager.Register("TestUser", "password123");
            Assert.True(result);
        }

        [Fact]
        public void Login_ShouldReturnFalse_ForUnregisteredUser()
        {
            var userManager = new UserManager();
            var result = userManager.Login("unregisteredUser", "password123");
            Assert.False(result);
        }

        [Theory]
        [InlineData("user1", "pass1", false)]
        [InlineData("user2", "pass2", true)]
        [InlineData("user1", "differentpass", false)]
        public void Register_ShouldHandleMultipleUsers(string username, string password, bool expected)
        {
            var userManager = new UserManager();
            userManager.Register("user1", "pass1");
            var result = userManager.Register(username, password);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Register_ShouldHandleWhitespaceOnlyInputs()
        {
            var userManager = new UserManager();
            Assert.Throws<ArgumentException>(() => userManager.Register("   ", "password123"));
            Assert.Throws<ArgumentException>(() => userManager.Register("testUser", "   "));
        }

        [Fact]
        public void Register_ShouldHandleUnicodeCharacters()
        {
            var userManager = new UserManager();
            var result = userManager.Register("测试用户", "密码123");
            Assert.True(result);
        }

        [Fact]
        public void Login_ShouldHandleUnicodeCharacters()
        {
            var userManager = new UserManager();
            userManager.Register("测试用户", "密码123");
            var result = userManager.Login("测试用户", "密码123");
            Assert.True(result);
        }

        [Fact]
        public void Register_ShouldHandleSpecialCharactersInPassword()
        {
            var userManager = new UserManager();
            var result = userManager.Register("testUser", "P@ssw0rd!@#$");
            Assert.True(result);
        }

        [Fact]
        public void Login_ShouldHandleSpecialCharactersInPassword()
        {
            var userManager = new UserManager();
            userManager.Register("testUser", "P@ssw0rd!@#$");
            var result = userManager.Login("testUser", "P@ssw0rd!@#$");
            Assert.True(result);
        }

        [Fact]
        public void Register_ShouldHandleVeryLongUsername()
        {
            var userManager = new UserManager();
            var longUsername = new string('a', 255);
            var result = userManager.Register(longUsername, "password123");
            Assert.True(result);
        }

        [Fact]
        public void Register_ShouldHandleVeryLongPassword()
        {
            var userManager = new UserManager();
            var longPassword = new string('a', 1024);
            var result = userManager.Register("testUser", longPassword);
            Assert.True(result);
        }

        [Fact]
        public void Register_ShouldHandleVeryShortPassword()
        {
            var userManager = new UserManager();
            var result = userManager.Register("testUser", "a");
            Assert.True(result);
        }

        [Fact]
        public void Login_ShouldHandleVeryLongUsername()
        {
            var userManager = new UserManager();
            var longUsername = new string('a', 255);
            userManager.Register(longUsername, "password123");
            var result = userManager.Login(longUsername, "password123");
            Assert.True(result);
        }

        [Fact]
        public void Login_ShouldHandleVeryLongPassword()
        {
            var userManager = new UserManager();
            var longPassword = new string('a', 1024);
            userManager.Register("testUser", longPassword);
            var result = userManager.Login("testUser", longPassword);
            Assert.True(result);
        }

        [Fact]
        public void Register_ShouldHandleSQLInjectionAttempt()
        {
            var userManager = new UserManager();
            var sqlInjection = "'; DROP TABLE Users; --";
            var result = userManager.Register(sqlInjection, "password123");
            Assert.True(result);
        }

        [Fact]
        public void Login_ShouldHandleSQLInjectionAttempt()
        {
            var userManager = new UserManager();
            var sqlInjection = "'; DROP TABLE Users; --";
            userManager.Register(sqlInjection, "password123");
            var result = userManager.Login(sqlInjection, "password123");
            Assert.True(result);
        }

        [Fact]
        public void Register_ShouldHandleXSSAttempt()
        {
            var userManager = new UserManager();
            var xssAttempt = "<script>alert('XSS')</script>";
            var result = userManager.Register(xssAttempt, "password123");
            Assert.True(result);
        }

        [Fact]
        public void Login_ShouldHandleXSSAttempt()
        {
            var userManager = new UserManager();
            var xssAttempt = "<script>alert('XSS')</script>";
            userManager.Register(xssAttempt, "password123");
            var result = userManager.Login(xssAttempt, "password123");
            Assert.True(result);
        }

        [Fact]
        public void Login_ShouldHandleConcurrentLogin()
        {
            var userManager = new UserManager();
            userManager.Register("testUser", "password123");
            var tasks = new List<Task<bool>>();
            for (int i = 0; i < 10; i++)
            {
                tasks.Add(Task.Run(() => userManager.Login("testUser", "password123")));
            }
            Task.WaitAll(tasks.ToArray());
            Assert.True(tasks.All(t => t.Result));
        }

        [Fact]
        public void Register_ShouldHandleMixedCasePasswords()
        {
            var userManager = new UserManager();
            var result = userManager.Register("testUser", "PaSsWoRd123");
            Assert.True(result);
        }

        [Fact]
        public void Login_ShouldHandleMixedCasePasswords()
        {
            var userManager = new UserManager();
            userManager.Register("testUser", "PaSsWoRd123");
            var result = userManager.Login("testUser", "PaSsWoRd123");
            Assert.True(result);
        }

        [Fact]
        public void Register_ShouldHandleNumericPasswords()
        {
            var userManager = new UserManager();
            var result = userManager.Register("testUser", "123456789");
            Assert.True(result);
        }

        [Fact]
        public void Login_ShouldHandleNumericPasswords()
        {
            var userManager = new UserManager();
            userManager.Register("testUser", "123456789");
            var result = userManager.Login("testUser", "123456789");
            Assert.True(result);
        }

        [Fact]
        public void Register_ShouldHandleSpecialUsernameCharacters()
        {
            var userManager = new UserManager();
            var specialCharsUsername = "user.name@domain.com";
            var result = userManager.Register(specialCharsUsername, "password123");
            Assert.True(result);
        }

        [Fact]
        public void Login_ShouldHandleSpecialUsernameCharacters()
        {
            var userManager = new UserManager();
            var specialCharsUsername = "user.name@domain.com";
            userManager.Register(specialCharsUsername, "password123");
            var result = userManager.Login(specialCharsUsername, "password123");
            Assert.True(result);
        }

        [Fact]
        public void Register_ShouldHandlePasswordWithSpaces()
        {
            var userManager = new UserManager();
            var result = userManager.Register("testUser", "pass word 123");
            Assert.True(result);
        }

        [Fact]
        public void Login_ShouldHandlePasswordWithSpaces()
        {
            var userManager = new UserManager();
            userManager.Register("testUser", "pass word 123");
            var result = userManager.Login("testUser", "pass word 123");
            Assert.True(result);
        }

        [Fact]
        public void Register_ShouldHandlePasswordWithTabs()
        {
            var userManager = new UserManager();
            var result = userManager.Register("testUser", "pass\tword\t123");
            Assert.True(result);
        }

        [Fact]
        public void Login_ShouldHandlePasswordWithTabs()
        {
            var userManager = new UserManager();
            userManager.Register("testUser", "pass\tword\t123");
            var result = userManager.Login("testUser", "pass\tword\t123");
            Assert.True(result);
        }

        [Fact]
        public void Register_ShouldHandlePasswordWithNewlines()
        {
            var userManager = new UserManager();
            var result = userManager.Register("testUser", "pass\nword\n123");
            Assert.True(result);
        }

        [Fact]
        public void Login_ShouldHandlePasswordWithNewlines()
        {
            var userManager = new UserManager();
            userManager.Register("testUser", "pass\nword\n123");
            var result = userManager.Login("testUser", "pass\nword\n123");
            Assert.True(result);
        }

        [Fact]
        public void Register_ShouldHandlePasswordWithCarriageReturns()
        {
            var userManager = new UserManager();
            var result = userManager.Register("testUser", "pass\rword\r123");
            Assert.True(result);
        }

        [Fact]
        public void Login_ShouldHandlePasswordWithCarriageReturns()
        {
            var userManager = new UserManager();
            userManager.Register("testUser", "pass\rword\r123");
            var result = userManager.Login("testUser", "pass\rword\r123");
            Assert.True(result);
        }

        [Fact]
        public void Register_ShouldHandlePasswordWithUnicodeCharacters()
        {
            var userManager = new UserManager();
            var result = userManager.Register("testUser", "密码123パスワード");
            Assert.True(result);
        }

        [Fact]
        public void Login_ShouldHandlePasswordWithUnicodeCharacters()
        {
            var userManager = new UserManager();
            userManager.Register("testUser", "密码123パスワード");
            var result = userManager.Login("testUser", "密码123パスワード");
            Assert.True(result);
        }

        [Fact]
        public void Register_ShouldHandlePasswordWithEmoji()
        {
            var userManager = new UserManager();
            var result = userManager.Register("testUser", "password123😊");
            Assert.True(result);
        }

        [Fact]
        public void Login_ShouldHandlePasswordWithEmoji()
        {
            var userManager = new UserManager();
            userManager.Register("testUser", "password123😊");
            var result = userManager.Login("testUser", "password123😊");
            Assert.True(result);
        }

        [Fact]
        public void Register_ShouldHandlePasswordWithZeroWidthCharacters()
        {
            var userManager = new UserManager();
            var result = userManager.Register("testUser", "password123\u200B");
            Assert.True(result);
        }

        [Fact]
        public void Login_ShouldHandlePasswordWithZeroWidthCharacters()
        {
            var userManager = new UserManager();
            userManager.Register("testUser", "password123\u200B");
            var result = userManager.Login("testUser", "password123\u200B");
            Assert.True(result);
        }

        [Fact]
        public void Register_ShouldHandlePasswordWithControlCharacters()
        {
            var userManager = new UserManager();
            var result = userManager.Register("testUser", "password123\u0001");
            Assert.True(result);
        }

        [Fact]
        public void Login_ShouldHandlePasswordWithControlCharacters()
        {
            var userManager = new UserManager();
            userManager.Register("testUser", "password123\u0001");
            var result = userManager.Login("testUser", "password123\u0001");
            Assert.True(result);
        }

        [Fact]
        public void Register_ShouldHandlePasswordWithSurrogatePairs()
        {
            var userManager = new UserManager();
            var result = userManager.Register("testUser", "password123\uD83D\uDE00");
            Assert.True(result);
        }

        [Fact]
        public void Login_ShouldHandlePasswordWithSurrogatePairs()
        {
            var userManager = new UserManager();
            userManager.Register("testUser", "password123\uD83D\uDE00");
            var result = userManager.Login("testUser", "password123\uD83D\uDE00");
            Assert.True(result);
        }

        [Fact]
        public void Register_ShouldHandlePasswordWithCombiningCharacters()
        {
            var userManager = new UserManager();
            var result = userManager.Register("testUser", "password123\u0301");
            Assert.True(result);
        }

        [Fact]
        public void Login_ShouldHandlePasswordWithCombiningCharacters()
        {
            var userManager = new UserManager();
            userManager.Register("testUser", "password123\u0301");
            var result = userManager.Login("testUser", "password123\u0301");
            Assert.True(result);
        }

        [Fact]
        public void Register_ShouldHandlePasswordWithPrivateUseCharacters()
        {
            var userManager = new UserManager();
            var result = userManager.Register("testUser", "password123\uE000");
            Assert.True(result);
        }

        [Fact]
        public void Login_ShouldHandlePasswordWithPrivateUseCharacters()
        {
            var userManager = new UserManager();
            userManager.Register("testUser", "password123\uE000");
            var result = userManager.Login("testUser", "password123\uE000");
            Assert.True(result);
        }

        [Fact]
        public void Register_ShouldHandlePasswordWithNonSpacingMarks()
        {
            var userManager = new UserManager();
            var result = userManager.Register("testUser", "password123\u0308");
            Assert.True(result);
        }

        [Fact]
        public void Login_ShouldHandlePasswordWithNonSpacingMarks()
        {
            var userManager = new UserManager();
            userManager.Register("testUser", "password123\u0308");
            var result = userManager.Login("testUser", "password123\u0308");
            Assert.True(result);
        }

        [Fact]
        public void Register_ShouldHandlePasswordWithEnclosingMarks()
        {
            var userManager = new UserManager();
            var result = userManager.Register("testUser", "password123\u20DD");
            Assert.True(result);
        }

        [Fact]
        public void Login_ShouldHandlePasswordWithEnclosingMarks()
        {
            var userManager = new UserManager();
            userManager.Register("testUser", "password123\u20DD");
            var result = userManager.Login("testUser", "password123\u20DD");
            Assert.True(result);
        }

        [Fact]
        public void Register_ShouldHandlePasswordWithFormatCharacters()
        {
            var userManager = new UserManager();
            var result = userManager.Register("testUser", "password123\u200B");
            Assert.True(result);
        }

        [Fact]
        public void Login_ShouldHandlePasswordWithFormatCharacters()
        {
            var userManager = new UserManager();
            userManager.Register("testUser", "password123\u200B");
            var result = userManager.Login("testUser", "password123\u200B");
            Assert.True(result);
        }
    }
}
