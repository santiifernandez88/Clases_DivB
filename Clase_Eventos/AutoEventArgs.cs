using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Eventos
{
    public class AutoEventArgs : EventArgs
    {
        private double _restoCombustible;

        public double CombustibleEnElTanque
        {
            get 
            { 
                return _restoCombustible;
            }
            set 
            {
                this._restoCombustible = value;
            }
        }

    }
}
