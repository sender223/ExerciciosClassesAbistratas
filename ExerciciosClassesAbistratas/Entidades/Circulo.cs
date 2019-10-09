using ExerciciosClassesAbistratas.Entidades.Enums;
using System;

namespace ExerciciosClassesAbistratas.Entidades {
    class Circulo : Forma {

        public double Raio { get; set; }

        public Circulo (double raio, Cores cores) : base(cores) {
            Raio = raio;
        }

        public override double Area() {
            return Math.PI * Raio * Raio;
        }
    }
}
