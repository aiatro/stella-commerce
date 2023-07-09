using System.ComponentModel.DataAnnotations;

namespace Stella_Commerce.Model;

public class Profile
{
    
    public int ProfileId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PaymentToken { get; set; }
}
