namespace EjercicioMandalorianASP.Models.ENT
{/// <summary>
/// Clase cls mision que representa las misiones del mandaloriano
/// </summary>
    public class ClsMision
    {
        /// <summary>
        /// string Id
        /// </summary>
        public int Id { get; }
        /// <summary>
        /// string Titulo
        /// </summary>
        public string Titulo { get; }
        /// <summary>
        /// string Descripcion
        /// </summary>
        public string Descripcion { get; }
        /// <summary>
        /// int Recompensa
        /// </summary>
        public int Recompensa { get; }

        /// <summary>
        /// constructor vacio 
        /// </summary>
        public ClsMision() { }
        /// <summary>
        /// Contructor con todos los parametros
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="Titulo"></param>
        /// <param name="Descripcion"></param>
        /// <param name="Recompensa"></param>
        public ClsMision(int Id, string Titulo, string Descripcion, int Recompensa)
        {
            if (Id > 0) { this.Id = Id; }
            if (Titulo != null && Titulo != "") { this.Titulo = Titulo; }
            if (Descripcion != null && Descripcion != "") { this.Descripcion = Descripcion; }
            if (Recompensa > 0) { this.Recompensa = Recompensa; }

        }
    }





}
