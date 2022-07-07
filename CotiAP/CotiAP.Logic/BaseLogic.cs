using CotiAP.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotiAP.Logic
{
    public class BaseLogic
    {
        protected readonly PlenariaAPContext context;

        public BaseLogic()
        {
            context = new PlenariaAPContext();
        }

    }
}
