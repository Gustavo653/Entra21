﻿using Aula11PT2___WinForms_MVC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11PT2___WinForms_MVC.Control
{
    public static class Controller2
    {
        public static List<string[]> AtualizaDG() //chama funcao de Atualizar datagridview
        {
            return DBConnection.AtualizaDG();
        }
        public static List<string> AtualizaCBVaga() //chama funcao de atualizar combobox
        {
            List<string> lista = DBConnection.GenericSelectUnit("Placa","Vaga","Placa is not null");
            lista.Sort();
            return lista;
        }

        public static List<string> AtualizaVagaLivre() //chama funcao de atualizar vagas livres
        {
            List<string> lista = DBConnection.GenericSelectUnit("idVaga", "Vaga", "Placa is null");
            lista.Sort();
            return lista;
        }

        public static double Saida(string placa,string hrSaida,bool lavou) //faz a saida de um veiculo
        {
            if(!String.IsNullOrEmpty(placa) && !String.IsNullOrEmpty(hrSaida))
            {
                double horaDeEntrada = DBConnection.AtualizaAVaga(placa);  
                if(horaDeEntrada != -1)
                {
                    double valorFinal = (Convert.ToDouble(hrSaida) - horaDeEntrada) * 7;
                    if(lavou)
                    {
                        valorFinal += 60;
                    }
                    return valorFinal;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                return -1;
            }
        }
        
        public static bool Entrar(string placa,string horario,string vaga) //faz a entrada de um veículo
        {
            if(!string.IsNullOrEmpty(placa) && !string.IsNullOrEmpty(horario) &&
                !string.IsNullOrEmpty(vaga))
            {
                if(DBConnection.Entrar(placa,horario,vaga))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
               return false;
            }
        }

    }
}
