using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.entity;
using University.util;

namespace University.repository
{
    internal class FacultyRepository : AbstractRepository<Faculty>
    {
        public FacultyRepository(IDataSerivce<List<Faculty>> dataSerivce) : base(dataSerivce)
        {
        }
    }
}
