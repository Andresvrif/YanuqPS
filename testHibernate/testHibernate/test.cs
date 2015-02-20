using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace testHibernate
{
    public class test
    {
        private string NOMBRE;
        private System.Int32 ID;

        public virtual string nombre
        {
            get { return NOMBRE; }
            set { NOMBRE = value; }
        }

        public virtual System.Int32 id
        {
            get { return ID; }
            set { ID = value; }
        }
    }
}