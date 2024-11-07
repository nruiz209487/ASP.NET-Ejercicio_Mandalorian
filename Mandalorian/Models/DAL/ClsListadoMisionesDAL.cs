using EjercicioMandalorianASP.Models.ENT;

namespace EjercicioMandalorianASP.Models.DAL
{
    /// <summary>
    /// clase listado de misiones que almacena misiones 
    /// </summary>
    public static class ClsListadoMisionesDAL
    {
        private static List<ClsMision> listaMisionesDal;
        private static ClsMision mision;
        /// <summary>
        /// Rellena la lista de misiones
        /// </summary>
        /// <returns>devulevela  lista misiones </returns>
        public static List<ClsMision> ObtenerMisionesDAL()
        {
            listaMisionesDal = new List<ClsMision>
        {

            new ClsMision(1,"Rescate de Baby Yoda", "Debes hacerte con Grogu y llevárselo a Luke SkyWalker para su entrenamiento.",5000),
            new ClsMision(2,"Recuperar armadura Beskar", "Tu armadura de Beskar ha sido robada. Debes encontrarla.",2000  ),
            new ClsMision(3,"Planeta Sorgon", "Debes llevar a un niño de vuelta a su planeta natal “Sorgon”.",500  ),
            new ClsMision(4,"Renacuajos","Debes llevar a una Dama Rana y sus huevos de Tatooine a la luna del estuario Trask, donde su esposo fertilizará los huevos.",500 )
            };
            return listaMisionesDal;
        }
        /// <summary>
        /// busca una mision en especifico en  listaMisionesDal
        /// </summary>
        /// <param name="id"></param>
        /// <returns>devuelve un objeto mision</returns>
        public static ClsMision ObtenerMisionDAL(int id)
        {
            mision = new ClsMision();
            mision = listaMisionesDal.FirstOrDefault(e => e.Id == id);
            return mision;
        }
    }

}