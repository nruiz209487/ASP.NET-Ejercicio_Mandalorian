using EjercicioMandalorianASP.Models.ENT;
using EjercicioMandalorianASP.Models.DAL;
namespace EjercicioMandalorianASP.Models.BL

{
    /// <summary>
    /// clase listado clsListadoMisionesBL llama a la dal pero anyade las medidas de control 
    /// </summary>
    public static class clsListadoMisionesBL
    {   /// <summary>
        /// lista misiones que peude ser null 
        /// </summary>
        private static List<ClsMision>? listaMisionesBL;
        /// <summary>
        /// objeto mision que peude ser null 
        /// </summary>
        private static ClsMision? mision;
        /// <summary>
        /// Compruba la hora llamando a comprobarHora() y depeniendo del resultado iguala lista a ObtenerMisionesDAL o a null
        /// </summary>
        /// <returns>devuelve la lista de listaMisionesBL</returns>
        public static List<ClsMision> ObtenerMisionesBL()
        {
            if (comprobarHora()) 
            { 
                listaMisionesBL = ClsListadoMisionesDAL.ObtenerMisionesDAL(); 
            }
            else { 
                listaMisionesBL = null;
            }
            return listaMisionesBL;
        }
        /// <summary>
        /// Compruba la hora llamando a comprobarHora() y depeniendo del resultado iguala mision a ObtenerMisionDAL o a null
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static ClsMision ObtenerMisionBL(int id)
        {
            mision = new ClsMision();
            if (comprobarHora())
            {
                mision = ClsListadoMisionesDAL.ObtenerMisionDAL(id);
            }
            else
            {
               mision = null;
            }
            return mision;
        }
        /// <summary>
        /// Comprueba si la hora es media noche o no
        /// </summary>
        /// <returns>devuelve un booleano</returns>
        private static Boolean comprobarHora()
        {
            return DateTime.Now.Hour > 8 && DateTime.Now.Hour < 24;
        }
    }
}
