using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DB_Nhibernate
{
   public class contact
    {
       public virtual int emp_id {get; set;}
       public virtual int emp_irszam { get; set; }
       public virtual int emp_parkolohely{ get; set; }
       public virtual string emp_telephely { get; set; }
       public virtual string emp_adress { get; set; }

       
    }
}
