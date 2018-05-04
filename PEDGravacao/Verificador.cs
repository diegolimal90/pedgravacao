using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEDGravacao
{
    class Verificador
    {
        protected String txtAnt, txtNov;

        public void setTxtAnt(String txt) {
            this.txtAnt = txt;
        }
        public String getTxtAnt()
        {
            return this.txtAnt;
        }
    }
}
