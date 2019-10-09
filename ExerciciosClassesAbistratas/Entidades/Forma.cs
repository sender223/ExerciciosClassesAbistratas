using ExerciciosClassesAbistratas.Entidades.Enums;

namespace ExerciciosClassesAbistratas.Entidades {
    abstract class Forma {

        public Cores Cores{get; set;}

        public Forma(Cores cores) {
            Cores = cores;
        }

        public abstract double Area();
    }
}
