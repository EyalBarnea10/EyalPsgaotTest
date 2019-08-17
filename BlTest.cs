using DALTestEyal1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestEyal.Models;

namespace BLTestEyal
{
    public class BlTest
    {
        #region Get all movies data from dal
        /// <summary>
        /// Get   list of movies 
        /// </summary>
        /// <returns></returns>
        public MoviesList GetMoviesList()
        {

            return DalTest.GetMoviesList();

        } 
        #endregion
    }
}
