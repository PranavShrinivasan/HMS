using Management1.Models;
using System.Collections.Generic;

namespace Management1.Processor
{
    public interface IDataProcessor
    {
        List<ViewPatient> GetPatientList();
        bool ScheduleAppointment(ScheduleAppoinment req);
        bool ReportResponse(ResponseReport req);
    }
}
