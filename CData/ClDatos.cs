﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Entidades;
using System.Data;

namespace CData
{
    public class ClDatos
    {
        CBD objBD = new CBD();

        //Medico
        public List<Medico> GetMedicos()
        {
            List<Medico> datosMedicos = new List<Medico>();
            try
            {
                objBD.Abrir();
                SqlCommand sql = new SqlCommand("SELECT * FROM Medicos", objBD.connect);
                SqlDataReader reader = sql.ExecuteReader();
                while (reader.Read())
                {
                    Medico objEnt = new Medico()
                    {
                        Cedula = Convert.ToString(reader["Cedula"]),
                        Nombre = Convert.ToString(reader["Nombre"]),
                        Direccion = Convert.ToString(reader["Direccion"]),
                        NumSegSocial = Convert.ToString(reader["NumeroSeguridadSocial"]),
                        NumColegiado = Convert.ToString(reader["NumeroColegiado"]),
                        Tipo = Convert.ToInt16(reader["TipoMedico"]),
                        Poblacion = Convert.ToInt16(reader["Poblacion"]),
                        FechaA = Convert.ToDateTime(reader["FechaA"]),
                        FechaB = Convert.ToDateTime(reader["FechaB"]),
                        Estado = Convert.ToInt16(reader["Estado"]),
                        FechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"])
                    };
                    datosMedicos.Add(objEnt);
                }
            }
            catch
            {
                datosMedicos = null;
            }
            objBD.Cerrar();
            return datosMedicos;
        }

        public string RegistroMedico(Medico datoMed)
        {
            try
            {
                objBD.Abrir();
                string query = $"INSERT INTO Medicos(Cedula, Nombre, Direccion,  NumeroSeguridadSocial, NumeroColegiado, TipoMedico, Poblacion, FechaA, FechaB, Estado, FechaNacimiento) VALUES ('{@datoMed.Cedula}','{@datoMed.Nombre}','{@datoMed.Direccion}','{@datoMed.NumSegSocial}','{@datoMed.NumColegiado}','{@datoMed.Tipo}','{@datoMed.Poblacion}','{@datoMed.FechaA.ToShortDateString()}','{@datoMed.FechaB.ToShortDateString()}', '{@datoMed.Estado}', '{@datoMed.FechaNacimiento.ToShortDateString()}')";
                SqlCommand sql = new SqlCommand(query, objBD.connect);
                sql.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                if (ex.Number == 2627)
                {
                    // Clave primaria duplicada
                    return "2627";
                }
                else
                {
                    return ex.Message;
                }
            }
            objBD.Cerrar();
            return "CORRECTO";
        }

