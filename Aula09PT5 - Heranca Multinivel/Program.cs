using System;
using System.Collections.Generic;
using System.Linq;

namespace Aula09PT5___Heranca_Multinivel
{
    class Program
    {
        static void Main(string[] args)
        {
            ////01a
            //Empresa emp = new Empresa();
            //Console.WriteLine("Preencha a Empreza");
            //emp.Nome = Console.ReadLine();
            //emp.Idade = Convert.ToInt32(Console.ReadLine());
            //emp.Saldo = Convert.ToDouble(Console.ReadLine());
            //emp.QntFunc = int.Parse(Console.ReadLine());
            //emp.Cnpj = Console.ReadLine();
            //emp.Rua = Console.ReadLine();
            //emp.Cep = Console.ReadLine();
            //emp.Cidade = Console.ReadLine();
            //emp.Estado = Console.ReadLine();
            //// formatar o CNPJ @"{0:00\.000\.000\/0000\-00}"
            //if (emp.QntFunc > 8)
            //{
            //    Console.WriteLine(@"{0}  {1}  {2:00\.000\.000\/0000\-00}", emp.Nome, emp.Idade, Convert.ToInt64(emp.Cnpj));
            //    Console.WriteLine("{0:c}  {1}", emp.Saldo, emp.QntFunc);
            //    Console.WriteLine("{0}  {1}  {2}", emp.Rua, emp.Cep, emp.Cidade);
            //    Console.WriteLine("{0}", emp.Estado);
            //}
            //else
            //{
            //    Console.WriteLine("Micro empresa");
            //}

            //01b
            List<Carro> carrros = new List<Carro>();
            for (int i = 0; i < 3; i++)
            {
                Carro car = new Carro();
                Console.WriteLine("Preencha o carro");
                car.Nome = Console.ReadLine();
                car.Idade = Convert.ToInt32(Console.ReadLine());
                car.Modelo = Console.ReadLine();
                car.Cv = int.Parse(Console.ReadLine());
                carrros.Add(car);
            }

            List<Carro> CarroOrganizado = carrros.OrderBy(x => x.Cv).ToList();
            foreach (var item in CarroOrganizado)
            {
                if (item.Cv > 500)
                {
                    Console.WriteLine("{0} {1}", item.Nome, item.Idade);
                    Console.WriteLine("{0} {1}", item.Modelo, item.Cv);
                }
            }
            Console.ReadKey();
        }
    }
}
