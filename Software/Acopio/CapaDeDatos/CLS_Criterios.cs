using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaDeDatos
{
    public class CLS_Criterios:ConexionBase
    {
        public string c_codigo_eta { get;  set; }
        public int? b_criterio { get;  set; }
        public string c_codigo_ccali { get;  set; }
        public decimal? n_criterio_porcentaje { get;  set; }
        public string v_criteriocalculo { get;  set; }
        public int? b_calculo { get;  set; }

        public void MtdSeleccionarCriterio()
        {


            TipoDato _dato = new TipoDato();
            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "usp_Rent_Acp_Criterios_Calibres_Select";
                _dato.CadenaTexto = c_codigo_eta;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_codigo_eta");
                _conexion.EjecutarDataset();

                if (_conexion.Exito)
                {
                    Datos = _conexion.Datos;
                }
                else
                {
                    Mensaje = _conexion.Mensaje;
                    Exito = false;
                }
            }
            catch (Exception e)
            {
                Mensaje = e.Message;
                Exito = false;
            }


        }
        public void MtdSeleccionarCriterioCalculos()
        {


            TipoDato _dato = new TipoDato();
            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "usp_Rent_Acp_Criterios_Calculos_Select";
                //_dato.CadenaTexto = c_codigo_eta;
                //_conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_codigo_eta");
                _conexion.EjecutarDataset();

                if (_conexion.Exito)
                {
                    Datos = _conexion.Datos;
                }
                else
                {
                    Mensaje = _conexion.Mensaje;
                    Exito = false;
                }
            }
            catch (Exception e)
            {
                Mensaje = e.Message;
                Exito = false;
            }


        }
        public void MtdSeleccionarPorcentajeCriterio()
        {
            TipoDato _dato = new TipoDato();
            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "usp_Rent_Acp_Criterios_PorcentajeCalibres_Select";
                _dato.CadenaTexto = c_codigo_eta;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_codigo_eta");
                _conexion.EjecutarDataset();

                if (_conexion.Exito)
                {
                    Datos = _conexion.Datos;
                }
                else
                {
                    Mensaje = _conexion.Mensaje;
                    Exito = false;
                }
            }
            catch (Exception e)
            {
                Mensaje = e.Message;
                Exito = false;
            }


        }
        public void MtdActualizarCriterio()
        {
            TipoDato _dato = new TipoDato();
            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "usp_Rent_Acp_Criterios_Calibres_Update";

                _dato.Entero = b_criterio;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "b_criterio");
                _dato.CadenaTexto = c_codigo_ccali;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_codigo_ccali");
                _conexion.EjecutarDataset();

                if (_conexion.Exito)
                {
                    Datos = _conexion.Datos;
                }
                else
                {
                    Mensaje = _conexion.Mensaje;
                    Exito = false;
                }
            }
            catch (Exception e)
            {
                Mensaje = e.Message;
                Exito = false;
            }
        }
        public void MtdActualizarPorcentajeAgrupado()
        {
            TipoDato _dato = new TipoDato();
            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "usp_Rent_Acp_Criterios_Porcentaje_Update";

                _dato.CadenaTexto = c_codigo_eta;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_codigo_eta");
                _dato.DecimalValor = n_criterio_porcentaje;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "n_criterio_porcentaje");
                _conexion.EjecutarDataset();

                if (_conexion.Exito)
                {
                    Datos = _conexion.Datos;
                }
                else
                {
                    Mensaje = _conexion.Mensaje;
                    Exito = false;
                }
            }
            catch (Exception e)
            {
                Mensaje = e.Message;
                Exito = false;
            }
        }
        public void MtdActualizarCriterioVolumen()
        {
            TipoDato _dato = new TipoDato();
            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "usp_Rent_Acp_Criterios_Volumen_Update";

                _dato.Entero = b_calculo;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "b_calculo");
                _dato.CadenaTexto = v_criteriocalculo;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "v_criteriocalculo");
                _conexion.EjecutarDataset();

                if (_conexion.Exito)
                {
                    Datos = _conexion.Datos;
                }
                else
                {
                    Mensaje = _conexion.Mensaje;
                    Exito = false;
                }
            }
            catch (Exception e)
            {
                Mensaje = e.Message;
                Exito = false;
            }
        }
    }
}
