using HospitalManagment.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

public class HospitalManagementPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var group = context.AddGroup(HospitalManagementPermissions.GroupName);

        var dept = group.AddPermission(HospitalManagementPermissions.Departments.Default, L("Permission:Departments"));
        dept.AddChild(HospitalManagementPermissions.Departments.Manage, L("Permission:Departments.Manage"));

        var doctor = group.AddPermission(HospitalManagementPermissions.Doctors.Default, L("Permission:Doctors"));
        doctor.AddChild(HospitalManagementPermissions.Doctors.Create, L("Permission:Doctors.Create"));
        doctor.AddChild(HospitalManagementPermissions.Doctors.ManageAvailability, L("Permission:Doctors.ManageAvailability"));

        var appt = group.AddPermission(HospitalManagementPermissions.Appointments.Default, L("Permission:Appointments"));
        appt.AddChild(HospitalManagementPermissions.Appointments.ViewOwn, L("Permission:Appointments.ViewOwn"));
        appt.AddChild(HospitalManagementPermissions.Appointments.Create, L("Permission:Appointments.Create"));
        appt.AddChild(HospitalManagementPermissions.Appointments.Cancel, L("Permission:Appointments.Cancel"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<HospitalManagmentResource>(name);
    }
}













//using HospitalManagment.Localization;
//using Volo.Abp.Authorization.Permissions;
//using Volo.Abp.Localization;
//using Volo.Abp.MultiTenancy;

//namespace HospitalManagment.Permissions;

//public class HospitalManagmentPermissionDefinitionProvider : PermissionDefinitionProvider
//{
//    public override void Define(IPermissionDefinitionContext context)
//    {
//        var myGroup = context.AddGroup(HospitalManagmentPermissions.GroupName);

//        //Define your own permissions here. Example:
//        //myGroup.AddPermission(HospitalManagmentPermissions.MyPermission1, L("Permission:MyPermission1"));
//    }

//    private static LocalizableString L(string name)
//    {
//        return LocalizableString.Create<HospitalManagmentResource>(name);
//    }
//}
