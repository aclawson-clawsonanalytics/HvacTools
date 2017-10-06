using System;
using System.Collections.Generic;
using System.Text;
using HvacTools.Mobile.Database;
using HvacTools.Mobile.Models;

namespace HvacTools.Mobile.Models
{
    public class ServiceRecordService
    {
        #region MemberVariables
        private MobileContext _mobileContext { get; set; }
        #endregion

        #region Constructor(s)
        public ServiceRecordService(MobileContext mobileContext)
        {
            if (mobileContext == null)
            {
                throw new ArgumentNullException("Null mobile context.");
                _mobileContext = mobileContext;
            }
        }

        public IEnumerable<ServiceRecord> GetAllServiceRecords()
        {
            return _mobileContext.ServiceRecords;
        }

        public ServiceRecord GetById(int recordId)
        {
            return _mobileContext.ServiceRecords.Find(recordId);
        }
        #endregion
    }
}
