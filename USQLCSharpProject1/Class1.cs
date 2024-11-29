using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.Security.Policy;
using System.Text;
using System.Xml.Linq;
namespace USQLCSharpProject1
{
    /// <summary>
    /// эээ ну эээюююю.... эьо эээ ну где все работает
    /// </summary>
    public class Program
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int ClientId { get; set; }
        public int RequestRemontId { get; set; }
        public int RegAppId { get; set; }
        public int AppProcessId { get; set; }
        public int AppExecId { get; set; }
        public int RepInfoId { get; set; }
        public int MonitoringAnalId { get; set; }
        public Program(int id, int EmployeeId, int RequestId, int ClientId, int RequestRemontId, int RegAppId, int AppProcessId, int AppExecId, int RepInfoId, int MonitoringAnalId)
        {
            Id = id;
            EmployeeId = 0;
            ClientId = 0;
            RequestRemontId = 0;
            RegAppId = 0;
            AppProcessId = 0;
            AppExecId = 0;
            RepInfoId = 0;
            MonitoringAnalId = 0;
        }
    }
    /// <summary>
    /// Рабочий
    /// </summary>
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Salary { get; set; }
        public int RequestId { get; set; }
        public Employee(int id, int RequestId)
        {
            Id = id;
            Name = string.Empty;
            SecondName = string.Empty;
            Phone = string.Empty;
            Email = string.Empty;
            Address = string.Empty;
            Salary = string.Empty;
            RequestId = 0;
        }
    }
   /// <summary>
   /// Клиент
   /// </summary>
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int RequestId { get; set; }
        public Client(int id, int RequestId)
        {
            Id = id;
            Name = string.Empty;
            SecondName = string.Empty;
            Phone = string.Empty;
            Email = string.Empty;
            RequestId = 0;
        }
    }
    /// <summary>
    /// Заявка на ремонт
    /// </summary>
    public class RequestRemont
    {
        public int Id { get; set; }
        public string Oborud { get; set; }
        public string Nomer { get; set; }
        public string Description { get; set; }
        public int ClientId { get; set; }
        public string Priority { get; set; }
        public DateTime Create { get; set; }
        public DateTime Update { get; set; }
        public DateTime Finish { get; set; }
        public string Status { get; set; }
        public RequestRemont(int id, int ClientId)
        {
            Id = id;
            Oborud = string.Empty;
            Nomer = string.Empty;
            Description = string.Empty;
            ClientId = 0;
            Priority = string.Empty;
            Create = DateTime.MinValue;
            Update = DateTime.Now;
            Finish = DateTime.MaxValue;
            Status = string.Empty;
        }
    }
    /// <summary>
    /// Регестрация заявки
    /// </summary>
    public class RegApp
    {
        public int Id { get; set; }
        public string Priority { get; set; }
        public DateTime Create { get; set; }
        public string Status { get; set; }
        public int RequestId { get; set; }
        public int ClientId { get; set; }
        public RegApp(int id, int RequestId, int ClientId)
        {
            Id = id;
            Priority = string.Empty;
            Create = DateTime.MinValue;
            Status = string.Empty;
            RequestId = 0;
            ClientId = 0;
        }
    }
    /// <summary>
    /// Обработка заявки
    /// </summary>
    public class AppProcess
    {
        public int Id { get; set; }
        public string Priority { get; set; }
        public DateTime Update { get; set; }
        public string Status { get; set; }
        public int EmployeeId { get; set; }
        public int RequestId { get; set; }
        public AppProcess(int id, int EmployeeId, int RequestId) 
        {
            Id = id;
            Priority = string.Empty;
            Update = DateTime.MinValue;
            Status = string.Empty;
            EmployeeId = 0;
            RequestId = 0;
        }
    }
    /// <summary>
    /// Исполнение заявки
    /// </summary>
    public class AppExec
    {
        public int Id { get; set; }
        public string Priority { get; set; }
        public DateTime Update { get; set; }
        public string Status { get; set; }
        public int EmployeeId { get; set; }
        public int RequestId { get; set; }
        public AppExec(int id, int EmployeeId, int RequestId)
        {
            Id = id;
            Priority = string.Empty;
            Update = DateTime.MinValue;
            Status = string.Empty;
            EmployeeId = 0;
            RequestId = 0;
        }
    }
    /// <summary>
    /// Отчёт
    /// </summary>
    public class RepInfo
    {
        public int Id { get; set; }
        public DateTime Finish { get; set; }
        public string Time { get; set; }
        public string Status { get; set; }
        public string Money { get; set; }
        public string Materials { get; set; }
        public int EmployeeId { get; set; }
        
        public RepInfo(int id, int EmployeeId)
        {
            Id = id;
            Finish = DateTime.MinValue;
            Time = string.Empty;
            Money = string.Empty;
            Materials = string.Empty;
            Status = string.Empty;
            EmployeeId = 0;
        }
    }
    /// <summary>
    /// Мониторинг
    /// </summary>
    public class MonitoringAnal
    {
        public int Id { get; set; }
        public string Money { get; set; }
        public string Time { get; set; }
        public string Materials { get; set; }
        public string Quality { get; set; }
        public int RequestRemontId { get; set; }
        public int EmployeeId { get; set; }
        public MonitoringAnal(int id, int EmployeeId, int RequestRemontId)
        {
            Id = id;
            Time = string.Empty;
            Money = string.Empty;
            Materials = string.Empty;
            Quality = string.Empty;
            EmployeeId = 0;
            RequestRemontId = 0;
        }
    }
}