using Management1.ManagementEntityFramework;
using Management1.Models;
using System.Collections.Generic;
using System.Linq;

namespace Management1.Processor
{
    public class DataProcessor:IDataProcessor
    {
        private readonly ManagementContext _data;
        public DataProcessor(ManagementContext data)
        {
            _data = data;
        }

        public List<ViewPatient>GetPatientList()
        {
            IEnumerable<ViewPatient> listPatient = new List<ViewPatient>();
            listPatient = _data._viewpt;
            return listPatient.ToList();

        }
        public bool ScheduleAppointment(ScheduleAppoinment req)
        {
            _data._scheduleAppt.Add(req);
            _data.SaveChanges();
            return true;
        }

        public bool ReportResponse(ResponseReport req)
        {
            _data._Resporpt.Add(req);
            _data.SaveChanges();
            return true;
        }

    }
}
