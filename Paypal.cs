using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto2
{
    public class Paypal : Cuenta
    {
        public Paypal(int id) : base(id)
        {
            logeo(id);
        }

    }
}