using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastroAnimal.Model
{
    internal class Conexao
    {
        public static string Conectar()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lucas.mneves3\source\repos\cadastroAnimal\cadastroAnimal\Dados\Database1.mdf;Integrated Security=True";
        }
    }
}
