using System;
using System.colections.generic;
using system.text;

namespace estanque : vehiculocomponente
{
   class Estanque 

      Private readonly double _Capacidad;
      Private double _litros;

      public Estanque(double capacidad)
      {
        _capacidad - capacidad;
      }

      public double Capacidad-> _capacidad;


      public double Litros
      {
        get->-litros;
        set-> double.TryParse(ValueTuple.Tostring(), out _litros);

      }


       public bajocombustible()
       {
        retur_litros < -10.5,
       }
       public mitacombustible()
       {
        return _litros > 10.5_litros <= 50.0;
       }

   }
 }   