using System;
using System.Collections.Generic;
using System.Text;
using HvacTools.Mobile.Database;
using HvacTools.Mobile.Models;

namespace HvacTools.Mobile.Services
{
    public class ReferenceService
    {
        #region Member Variables
        public MobileReferenceContext _referenceContext { get; set; }
        #endregion

        #region Constructor(s)
        public ReferenceService(MobileReferenceContext referenceContext)
        {
            if (referenceContext == null)
            {
                throw new ArgumentNullException("Null reference database context.");
            }

            _referenceContext = referenceContext;
        }

        public IEnumerable<State> GetStateList()
        {
            return _referenceContext.States;
        }

        public State GetStateById(int stateId)
        {
            return _referenceContext.States.Find(stateId);
        }
        #endregion
    }
}
