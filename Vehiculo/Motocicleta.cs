using System;
namespace Vehiculo
{
 class Motocicleta : Vehiculo 
{
		private string Color;
		private string Marca;
		private int Ano;
		private int Kilometraje;
		

		public Motocicleta(string Color,string Marca,int Ano,int Kilometraje){
			_color=color;
			_marca=marca;
			_ano=ano;
			_kilometraje=kilometraje;
		}

        public string Color1 { get => Color; set => Color = value; }
        public string Marca1 { get => Marca; set => Marca = value; }
        public int Ano1 { get => Ano; set => Ano = value; }
        public int Kilometraje1 { get => Kilometraje; set => Kilometraje = value; }
    }

}


