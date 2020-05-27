using System;

namespace Vehiculo
{
	abstract class Vehiculo
	{
		private string Color;
		private string Marca;
		private int Ano;
		private int Kilometraje;

		public Vehiculo(string Color,string Marca,int Ano,int Kilometraje){
			_Color=Color;
			_Marca=Marca;
			_Ano=Ano;
			_Kilometraje=Kilometraje;
            
		}
		public string Color1 { get => Color; set => Color = value; }
        public string Marca1 { get => Marca; set => Marca = value; }
        public int Ano1 { get => Ano; set => Ano = value; }
        public int Kilometraje1 { get => Kilometraje; set => Kilometraje = value; }
	}
}