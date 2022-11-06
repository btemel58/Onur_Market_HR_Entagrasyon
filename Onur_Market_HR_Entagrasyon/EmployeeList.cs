using System;
using System.Collections.Generic;
using System.Text;

namespace Onur_Market_HR_Entagrasyon
{
    public class EmployeeList
    {
        public int statusCode { get; set; }
        public string message { get; set; }
        public List<EmployeeInfo> result { get; set; }

    }

    public class EmployeeInfo
    {
        public string registerFullName { get; set; }
        public string registerCode { get; set; }
        public string registerName { get; set; }
        public string registerSurname { get; set; }
        public bool ispassive { get; set; }
        public int employeeId { get; set; }
        public int registerId { get; set; }
        public int wpId { get; set; }
        public int orgId { get; set; }
        public int jobId { get; set; }
        public int titleId { get; set; }
        public int positionId { get; set; }
        public string wpCode { get; set; }
        public string orgCode { get; set; }
        public string jobCode { get; set; }
        public string titleCode { get; set; }
        public string positionCode { get; set; }
        public string wpDesc { get; set; }
        public string orgDesc { get; set; }
        public bool isManagerOfOrgUnit { get; set; }
        public string jobDesc { get; set; }
        public string titleDesc { get; set; }
        public string positionDesc { get; set; }
        public DateTime empDate { get; set; }
        public DateTime quitDate { get; set; }
        public bool externalPersonnel { get; set; }
        public int coId { get; set; }
        public string coCode { get; set; }
        public string coDesc { get; set; }
        public bool isWorking { get; set; }
        public string statuteCountry { get; set; }
        public string fatherName { get; set; }
        public string motherName { get; set; }
    }
}
