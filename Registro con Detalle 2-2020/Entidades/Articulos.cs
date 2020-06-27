using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Registro_con_Detalle_2_2020.Entidades
{
        public class Articulos
        {
            [Key]
            public int IdArticulo { get; set; }
            public string Descripcion { get; set; }
            public int Existencia { get; set; }
            public double Costo { get; set; }
            public double ValorInventario { get; set; }

            //REGISTRO DETALLADO
            [ForeignKey("IdArticulo")]
            public List<ArticulosDetalle> Detalle { get; set; } = new List<ArticulosDetalle>();
        }
    }