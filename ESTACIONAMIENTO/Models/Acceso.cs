using System;
using System.Collections.Generic;
using System.IO;
//lector de flujo
using System.Linq;
using System.Web;

namespace ESTACIONAMIENTO.Models
{
    public class Acceso
    {
        //lista de autos
        List<Auto> autList;

        //constructor del modelo
        public Acceso(string dbPath)
        {
            //leer archivo
            autList = new List<Auto>();

            var reader = new StreamReader(
                 File.OpenRead(dbPath));

            //parsear
            while (!reader.EndOfStream)
            {
                //leer una linea
                var line = reader.ReadLine();

                //parsear
                //separar valores y guardarlos en un objeto
                var valores = line.Split(',');
                autList.Add(
                    new Auto
                    {
                        Tarjeton = valores[0],
                        Marca = valores[1],
                        Modelo = int.Parse(valores[2]),
                        Color = valores[3],
                        Placas = valores[4],
                        Propietario = valores[5],
                        PhotoPath = valores[6],
                    });
            }
        }

        //accesor
        public Auto GetAutoByTarjeton(string tarjeton)
        {
            /*Auto aut = null;
            foreach (var autoin in autList)
            {       
                if (tarjeton == autoin.Tarjeton)
                {
                    aut = autoin;
                }
            }*/

            var aut = autList.Find(e => e.Tarjeton == tarjeton);
            return aut;
        }
    }
}