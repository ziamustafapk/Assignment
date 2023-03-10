using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment.Data
{
    public interface IUnitOfWork : IDisposable
    {
        #region Properties 
        IPersonRepository Person { get; }
        
        #endregion

        #region Methods
        void Complete();

        #endregion
    }
}