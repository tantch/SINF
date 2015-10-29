using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstREST.Lib_Primavera.Model
{
    public class Artigo
    {
        public string CodArtigo{
            get;
            set;
        }

        public string DescArtigo{
            get;
            set;
        }

        //NEW

        public double PVP1
        {
            get;
            set;
        }
        public double PVP2
        {
            get;
            set;
        }
        public double PVP3
        {
            get;
            set;
        }
        public string Formato
        {
            get;
            set;
        }
        public string ISBN10
        {
            get;
            set;
        }
        public string ISBN13
        {
            get;
            set;
        }
        public String Ano
        {
            get;
            set;
        }
        public string Autor
        {
            get;
            set;
        }
        public String Rating
        {
            get;
            set;
        }
        public string Sinopse
        {
            get;
            set;
        }
        public string Categoria
        {
            get;
            set;
        }
    }
}