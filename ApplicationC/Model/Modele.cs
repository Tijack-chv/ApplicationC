using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationC.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApplicationC.Model
{
    public static class Modele
    {
        private static Ap3PiewanContext monModel;

        public static Ap3PiewanContext MonModel { get => monModel; set => monModel = value; }

        public static void init()
        {
            monModel = new Ap3PiewanContext();
        }
    }
}
