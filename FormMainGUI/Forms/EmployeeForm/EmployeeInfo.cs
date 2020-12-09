namespace FormMainGUI.Forms.EmployeeForm
{
    class EmployeeInfo
    {
        public string EmployeeId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public bool Sex { get; set; }
        public int YearOfBirth { get; set; }
        public string Address { get; set; }

        public EmployeeInfo()
        {

        }

        public EmployeeInfo(string employeeId, string name, string phone, bool sex, int birth,string address)
        {
            EmployeeId = employeeId;
            Name = name;
            Phone = phone;
            Sex = sex;
            YearOfBirth = birth;
            Address = address;
        }
    }
}

