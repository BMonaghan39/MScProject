namespace CMS.Data.Models;

public class Patient
{

    public int Id { get; set; }
    public string Firstname { get; set; }
    public string Surname { get; set; } = string.Empty;
    public DateTime DOB { get; set; }
    public int Age => (DateTime.Now - DOB).Days / 365;
    public string AddressLine1 { get; set; } = string.Empty;
    public string AddressLine2 { get; set; } = string.Empty;
    public string Town { get; set; } = string.Empty;
    public string County { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public string PostCode { get; set; } = string.Empty;
    public string MobileNumber { get; set; } = string.Empty;
    
}




