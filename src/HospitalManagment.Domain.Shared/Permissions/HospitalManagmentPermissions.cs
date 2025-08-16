public static class HospitalManagementPermissions
{
    public const string GroupName = "HospitalManagement";

    public static class Departments
    {
        public const string Default = GroupName + ".Departments";
        public const string Manage = Default + ".Manage";
    }

    public static class Doctors
    {
        public const string Default = GroupName + ".Doctors";
        public const string Create = Default + ".Create";
        public const string ManageAvailability = Default + ".ManageAvailability";
    }

    public static class Appointments
    {
        public const string Default = GroupName + ".Appointments";
        public const string ViewOwn = Default + ".ViewOwn";
        public const string Create = Default + ".Create";
        public const string Cancel = Default + ".Cancel";
    }
}