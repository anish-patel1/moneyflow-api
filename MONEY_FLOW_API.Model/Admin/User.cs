namespace MONEY_FLOW_API.Model
{
    public class User : BaseClass
    {
        public string? UserName { get; set; }
        public string? UserDisplayName { get; set; }
        public string? Password { get; set; }
        public string? UserType { get; set; }
        public string? UserTypeText { get; set; }
        public int? FailedLoginAttempts { get; set; }
        public string? LastLoginDate { get; set; }

        // Other
        public string? LoginStatus { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsLocked { get; set; }
    }

    public class UserLog : BaseClass
    {
        public string? ActivityType { get; set; }
        public string? ActivityTime { get; set; }
        public string? Description { get; set; }
    }
}
