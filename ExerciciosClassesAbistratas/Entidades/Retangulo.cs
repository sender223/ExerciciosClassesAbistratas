using ExerciciosClassesAbistratas.Entidades.Enums;
namespace ExerciciosClassesAbistratas.Entidades {
    class Retangulo : Forma {


        public double Largura { get; set; }
        public double Altura { get; set; }

        public Retangulo(double largura, double altura, Cores cores) : base(cores) {
            Largura = largura;
            Altura = altura;
        }

        public override double Area() {
            return Largura * Altura;
        }
    }
}
