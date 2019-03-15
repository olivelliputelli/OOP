using System;
using System.Collections.Generic;
using System.Text;

namespace ClassiUtiliClassLibrary
{
    class PersoneRepository : IRepository<Persona, int>
    {
        Persona IRepository<Persona, int>.GetItemBy(int key)
        {
            throw new NotImplementedException();
        }
    }
}
