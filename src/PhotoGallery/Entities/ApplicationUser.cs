using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace PhotoGallery.Entities
{
  public class ApplicationUser : IdentityUser
  {
      public ApplicationUser() : base()
      {
          
      }
      public ApplicationUser(string userName) : base(userName)
      {

      }
  }
}