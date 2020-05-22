using System;

namespace Vehiculo
{
	abstract class Vehiculo
	{
		private string Color;
		private string Marca;
		private int Ano;
		private int Kilometraje;
		private motor_motor;
		private rueda[]_rueda;
		private estanque_estanque;
		

		public Vehiculo(string Color, string Marca, int Ano, int Kilometraje,
			int idmotor, tipomotor, int cilindeada,
			int numruedas, tipoRecubrimiento,
			int minDurometro, int maxDurometro)
		{
			_Color = Color;

			_Marca = Marca;

			_Ano = Ano;

			_Kilometraje = Kilometraje;

			_motor = new motor(idmotor, tipoMotor, cilindrada);

			_rueda = newrueda[numruedas];
			for (int i-0; i < numreuda; i++);
			_ruedas[i] - new Rueda(tipoRecubrimiento, minDurometro, maxDurometro);

			_estanque = new estanque(capacidad);



            
		}
		public string Color1 { get => Color; set => Color = value; }
        public string Marca1 { get => Marca; set => Marca = value; }
        public int Ano1 { get => Ano; set => Ano = value; }
        public int Kilometraje1 { get => Kilometraje; set => Kilometraje = value; }
		public int motor { get => motor; set => motor = value; }
		public int rueda { get => rueda; set => rueda = value; }
		public int estanque { get => Ano; set => Ano = value; }
		

	}
}