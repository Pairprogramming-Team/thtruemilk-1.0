namespace FormMainGUI.Forms.AccountForm
{
    public class AccountInfo
    {
        public string EmployeeId { get; set; }
        public string Username { get; set; }

        public string Password { get; set; }
        public string DisplayName { get; set; }
        public string Role { get; set; }

        public AccountInfo()
        {

        }

        public AccountInfo(string employeeId, string username, string passoword, string displayName, string role)
        {
            EmployeeId = employeeId;
            Username = username;
            Password = passoword;
            DisplayName = displayName;
            Role = role;
        }
    }
}
