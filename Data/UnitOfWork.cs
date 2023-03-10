using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment.Data
{
    public class UnitOfWork :IUnitOfWork
    {
        public UnitOfWork ()
        {
            Person = new PersonRepository();
        }

        #region Properties 
        public IPersonRepository Person { get; }

        #endregion

        #region Methods
        public void Complete()
        {

        }
        public void Dispose()
        {
        }
        #endregion

        
    }
}