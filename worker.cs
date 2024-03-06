using System;

namespace Market_System
{
    internal class Worker
    {
        public string WorkerName { get; }
        public string PhoneNumber { get; }
        public string Role { get; }
        public DateTime LeaveDate { get; }
        public DateTime EntryDate { get; }

        // Constructor for required properties
        public Worker(string workerName, string phoneNumber, string role, DateTime entryDate, DateTime leaveDate)
        {
            WorkerName = workerName;
            PhoneNumber = phoneNumber;
            Role = role;
            EntryDate = entryDate;
            LeaveDate = leaveDate;
        }
    }
}
