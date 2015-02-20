using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NHibernate;
using NHibernate.Cfg;

namespace testHibernate
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var sessionFactory = new Configuration().Configure().BuildSessionFactory();
            var currentSession = sessionFactory.OpenSession();
            ITransaction tx = currentSession.BeginTransaction();

            /*
            var p = new test();
            p.nombre = "deborah";
            currentSession.Save(p);
            tx.Commit();
            */
          
                
            var dd = currentSession.QueryOver<test>().Where(t => t.nombre == "andres").SingleOrDefault();
            Label1.Text = dd.nombre;
            currentSession.Close();            

        }
    }
}