﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLLS
{
        // Capa de negocio ya creada
        public class Peliculas : ClaseMaestra
        {
            public int Peliculaid { get; set; }

            public string Titulo { get; set; }

            public string Descripcion { get; set; }

            public int Ano { get; set; }

            public int Calificacion { get; set; }

            public int IMDB { get; set; }

            public int CategoriaId { get; set; }

            public Peliculas()
            {
                this.Titulo = "";
                this.Descripcion = "";
                this.Ano = 0;
                this.Calificacion = 0;
                this.IMDB = 0;
                this.CategoriaId = 0;
            }

            public Peliculas(string TituloS, string DescripcionS, int AnoS, int CalificacionS, int IMDBS, int CategoriaIdS)
            {
                this.Titulo = TituloS;
                this.Descripcion = DescripcionS;
                this.Ano = AnoS;
                this.Calificacion = CalificacionS;
                this.IMDB = IMDBS;
                this.CategoriaId = CategoriaIdS;
            }

            public Peliculas(int peliculaid)
            {
                this.Peliculaid = peliculaid;
            }

        public override bool Insertar()
        {
            bool retorno = false;

            ConexionDb conexion = new ConexionDb();


            conexion.Ejecutar(string.Format("Insert Into PeliculasT ( Titulo, Descripcion, Ano, Calificacion, IMDB, CategoriaId) Values('{0}','{1}','{2}','{3}','{4}','{5}')", this.Titulo, this.Descripcion, this.Ano, this.Calificacion, this.IMDB, this.CategoriaId));

            return retorno;
        }

        public override bool Modificar()
        {
            bool retorno = false;

            ConexionDb conexion = new ConexionDb();


            conexion.Ejecutar(string.Format("update PeliculasT set Titulo = '{0}' ,Descripcion = '{1}' ,Ano = '{2}' ,Calificacion = '{3}' ,IMDB = '{4}' ,CategoriaId = '{5}' where  PeliculaId = '{6}' ", this.Titulo, this.Descripcion, this.Ano, this.Calificacion, this.IMDB, this.CategoriaId, this.Peliculaid));

            return retorno;
        }

        public override bool Eliminar()
        {
            bool retorno = false;

            ConexionDb conexion = new ConexionDb();


            conexion.Ejecutar(string.Format("delete from PeliculasT where  PeliculaId = '{0}' ", this.Peliculaid));

            return retorno;
        }

        public override bool Buscar(int IdBuscado)
        {
            throw new NotImplementedException();
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            throw new NotImplementedException();
        }

        public override bool ObtenerId()
        {
            throw new NotImplementedException();
        }
    }
}
