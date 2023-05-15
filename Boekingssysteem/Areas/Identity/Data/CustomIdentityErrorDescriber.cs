using Microsoft.AspNetCore.Identity;

namespace Boekingssysteem.Areas.Identity.Data
{
    public class CustomIdentityErrorDescriber : IdentityErrorDescriber
    {
        public override IdentityError DuplicateUserName(string userName)
        {
            return new IdentityError { Code = nameof(DuplicateEmail), Description = $"Email {userName} is al in gebruik!"};
        }

        public override IdentityError PasswordMismatch() 
        {
            return new IdentityError { Code = nameof(PasswordMismatch), Description = "Uw huidig wachtwoord is onjuist" };
        }

        public override IdentityError PasswordTooShort(int length) 
        { 
            return new IdentityError { Code = nameof(PasswordTooShort), Description = $"Het wachtwoord moet minstens 8 tekens lang zijn" };
        }

        
    }
}