        public void DeleteMedico(string id)
        {
            try
            {
                objBD.Abrir();
                string query = $"UPDATE Medicos SET Estado = 2 WHERE Cedula = '{@id}'";
                SqlCommand sql = new SqlCommand(query, objBD.connect);
                sql.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            objBD.Cerrar();
        }

        public void DeleteMedicoNS(string ns)
        {
            try
            {
                objBD.Abrir();
                string query = $"UPDATE Medicos SET Estado = 2 WHERE NumeroSeguridadSocial = '{@ns}'";
                SqlCommand sql = new SqlCommand(query, objBD.connect);
                sql.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            objBD.Cerrar();
        }

        public string UpdateMedico(Medico datoMed)
        {
            try
            {
                objBD.Abrir();
                string query = $"UPDATE Medicos SET Nombre = '{@datoMed.Nombre}', Direccion = '{@datoMed.Direccion}', NumeroSeguridadSocial = '{@datoMed.NumSegSocial}', NumeroColegiado = '{@datoMed.NumColegiado}', TipoMedico = '{@datoMed.Tipo}', Poblacion = '{@datoMed.Poblacion}', FechaA = '{@datoMed.FechaA.ToShortDateString()}', FechaB = '{@datoMed.FechaB.ToShortDateString()}', Estado = '{@datoMed.Estado}', FechaNacimiento = '{@datoMed.FechaNacimiento.ToShortDateString()}' WHERE Cedula = '{@datoMed.Cedula}'";
                SqlCommand sql = new SqlCommand(query, objBD.connect);
                sql.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                objBD.Cerrar();
                return e.Message;
            }
            objBD.Cerrar();
            return "CORRECTO";
        }

        public Medico SearchMedico(string id)
        {
            Medico datoMed;
            try
            {
                objBD.Abrir();
                string query = $"SELECT * FROM Medicos WHERE Cedula = '{@id}'";
                SqlCommand sql = new SqlCommand(query, objBD.connect);
                sql.ExecuteNonQuery();

                SqlDataReader reader = sql.ExecuteReader();

                if (reader.Read())
                {
                    Medico objEnt = new Medico()
                    {
                        Cedula = Convert.ToString(reader["Cedula"]),
                        Nombre = Convert.ToString(reader["Nombre"]),
                        Direccion = Convert.ToString(reader["Direccion"]),
                        NumSegSocial = Convert.ToString(reader["NumeroSeguridadSocial"]),
                        NumColegiado = Convert.ToString(reader["NumeroColegiado"]),
                        Tipo = Convert.ToInt16(reader["TipoMedico"]),
                        Poblacion = Convert.ToInt16(reader["Poblacion"]),
                        FechaA = Convert.ToDateTime(reader["FechaA"]),
                        FechaB = Convert.ToDateTime(reader["FechaB"]),
                        Estado = Convert.ToInt16(reader["Estado"]),
                        FechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"])
                    };
                    datoMed = objEnt;
                }
                else
                    datoMed = null;
            }
            catch (SqlException e)
            {
                datoMed = null;
                Console.WriteLine(e.Message);
            }
            objBD.Cerrar();
            return datoMed;
        }

        public Medico SearchMedicoNS(string ns)
        {
            Medico datoMed;
            try
            {
                objBD.Abrir();
                string query = $"SELECT * FROM Medicos WHERE NumeroSeguridadSocial = '{@ns}'";
                SqlCommand sql = new SqlCommand(query, objBD.connect);
                sql.ExecuteNonQuery();

                SqlDataReader reader = sql.ExecuteReader();

                if (reader.Read())
                {
                    Medico objEnt = new Medico()
                    {
                        Cedula = Convert.ToString(reader["Cedula"]),
                        Nombre = Convert.ToString(reader["Nombre"]),
                        Direccion = Convert.ToString(reader["Direccion"]),
                        NumSegSocial = Convert.ToString(reader["NumeroSeguridadSocial"]),
                        NumColegiado = Convert.ToString(reader["NumeroColegiado"]),
                        Tipo = Convert.ToInt16(reader["TipoMedico"]),
                        Poblacion = Convert.ToInt16(reader["Poblacion"]),
                        FechaA = Convert.ToDateTime(reader["FechaA"]),
                        FechaB = Convert.ToDateTime(reader["FechaB"]),
                        Estado = Convert.ToInt16(reader["Estado"]),
                        FechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"])
                    };
                    datoMed = objEnt;
                }
                else
                    datoMed = null;
            }
            catch (SqlException e)
            {
                datoMed = null;
                Console.WriteLine(e.Message);
            }
            objBD.Cerrar();
            return datoMed;
        }

        //Empleado
        public List<Empleado> GetEmpleados()
        {
            List<Empleado> datosEmpleados = new List<Empleado>();
            try
            {
                objBD.Abrir();
                SqlCommand sql = new SqlCommand("SELECT * FROM Empleados", objBD.connect);
                SqlDataReader reader = sql.ExecuteReader();
                while (reader.Read())
                {
                    Empleado objEnt = new Empleado()
                    {
                        Cedula = Convert.ToString(reader["Cedula"]),
                        Nombre = Convert.ToString(reader["Nombre"]),
                        Direccion = Convert.ToString(reader["Direccion"]),
                        NumSegSocial = Convert.ToString(reader["NumeroSeguridadSocial"]),
                        Tipo = Convert.ToInt16(reader["TipoEmpleado"]),
                        Poblacion = Convert.ToInt16(reader["Poblacion"]),
                        Estado = Convert.ToInt16(reader["Estado"]),
                        FechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"])
                    };
                    datosEmpleados.Add(objEnt);
                }
            }
            catch
            {
                datosEmpleados = null;
            }
            objBD.Cerrar();
            return datosEmpleados;
        }

        public string RegistroEmpleado(Empleado datoEmp)
        {
            try
            {
                objBD.Abrir();
                string query = $"INSERT INTO Empleados(Cedula, Nombre, Direccion, NumeroSeguridadSocial, TipoEmpleado, Poblacion, Estado, FechaNacimiento) VALUES ('{@datoEmp.Cedula}', '{@datoEmp.Nombre}','{@datoEmp.Direccion}', '{@datoEmp.NumSegSocial}','{@datoEmp.Tipo}','{@datoEmp.Poblacion}', '{@datoEmp.Estado}', '{@datoEmp.FechaNacimiento.ToShortDateString()}')";
                SqlCommand sql = new SqlCommand(query, objBD.connect);
                sql.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    return "No se puede ingresar 2 veces la misma cédula";
                }
                else
                {
                    return ex.Message;
                }
            }
            objBD.Cerrar();
            return "CORRECTO";
        }

        public void DeleteEmpleado(string id)
        {
            try
            {
                objBD.Abrir();
                string query = $"UPDATE Empleado SET Estado = 2 WHERE Cedula = '{@id}'";
                SqlCommand sql = new SqlCommand(query, objBD.connect);
                sql.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            objBD.Cerrar();
        }

        public void DeleteEmpleadoNS(string ns)
        {
            try
            {
                objBD.Abrir();
                string query = $"UPDATE Empleado SET Estado = 2 WHERE NumeroSeguridadSocial = '{@ns}'";
                SqlCommand sql = new SqlCommand(query, objBD.connect);
                sql.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            objBD.Cerrar();
        }

        public string UpdateEmpleado(Empleado datoEmp)
        {
            try
            {
                objBD.Abrir();
                string query = $"UPDATE Empleados SET Nombre = '{@datoEmp.Nombre}', Direccion = '{@datoEmp.Direccion}', NumeroSeguridadSocial = '{@datoEmp.NumSegSocial}', TipoEmpleado = '{@datoEmp.Tipo}', Poblacion = '{@datoEmp.Poblacion}', Estado = '{@datoEmp.Estado}', FechaNacimiento = '{@datoEmp.FechaNacimiento.ToShortDateString()}' WHERE Cedula = '{@datoEmp.Cedula}'";
                SqlCommand sql = new SqlCommand(query, objBD.connect);
                sql.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                objBD.Cerrar();
                return e.Message;
            }
            objBD.Cerrar();
            return "CORRECTO";
        }

        public Empleado SearchEmpleado(string id)
        {
            Empleado datoEmp;
            try
            {
                objBD.Abrir();
                string query = $"SELECT * FROM Empleados WHERE Cedula = '{@id}'";
                SqlCommand sql = new SqlCommand(query, objBD.connect);
                sql.ExecuteNonQuery();

                SqlDataReader reader = sql.ExecuteReader();

                if (reader.Read())
                {
                    Empleado objEnt = new Empleado()
                    {
                        Cedula = Convert.ToString(reader["Cedula"]),
                        Nombre = Convert.ToString(reader["Nombre"]),
                        Direccion = Convert.ToString(reader["Direccion"]),
                        NumSegSocial = Convert.ToString(reader["NumeroSeguridadSocial"]),
                        Tipo = Convert.ToInt16(reader["TipoEmpleado"]),
                        Poblacion = Convert.ToInt16(reader["Poblacion"]),
                        Estado = Convert.ToInt16(reader["Estado"]),
                        FechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"])
                    };
                    datoEmp = objEnt;
                }
                else
                    datoEmp = null;
            }
            catch (SqlException e)
            {
                datoEmp = null;
                Console.WriteLine(e.Message);
            }
            objBD.Cerrar();
            return datoEmp;
        }

        public Empleado SearchEmpleadoNS(string ns)
        {
            Empleado datoEmp;
            try
            {
                objBD.Abrir();
                string query = $"SELECT * FROM Empleados WHERE NumeroSeguridadSocial = '{@ns}'";
                SqlCommand sql = new SqlCommand(query, objBD.connect);
                sql.ExecuteNonQuery();

                SqlDataReader reader = sql.ExecuteReader();

                if (reader.Read())
                {
                    Empleado objEnt = new Empleado()
                    {
                        Cedula = Convert.ToString(reader["Cedula"]),
                        Nombre = Convert.ToString(reader["Nombre"]),
                        Direccion = Convert.ToString(reader["Direccion"]),
                        NumSegSocial = Convert.ToString(reader["NumeroSeguridadSocial"]),
                        Tipo = Convert.ToInt16(reader["TipoEmpleado"]),
                        Poblacion = Convert.ToInt16(reader["Poblacion"]),
                        Estado = Convert.ToInt16(reader["Estado"]),
                        FechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"])
                    };
                    datoEmp = objEnt;
                }
                else
                    datoEmp = null;
            }
            catch (SqlException e)
            {
                datoEmp = null;
                Console.WriteLine(e.Message);
            }
            objBD.Cerrar();
            return datoEmp;
        }

        //Paciente
        public List<Paciente> GetPacientes()
        {
            List<Paciente> datosPacientes = new List<Paciente>();
            try
            {
                objBD.Abrir();
                SqlCommand sql = new SqlCommand("SELECT * FROM Pacientes", objBD.connect);
                SqlDataReader reader = sql.ExecuteReader();
                while (reader.Read())
                {
                    Paciente objEnt = new Paciente()
                    {
                        Cedula = Convert.ToString(reader["Cedula"]),
                        Nombre = Convert.ToString(reader["Nombre"]),
                        Direccion = Convert.ToString(reader["Direccion"]),
                        NumSegSocial = Convert.ToString(reader["NumeroSeguridadSocial"]),
                        Medico = Convert.ToString(reader["CedulaMedico"]),
                        Estado = Convert.ToInt16(reader["Estado"]),
                        FechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"])
                    };
                    datosPacientes.Add(objEnt);
                }
            }
            catch
            {
                datosPacientes = null;
            }
            objBD.Cerrar();
            return datosPacientes;
        }

        public string RegistroPaciente(Paciente datoPac)
        {
            try
            {
                objBD.Abrir();
                string query = $"INSERT INTO Pacientes(Cedula, Nombre, Direccion, NumeroSeguridadSocial, CedulaMedico, Estado, FechaNacimiento) VALUES ('{@datoPac.Cedula}','{@datoPac.Nombre}','{@datoPac.Direccion}','{@datoPac.NumSegSocial}','{@datoPac.Medico}', '{@datoPac.Estado}', '{@datoPac.FechaNacimiento.ToShortDateString()}')";
                SqlCommand sql = new SqlCommand(query, objBD.connect);
                sql.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    // Clave primaria duplicada
                    return "2627";
                }
                else
                {
                    return ex.Message;
                }
            }
            objBD.Cerrar();
            return "CORRECTO";
        }

        public void DeletePaciente(string id)
        {
            try
            {
                objBD.Abrir();
                string query = $"UPDATE Pacientes SET Estado = 2 WHERE Cedula = '{@id}'";
                SqlCommand sql = new SqlCommand(query, objBD.connect);
                sql.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            objBD.Cerrar();
        }

        public void DeletePacienteNS(string ns)
        {
            try
            {
                objBD.Abrir();
                string query = $"UPDATE Pacientes SET Estado = 2 WHERE NumeroSeguridadSocial = '{@ns}'";
                SqlCommand sql = new SqlCommand(query, objBD.connect);
                sql.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            objBD.Cerrar();
        }

        public string UpdatePaciente(Paciente datoPac)
        {
            try
            {
                objBD.Abrir();
                string query = $"UPDATE Pacientes SET Nombre = '{@datoPac.Nombre}', Direccion = '{@datoPac.Direccion}', NumeroSeguridadSocial = '{@datoPac.NumSegSocial}', CedulaMedico = '{@datoPac.Medico}', Estado = '{@datoPac.Estado}', FechaNacimiento = '{@datoPac.FechaNacimiento.ToShortDateString()}' WHERE Cedula = '{@datoPac.Cedula}'";
                SqlCommand sql = new SqlCommand(query, objBD.connect);
                sql.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                objBD.Cerrar();
                return e.Message;
            }
            objBD.Cerrar();
            return "CORRECTO";
        }

        public Paciente SearchPaciente(string id)
        {
            Paciente datoPac;
            try
            {
                objBD.Abrir();
                string query = $"SELECT * FROM Pacientes WHERE Cedula = '{@id}'";
                SqlCommand sql = new SqlCommand(query, objBD.connect);
                sql.ExecuteNonQuery();

                SqlDataReader reader = sql.ExecuteReader();

                if (reader.Read())
                {
                    Paciente objEnt = new Paciente()
                    {
                        Cedula = Convert.ToString(reader["Cedula"]),
                        Nombre = Convert.ToString(reader["Nombre"]),
                        Direccion = Convert.ToString(reader["Direccion"]),
                        NumSegSocial = Convert.ToString(reader["NumeroSeguridadSocial"]),
                        Medico = Convert.ToString(reader["CedulaMedico"]),
                        Estado = Convert.ToInt16(reader["Estado"]),
                        FechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"])
                    };
                    datoPac = objEnt;
                }
                else
                    datoPac = null;
            }
            catch (SqlException e)
            {
                datoPac = null;
                Console.WriteLine(e.Message);
            }
            objBD.Cerrar();
            return datoPac;
        }

        public Paciente SearchPacienteNS(string ns)
        {
            Paciente datoPac;
            try
            {
                objBD.Abrir();
                string query = $"SELECT * FROM Pacientes WHERE NumeroSeguridadSocial = '{@ns}'";
                SqlCommand sql = new SqlCommand(query, objBD.connect);
                sql.ExecuteNonQuery();

                SqlDataReader reader = sql.ExecuteReader();

                if (reader.Read())
                {
                    Paciente objEnt = new Paciente()
                    {
                        Cedula = Convert.ToString(reader["Cedula"]),
                        Nombre = Convert.ToString(reader["Nombre"]),
                        Direccion = Convert.ToString(reader["Direccion"]),
                        NumSegSocial = Convert.ToString(reader["NumeroSeguridadSocial"]),
                        Medico = Convert.ToString(reader["CedulaMedico"]),
                        Estado = Convert.ToInt16(reader["Estado"]),
                        FechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"])
                    };
                    datoPac = objEnt;
                }
                else
                    datoPac = null;
            }
            catch (SqlException e)
            {
                datoPac = null;
                Console.WriteLine(e.Message);
            }
            objBD.Cerrar();
            return datoPac;
        }

        //Poblacion
        public List<Poblacion> GetPoblaciones()
        {
            List<Poblacion> datosPoblaciones = new List<Poblacion>();
            try
            {
                objBD.Abrir();
                SqlCommand sql = new SqlCommand("SELECT * FROM Poblacion", objBD.connect);
                SqlDataReader reader = sql.ExecuteReader();

                while (reader.Read())
                {
                    Poblacion objEnt = new Poblacion()
                    {
                        PID = Convert.ToInt16(reader["id"]),
                        Descripcion = Convert.ToString(reader["descripcion"])
                    };
                    datosPoblaciones.Add(objEnt);
                }

            }
            catch (Exception e)
            {
                datosPoblaciones = null;
                Console.WriteLine(e);
            }
            objBD.Cerrar();
            return datosPoblaciones;
        }

        public string RegistroPoblacion(Poblacion datoPob)
        {
            try
            {
                objBD.Abrir();
                string query = $"INSERT INTO Poblacion(id, descripcion) VALUES ('{@datoPob.PID}', '{@datoPob.Descripcion}')";
                SqlCommand sql = new SqlCommand(query, objBD.connect);
                sql.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                if (e.Number == 2627)
                {
                    // Clave primaria duplicada
                    return "No se puede ingresar 2 veces la misma cédula";
                }
            }
            objBD.Cerrar();
            return "CORRECTO";
        }

        public void DeletePoblacion(int id)
        {
            try
            {
                objBD.Abrir();
                string query = $"DELETE FROM Poblacion WHERE id = '{@id}'";
                SqlCommand sql = new SqlCommand(query, objBD.connect);
                sql.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            objBD.Cerrar();
        }

        public void UpdatePoblacion(Poblacion datoPob)
        {
            try
            {
                objBD.Abrir();
                string query = $"UPDATE Poblaciones SET Descripcion = '{@datoPob.Descripcion}' WHERE id = '{@datoPob.PID}'";
                SqlCommand sql = new SqlCommand(query, objBD.connect);
                sql.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            objBD.Cerrar();
        }

        public Poblacion SearchPoblacion(int id)
        {
            Poblacion datoPob;
            try
            {
                objBD.Abrir();
                string query = $"SELECT * FROM Poblacion WHERE id = '{@id}'";
                SqlCommand sql = new SqlCommand(query, objBD.connect);
                sql.ExecuteNonQuery();

                SqlDataReader reader = sql.ExecuteReader();

                if (reader.Read())
                {
                    Poblacion objEnt = new Poblacion()
                    {
                        PID = Convert.ToInt16(reader["id"]),
                        Descripcion = Convert.ToString(reader["descripcion"])
                    };
                    datoPob = objEnt;
                }
                else
                    datoPob = null;
            }
            catch (SqlException e)
            {
                datoPob = null;
                Console.WriteLine(e.Message);
            }
            objBD.Cerrar();
            return datoPob;
        }

        //Horarios
        public List<Horarios> GetHorarios()
        {
            List<Horarios> datosHorarios = new List<Horarios>();
            try
            {
                objBD.Abrir();
                SqlCommand sql = new SqlCommand("SELECT * FROM Horarios", objBD.connect);
                SqlDataReader reader = sql.ExecuteReader();
                while (reader.Read())
                {
                    Horarios objEnt = new Horarios()
                    {
                        HorID = Convert.ToInt16(reader["HorarioID"]),
                        CedulaMedico = Convert.ToString(reader["CedulaMedico"]),
                        DiaSemana = Convert.ToString(reader["DiaSemana"]),
                        HoraInicio = Convert.ToDateTime(reader["HoraInicio"]),
                        HoraFin = Convert.ToDateTime(reader["HoraFin"])
                    };
                    datosHorarios.Add(objEnt);
                }
            }
            catch
            {
                datosHorarios = null;
            }
            objBD.Cerrar();
            return datosHorarios;
        }

        public string RegistroHorario(Horarios datoHor)
        {
            try
            {
                objBD.Abrir();
                string query = $"INSERT INTO Horarios(HorarioID, CedulaMedico, DiaSemana, HoraInicio, HoraFin) VALUES ({@datoHor.HorID}, '{@datoHor.CedulaMedico}', '{@datoHor.DiaSemana}', '{@datoHor.HoraInicio.ToShortTimeString()}', '{@datoHor.HoraFin.ToShortTimeString()}')";
                SqlCommand sql = new SqlCommand(query, objBD.connect);
                sql.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                if (e.Number == 2627)
                {
                    // Clave primaria duplicada
                    return "No se puede ingresar 2 veces la misma cédula";
                }
            }
            objBD.Cerrar();
            return "CORRECTO";
        }

        public void DeleteHorario(int id)
        {
            try
            {
                objBD.Abrir();
                string query = $"DELETE FROM Horarios WHERE HorarioID = '{@id}'";
                SqlCommand sql = new SqlCommand(query, objBD.connect);
                sql.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            objBD.Cerrar();
        }

        public void UpdateHorario(Horarios datoHor)
        {
            try
            {
                objBD.Abrir();
                string query = $"UPDATE Horarios SET CedulaMedico = '{@datoHor.CedulaMedico}', DiaSemana = '{@datoHor.DiaSemana}', HoraInicio = '{@datoHor.HoraInicio.ToShortTimeString()}', HoraFin = '{@datoHor.HoraFin.ToShortTimeString()}' WHERE HorarioID = '{@datoHor.HorID}'";
                SqlCommand sql = new SqlCommand(query, objBD.connect);
                sql.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            objBD.Cerrar();
        }

        public Horarios SearchHorario(int id)
        {
            Horarios datoHor;
            try
            {
                objBD.Abrir();
                string query = $"SELECT * FROM Horarios WHERE HorarioID = '{@id}'";
                SqlCommand sql = new SqlCommand(query, objBD.connect);
                sql.ExecuteNonQuery();

                SqlDataReader reader = sql.ExecuteReader();

                if (reader.Read())
                {
                    Horarios objEnt = new Horarios()
                    {
                        HorID = Convert.ToInt16(reader["HorarioID"]),
                        CedulaMedico = Convert.ToString(reader["CedulaMedico"]),
                        DiaSemana = Convert.ToString(reader["DiaSemana"]),
                        HoraInicio = Convert.ToDateTime(reader["HoraInicio"]),
                        HoraFin = Convert.ToDateTime(reader["HoraFin"])
                    };
                    datoHor = objEnt;
                }
                else
                    datoHor = null;
            }
            catch (SqlException e)
            {
                datoHor = null;
                Console.WriteLine(e.Message);
            }
            objBD.Cerrar();
            return datoHor;
        }

        //Vacaciones
        public List<Vacaciones> GetVacaciones()
        {
            List<Vacaciones> datosVacaciones = new List<Vacaciones>();
            try
            {
                objBD.Abrir();
                SqlCommand sql = new SqlCommand("SELECT * FROM Vacaciones", objBD.connect);
                SqlDataReader reader = sql.ExecuteReader();
                while (reader.Read())
                {
                    Vacaciones objEnt = new Vacaciones()
                    {
                        VID = Convert.ToInt16(reader["VacacionesID"]),
                        Cedula = Convert.ToString(reader["Cedula"]),
                        FechaInicio = Convert.ToDateTime(reader["FechaInicio"]),
                        FechaFin = Convert.ToDateTime(reader["FechaFin"]),
                        Estado = Convert.ToInt16(reader["Estado"])
                    };
                    datosVacaciones.Add(objEnt);
                }
            }
            catch
            {
                datosVacaciones = null;
            }
            objBD.Cerrar();
            return datosVacaciones;
        }

        public string RegistroVacacion(Vacaciones datoVac)
        {
            try
            {
                objBD.Abrir();
                string query = $"INSERT INTO Vacaciones(Cedula, FechaInicio, FechaFin, Estado) VALUES ('{@datoVac.Cedula}', '{@datoVac.FechaInicio.ToShortDateString()}', '{@datoVac.FechaFin.ToShortDateString()}', '{@datoVac.Estado}')";
                SqlCommand sql = new SqlCommand(query, objBD.connect);
                sql.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    // Clave primaria duplicada
                    return "2627";
                }
                else
                {
                    return ex.Message;
                }
            }
            objBD.Cerrar();
            return "CORRECTO";
        }

        // public void DeleteVacacion(int id)
        // {
        //     try
        //     {
        //         objBD.Abrir();
        //         string query = $"DELETE FROM Vacaciones WHERE VacacionesID = '{@id}'";
        //         SqlCommand sql = new SqlCommand(query, objBD.connect);
        //         sql.ExecuteNonQuery();
        //         objBD.Cerrar();
        //     }
        //     catch (SqlException e)
        //     {
        //         Console.WriteLine(e.Message);
        //     }
        // }

        public string UpdateVacacion(Vacaciones datoVac)
        {
            try
            {
                objBD.Abrir();
                string query = $"UPDATE Vacaciones SET Cedula = '{@datoVac.Cedula}', FechaInicio = '{@datoVac.FechaInicio.ToShortDateString()}', FechaFin = '{@datoVac.FechaFin.ToShortDateString()}', Estado = '{@datoVac.Estado}' WHERE VacacionesID = '{@datoVac.VID}'";
                SqlCommand sql = new SqlCommand(query, objBD.connect);
                sql.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                objBD.Cerrar();
                return e.Message;
            }
            objBD.Cerrar();
            return "CORRECTO";
        }

        public Vacaciones SearchVacacionCedula(string id)
        {
            Vacaciones datoVac;
            try
            {
                objBD.Abrir();
                string query = $"SELECT * FROM Vacaciones WHERE Cedula = '{@id}'";
                SqlCommand sql = new SqlCommand(query, objBD.connect);
                sql.ExecuteNonQuery();

                SqlDataReader reader = sql.ExecuteReader();

                if (reader.Read())
                {
                    Vacaciones objEnt = new Vacaciones()
                    {
                        VID = Convert.ToInt16(reader["VacacionesID"]),
                        Cedula = Convert.ToString(reader["Cedula"]),
                        FechaInicio = Convert.ToDateTime(reader["FechaInicio"]),
                        FechaFin = Convert.ToDateTime(reader["FechaFin"]),
                        Estado = Convert.ToInt16(reader["Estado"])
                    };
                    datoVac = objEnt;
                }
                else
                    datoVac = null;
            }
            catch (SqlException e)
            {
                datoVac = null;
                Console.WriteLine(e.Message);
            }
            objBD.Cerrar();
            return datoVac;
        }

        public Vacaciones SearchVacacion(int id, string cedula)
        {
            Vacaciones datoVac;
            try
            {
                objBD.Abrir();
                string query = $"SELECT * FROM Vacaciones WHERE VacacionesID = {@id} AND Cedula = '{@cedula}'";
                SqlCommand sql = new SqlCommand(query, objBD.connect);
                sql.ExecuteNonQuery();

                SqlDataReader reader = sql.ExecuteReader();

                if (reader.Read())
                {
                    Vacaciones objEnt = new Vacaciones()
                    {
                        VID = Convert.ToInt16(reader["VacacionesID"]),
                        Cedula = Convert.ToString(reader["Cedula"]),
                        FechaInicio = Convert.ToDateTime(reader["FechaInicio"]),
                        FechaFin = Convert.ToDateTime(reader["FechaFin"]),
                        Estado = Convert.ToInt16(reader["Estado"])
                    };
                    datoVac = objEnt;
                }
                else
                    datoVac = null;
            }
            catch (SqlException e)
            {
                datoVac = null;
                Console.WriteLine(e.Message);
            }
            objBD.Cerrar();
            return datoVac;
        }

        //Consulta
        public List<Consulta> GetConsultas()
        {
            List<Consulta> datosConsultas = new List<Consulta>();
            try
            {
                objBD.Abrir();
                SqlCommand sql = new SqlCommand("SELECT * FROM Consultas", objBD.connect);
                SqlDataReader reader = sql.ExecuteReader();
                while (reader.Read())
                {
                    Consulta objEnt = new Consulta()
                    {
                        CID = Convert.ToInt16(reader["ConsultaID"]),
                        Descripcion = Convert.ToString(reader["Descripcion"]),
                        Medico = Convert.ToString(reader["Medico"]),
                        Paciente = Convert.ToString(reader["Paciente"]),
                        Fecha = Convert.ToDateTime(reader["Fecha"])
                    };
                    datosConsultas.Add(objEnt);
                }
            }
            catch
            {
                datosConsultas = null;
            }
            objBD.Cerrar();
            return datosConsultas;
        }

        public string RegistroConsulta(Consulta datoConsulta)
        {
            try
            {
                objBD.Abrir();
                string query = $"INSERT INTO Consultas(Descripcion, Medico, Paciente, Fecha) VALUES ('{@datoConsulta.Descripcion}', '{@datoConsulta.Medico}', '{@datoConsulta.Paciente}', '{@datoConsulta.Fecha.ToShortDateString()}')";
                SqlCommand sql = new SqlCommand(query, objBD.connect);
                sql.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                if (e.Number == 2627)
                {
                    // Clave primaria duplicada
                    return "No se puede ingresar 2 veces la misma cédula";
                }
                else
                {
                    return e.Message;
                }
            }
            objBD.Cerrar();
            return "CORRECTO";
        }

        public string UpdateConsulta(Consulta datoConsulta)
        {
            try
            {
                objBD.Abrir();
                string query = $"UPDATE Consultas SET Descripcion = '{@datoConsulta.Descripcion}', Medico = '{@datoConsulta.Medico}', Paciente = '{@datoConsulta.Paciente}', Fecha = '{@datoConsulta.Fecha.ToShortDateString()}' WHERE ConsultaID = '{@datoConsulta.CID}'";
                SqlCommand sql = new SqlCommand(query, objBD.connect);
                sql.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                objBD.Cerrar();
                return e.Message;
            }
            objBD.Cerrar();
            return "CORRECTO";
        }

        public Consulta SearchConsulta(string id)
        {
            Consulta datoConsulta;
            try
            {
                objBD.Abrir();
                string query = $"SELECT * FROM Consultas WHERE ConsultaID = '{@id}'";
                SqlCommand sql = new SqlCommand(query, objBD.connect);
                sql.ExecuteNonQuery();

                SqlDataReader reader = sql.ExecuteReader();

                if (reader.Read())
                {
                    Consulta objEnt = new Consulta()
                    {
                        CID = Convert.ToInt16(reader["ConsultaID"]),
                        Descripcion = Convert.ToString(reader["Descripcion"]),
                        Medico = Convert.ToString(reader["Medico"]),
                        Paciente = Convert.ToString(reader["Paciente"]),
                        Fecha = Convert.ToDateTime(reader["Fecha"])
                    };
                    datoConsulta = objEnt;
                }
                else
                    datoConsulta = null;
            }
            catch (SqlException e)
            {
                datoConsulta = null;
                Console.WriteLine(e.Message);
            }
            objBD.Cerrar();
            return datoConsulta;
        }

        public Consulta SearchConsultaPaciente(string id)
        {
            Consulta datoConsulta;
            try
            {
                objBD.Abrir();
                string query = $"SELECT * FROM Consultas WHERE Paciente = '{@id}'";
                SqlCommand sql = new SqlCommand(query, objBD.connect);
                sql.ExecuteNonQuery();

                SqlDataReader reader = sql.ExecuteReader();

                if (reader.Read())
                {
                    Consulta objEnt = new Consulta()
                    {
                        CID = Convert.ToInt16(reader["ConsultaID"]),
                        Descripcion = Convert.ToString(reader["Descripcion"]),
                        Medico = Convert.ToString(reader["Medico"]),
                        Paciente = Convert.ToString(reader["Paciente"]),
                        Fecha = Convert.ToDateTime(reader["Fecha"])
                    };
                    datoConsulta = objEnt;
                }
                else
                    datoConsulta = null;
            }
            catch (SqlException e)
            {
                datoConsulta = null;
                Console.WriteLine(e.Message);
            }
            objBD.Cerrar();
            return datoConsulta;
        }

        public Consulta SearchConsultaMedico(string id)
        {
            Consulta datoConsulta;
            try
            {
                objBD.Abrir();
                string query = $"SELECT * FROM Consultas WHERE Medico = '{@id}'";
                SqlCommand sql = new SqlCommand(query, objBD.connect);
                sql.ExecuteNonQuery();

                SqlDataReader reader = sql.ExecuteReader();

                if (reader.Read())
                {
                    Consulta objEnt = new Consulta()
                    {
                        CID = Convert.ToInt16(reader["ConsultaID"]),
                        Descripcion = Convert.ToString(reader["Descripcion"]),
                        Medico = Convert.ToString(reader["Medico"]),
                        Paciente = Convert.ToString(reader["Paciente"]),
                        Fecha = Convert.ToDateTime(reader["Fecha"])
                    };
                    datoConsulta = objEnt;
                }
                else
                    datoConsulta = null;
            }
            catch (SqlException e)
            {
                datoConsulta = null;
                Console.WriteLine(e.Message);
            }
            objBD.Cerrar();
            return datoConsulta;
        }

        //TipoEmpleado
        public List<TipoEmpleado> GetTipoEmpleado()
        {
            List<TipoEmpleado> datosTipoEmpleado = new List<TipoEmpleado>();
            try
            {
                objBD.Abrir();
                SqlCommand sql = new SqlCommand("SELECT * FROM TipoEmpleado", objBD.connect);
                SqlDataReader reader = sql.ExecuteReader();
                while (reader.Read())
                {
                    TipoEmpleado objEnt = new TipoEmpleado()
                    {
                        ID = Convert.ToInt16(reader["Id"]),
                        Descripcion = Convert.ToString(reader["Descripcion"]),
                    };
                    datosTipoEmpleado.Add(objEnt);
                }
            }
            catch
            {
                datosTipoEmpleado = null;
            }
            objBD.Cerrar();
            return datosTipoEmpleado;
        }

        //TipoMedico
        public List<TipoMedico> GetTipoMedico()
        {
            List<TipoMedico> datosTipoMedico = new List<TipoMedico>();
            try
            {
                objBD.Abrir();
                SqlCommand sql = new SqlCommand("SELECT * FROM TipoMedico", objBD.connect);
                SqlDataReader reader = sql.ExecuteReader();
                while (reader.Read())
                {
                    TipoMedico objEnt = new TipoMedico()
                    {
                        ID = Convert.ToInt16(reader["Id"]),
                        Descripcion = Convert.ToString(reader["Descripcion"]),
                    };
                    datosTipoMedico.Add(objEnt);
                }
            }
            catch
            {
                datosTipoMedico = null;
            }
            objBD.Cerrar();
            return datosTipoMedico;
        }

        //MedicoVacaciones
        public SqlDataAdapter GetMedicoVacaciones()
        {
            SqlDataAdapter adp = new SqlDataAdapter("", objBD.connect);
            try
            {
                objBD.Abrir();
                string query = "SELECT Nombre, FechaInicio, FechaFin, PE.Descripcion AS Estado FROM Vacaciones JOIN Medicos M on Vacaciones.Cedula = M.Cedula JOIN PersonaEstado PE on M.Estado = PE.Id";
                adp = new SqlDataAdapter(query, objBD.connect);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                objBD.Cerrar();
            }
            catch (Exception e)
            {
                objBD.Cerrar();
                Console.WriteLine(e.Message);
            }
            return adp;
        }

        //MedicoTipos
        public SqlDataAdapter GetMedicoTipos()
        {
            SqlDataAdapter adp = new SqlDataAdapter("", objBD.connect);
            try
            {
                objBD.Abrir();
                string query = "SELECT Cedula,Nombre,NumeroSeguridadSocial,NumeroColegiado,Descripcion AS TipoMedico FROM Medicos JOIN TipoMedico TM on Medicos.TipoMedico = TM.Id";
                adp = new SqlDataAdapter(query, objBD.connect);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                objBD.Cerrar();
            }
            catch (Exception e)
            {
                objBD.Cerrar();
                Console.WriteLine(e.Message);
            }
            return adp;
        }

        //PacientesReport
        public SqlDataAdapter GetPacientesAD()
        {
            SqlDataAdapter adp = new SqlDataAdapter("", objBD.connect);
            try
            {
                objBD.Abrir();
                string query = "SELECT * FROM Pacientes";
                adp = new SqlDataAdapter(query, objBD.connect);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                objBD.Cerrar();
            }
            catch (Exception e)
            {
                objBD.Cerrar();
                Console.WriteLine(e.Message);
            }
            return adp;
        }

        //Administrador
        public bool GetAdministrador(string id, string psw)
        {
            try
            {
                objBD.Abrir();
                string query = $"SELECT * FROM Administrador WHERE UserID = '{@id}' AND Psw = '{@psw}'";
                SqlCommand sql = new SqlCommand(query, objBD.connect);
                sql.ExecuteNonQuery();

                SqlDataReader reader = sql.ExecuteReader();

                if (reader.Read())
                {
                    Administrador objEnt = new Administrador()
                    {
                        UserID = Convert.ToString(reader["UserID"]),
                        Psw = Convert.ToString(reader["Psw"])
                    };
                }
                else
                    return false;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                objBD.Cerrar();
                return false;
            }
            objBD.Cerrar();
            return true; ;
        }

        public SqlDataAdapter GetEmpleadoTipos()
        {
            SqlDataAdapter adp = new SqlDataAdapter("", objBD.connect);
            try
            {
                objBD.Abrir();
                string query = "SELECT Cedula, Nombre, Descripcion AS 'Tipo de Empleado' FROM Empleados JOIN TipoEmpleado TE on TE.Id = Empleados.TipoEmpleado";
                adp = new SqlDataAdapter(query, objBD.connect);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                objBD.Cerrar();
            }
            catch (Exception e)
            {
                objBD.Cerrar();
                Console.WriteLine(e.Message);
            }
            return adp;
        }

        public SqlDataAdapter GetEmpleadoVacaciones()
        {
            SqlDataAdapter adp = new SqlDataAdapter("SELECT Nombre, FechaInicio, FechaFin, PE.Descripcion AS Estado FROM Vacaciones JOIN Empleados E on Vacaciones.Cedula = E.Cedula JOIN PersonaEstado PE on E.Estado = PE.Id", objBD.connect);
            try
            {
                objBD.Abrir();
                string query = "";
                adp = new SqlDataAdapter(query, objBD.connect);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                objBD.Cerrar();
            }
            catch (Exception e)
            {
                objBD.Cerrar();
                Console.WriteLine(e.Message);
            }
            return adp;
        }
    }
}