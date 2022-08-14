namespace Blazor6App.Models
{
    public enum PhoneNumberTypes{mobile, home, office }
    public class PhoneNo
    {
        public int Id { get; set; } = 1;

        public PhoneNumberTypes Type { get; set; } = PhoneNumberTypes.mobile;

        public string Number { get; set; } = string.Empty;
    }
}
