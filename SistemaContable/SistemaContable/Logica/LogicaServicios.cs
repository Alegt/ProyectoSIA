﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BibliotecasComunes;
using SistemaContable.BaseDatos;

namespace SistemaContable.Logica
{
    class LogicaServicios
    {

        public static void insertarServicio(Servicio pservicio, string pNombreEmpresa)
        {
            try
            {
                AccesoServicios.insertarServicio(new object[] { pNombreEmpresa, pservicio.Nombre, pservicio.Codigo, pservicio.Descripcion, pservicio.Comentario, pservicio.Unidad, pservicio.Precio });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void insertarImagen(string pCodigo, byte[] pImagen)
        {
            try
            {
                AccesoServicios.insertarImagen(new object[] { pCodigo, pImagen });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
