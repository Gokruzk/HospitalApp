using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Entidades;

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
                SqlCommand sql = new SqlCommand("SELECT * FROM Medicos");
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
                        Tipo = Convert.ToString(reader["TipoMedico"]),
                        Poblacion = Convert.ToInt16(reader["Poblacion"]),
                        FechaA = Convert.ToDateTime(reader["FechaA"]),
                        FechaB = Convert.ToDateTime(reader["FechaB"])
                    };
                    datosMedicos.Add(objEnt);
                }
            }
            catch
            {
                datosMedicos = null;
                objBD.Cerrar();
            }
            return datosMedicos;
        }

        public void RegistroMedico(Medico datoMed)
        {
            try
            {
                objBD.Abrir();
                string query = $"INSERT INTO Medicos(Cedula, Nombre, Direccion,  NumeroSeguridadSocial, NumeroColegiado, TipoMedico, Poblacion, FechaA, FechaB) VALUES ('{@datoMed.Cedula}','{@datoMed.Nombre}','{@datoMed.Direccion}','{@datoMed.NumSegSocial}','{@datoMed.NumColegiado}','{@datoMed.Tipo}','{@datoMed.Poblacion}','{@datoMed.FechaA}','{@datoMed.FechaB}')";
                SqlCommand sql = new SqlCommand(query, objBD.connect);
                sql.ExecuteNonQuery();
                objBD.Cerrar();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void DeleteMedico(string id)
        {
            try
            {
                objBD.Abrir();
                string query = $"DELETE FROM Medicos WHERE Cedula = '{@id}'";
                SqlCommand sql = new SqlCommand(query, objBD.connect);
                sql.ExecuteNonQuery();
                objBD.Cerrar();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void UpdateMedico(Medico datoMed)
        {
            try
            {
                objBD.Abrir();
                string query = $"UPDATE Medicos SET Nombre = '{@datoMed.Nombre}', Direccion = '{@datoMed.Direccion}', NumeroSeguridadSocial = '{@datoMed.NumSegSocial}', NumeroColegiado = '{@datoMed.NumColegiado}', TipoMedico = '{@datoMed.Tipo}', Poblacion = '{@datoMed.Poblacion}', FechaA = '{@datoMed.FechaA}', FechaB = '{@datoMed.FechaB}' WHERE Cedula = '{@datoMed.Cedula}'";
                SqlCommand sql = new SqlCommand(query, objBD.connect);
                sql.ExecuteNonQuery();
                objBD.Cerrar();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public Medico SearchMedico(string id)
        {
            Medico datoMed = new Medico();
            try
            {
                objBD.Abrir();
                string query = $"SELECT * FROM Medicos WHERE Cedula = '{@id}";
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
                        Tipo = Convert.ToString(reader["TipoMedico"]),
                        Poblacion = Convert.ToInt16(reader["Poblacion"]),
                        FechaA = Convert.ToDateTime(reader["FechaA"]),
                        FechaB = Convert.ToDateTime(reader["FechaB"])
                    };
                    datoMed = objEnt;
                }
                objBD.Cerrar();
            }
            catch (Exception e)
            {
                datoMed = null;
                objBD.Cerrar();
                Console.WriteLine(e.Message);
            }
            return datoMed;
        }

        //Empleado
        public List<Empleado> GetEmpleados()
        {
            List<Empleado> datosEmpleados = new List<Empleado>();
            try
            {
                objBD.Abrir();
                SqlCommand sql = new SqlCommand("SELECT * FROM Empleados");
                SqlDataReader reader = sql.ExecuteReader();
                while (reader.Read())
                {
                    Empleado objEnt = new Empleado()
                    {
                        Cedula = Convert.ToString(reader["Cedula"]),
                        Nombre = Convert.ToString(reader["Nombre"]),
                        Direccion = Convert.ToString(reader["Direccion"]),
                        NumSegSocial = Convert.ToString(reader["NumeroSeguridadSocial"]),
                        Tipo = Convert.ToString(reader["Tipo"]),
                        Poblacion = Convert.ToInt16(reader["Poblacion"])
                    };
                    datosEmpleados.Add(objEnt);
                }
            }
            catch
            {
                datosEmpleados = null;
                objBD.Cerrar();
            }
            return datosEmpleados;
        }

        public void RegistroEmpleado(Empleado datoEmp)
        {
            try
            {
                objBD.Abrir();
                string query = $"INSERT INTO Empleados(Cedula, Nombre, Direccion, NumeroSeguridadSocial, TipoEmpleado, Poblacion) VALUES ('{@datoEmp.Cedula}', {@datoEmp.Nombre}','{@datoEmp.Direccion}', '{@datoEmp.NumSegSocial}','{@datoEmp.Tipo}','{@datoEmp.Poblacion}')";
                SqlCommand sql = new SqlCommand(query, objBD.connect);
                sql.ExecuteNonQuery();
                objBD.Cerrar();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void DeleteEmpleado(string id)
        {
            try
            {
                objBD.Abrir();
                string query = $"DELETE FROM Empleados WHERE Cedula = '{@id}'";
                SqlCommand sql = new SqlCommand(query, objBD.connect);
                sql.ExecuteNonQuery();
                objBD.Cerrar();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void UpdateEmpleado(Empleado datoEmp)
        {
            try
            {
                objBD.Abrir();
                string query = $"UPDATE Empleados SET Nombre = '{@datoEmp.Nombre}', Direccion = '{@datoEmp.Direccion}', NumeroSeguridadSocial = '{@datoEmp.NumSegSocial}', Tipo = '{@datoEmp.Tipo}', Poblacion = '{@datoEmp.Poblacion}' WHERE Cedula = '{@datoEmp.Cedula}'";
                SqlCommand sql = new SqlCommand(query, objBD.connect);
                sql.ExecuteNonQuery();
                objBD.Cerrar();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public Empleado SearchEmpleado(string id)
        {
            Empleado datoEmp = new Empleado();
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
                        Tipo = Convert.ToString(reader["Tipo"]),
                        Poblacion = Convert.ToInt16(reader["Poblacion"])
                    };
                    datoEmp = objEnt;
                }
                objBD.Cerrar();
            }
            catch (Exception e)
            {
                datoEmp = null;
                objBD.Cerrar();
                Console.WriteLine(e.Message);
            }
            return datoEmp;
        }

        //Paciente
        public List<Paciente> GetPacientes()
        {
            List<Paciente> datosPacientes = new List<Paciente>();
            try
            {
                objBD.Abrir();
                SqlCommand sql = new SqlCommand("SELECT * FROM Pacientes");
                SqlDataReader reader = sql.ExecuteReader();
                while (reader.Read())
                {
                    Paciente objEnt = new Paciente()
                    {
                        Cedula = Convert.ToString(reader["Cedula"]),
                        Nombre = Convert.ToString(reader["Nombre"]),
                        Direccion = Convert.ToString(reader["Direccion"]),
                        NumSegSocial = Convert.ToString(reader["NumeroSeguridadSocial"]),
                        Medico = Convert.ToString(reader["CedulaMedico"])
                    };
                    datosPacientes.Add(objEnt);
                }
            }
            catch
            {
                datosPacientes = null;
                objBD.Cerrar();
            }
            return datosPacientes;
        }

        public void RegistroPaciente(Paciente datoPac)
        {
            try
            {
                objBD.Abrir();
                string query = $"INSERT INTO Pacientes(Cedula, Nombre, Direccion, NumeroSeguridadSocial, CedulaMedico) VALUES ('{@datoPac.Cedula}','{@datoPac.Nombre}','{@datoPac.Direccion}','{@datoPac.NumSegSocial}','{@datoPac.Medico}')";
                SqlCommand sql = new SqlCommand(query, objBD.connect);
                sql.ExecuteNonQuery();
                objBD.Cerrar();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void DeletePaciente(string id)
        {
            try
            {
                objBD.Abrir();
                string query = $"DELETE FROM Pacientes WHERE Cedula = '{@id}'";
                SqlCommand sql = new SqlCommand(query, objBD.connect);
                sql.ExecuteNonQuery();
                objBD.Cerrar();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void UpdatePaciente(Paciente datoPac)
        {
            try
            {
                objBD.Abrir();
                string query = $"UPDATE Pacientes SET Nombre = '{@datoPac.Nombre}', Direccion = '{@datoPac.Direccion}', NumeroSeguridadSocial = '{@datoPac.NumSegSocial}', CedulaMedico = '{@datoPac.Medico}' WHERE Cedula = '{@datoPac.Cedula}'";
                SqlCommand sql = new SqlCommand(query, objBD.connect);
                sql.ExecuteNonQuery();
                objBD.Cerrar();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public Paciente SearchPaciente(string id)
        {
            Paciente datoPac = new Paciente();
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
                        Medico = Convert.ToString(reader["CedulaMedico"])
                    };
                    datoPac = objEnt;
                }
                objBD.Cerrar();
            }
            catch (Exception e)
            {
                datoPac = null;
                objBD.Cerrar();
                Console.WriteLine(e.Message);
            }
            return datoPac;
        }

        //Poblacion
        public List<Poblacion> GetPoblaciones()
        {
            List<Poblacion> datosPoblaciones = new List<Poblacion>();
            try
            {
                objBD.Abrir();
                SqlCommand sql = new SqlCommand("SELECT * FROM Poblacion");
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
            catch
            {
                datosPoblaciones = null;
                objBD.Cerrar();
            }
            return datosPoblaciones;
        }

        public void RegistroPoblacion(Poblacion datoPob)
        {
            try
            {
                objBD.Abrir();
                string query = $"INSERT INTO Poblacion(id, descripcion) VALUES ('{@datoPob.PID}', '{@datoPob.Descripcion}')";
                SqlCommand sql = new SqlCommand(query, objBD.connect);
                sql.ExecuteNonQuery();
                objBD.Cerrar();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void DeletePoblacion(int id)
        {
            try
            {
                objBD.Abrir();
                string query = $"DELETE FROM Poblacion WHERE id = '{@id}'";
                SqlCommand sql = new SqlCommand(query, objBD.connect);
                sql.ExecuteNonQuery();
                objBD.Cerrar();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void UpdatePoblacion(Poblacion datoPob)
        {
            try
            {
                objBD.Abrir();
                string query = $"UPDATE Poblaciones SET Descripcion = '{@datoPob.Descripcion}' WHERE id = '{@datoPob.PID}'";
                SqlCommand sql = new SqlCommand(query, objBD.connect);
                sql.ExecuteNonQuery();
                objBD.Cerrar();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public Poblacion SearchPoblacion(int id)
        {
            Poblacion datoPob = new Poblacion();
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
                objBD.Cerrar();
            }
            catch (Exception e)
            {
                datoPob = null;
                objBD.Cerrar();
                Console.WriteLine(e.Message);
            }
            return datoPob;
        }

        //Horarios
        public List<Horarios> GetHorarios()
        {
            List<Horarios> datosHorarios = new List<Horarios>();
            try
            {
                objBD.Abrir();
                SqlCommand sql = new SqlCommand("SELECT * FROM Horarios");
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
                objBD.Cerrar();
            }
            return datosHorarios;
        }

        public void RegistroHorario(Horarios datoHor)
        {
            try
            {
                objBD.Abrir();
                string query = $"INSERT INTO Horarios(HorarioID, CedulaMedico, DiaSemana, HoraInicio, HoraFin) VALUES ({@datoHor.HorID}, '{@datoHor.CedulaMedico}', '{@datoHor.DiaSemana}', '{@datoHor.HoraInicio.ToString("yyyy-MM-dd HH:mm:ss")}', '{@datoHor.HoraFin.ToString("yyyy-MM-dd HH:mm:ss")}')";
                SqlCommand sql = new SqlCommand(query, objBD.connect);
                sql.ExecuteNonQuery();
                objBD.Cerrar();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void DeleteHorario(int id)
        {
            try
            {
                objBD.Abrir();
                string query = $"DELETE FROM Horarios WHERE HorarioID = '{@id}'";
                SqlCommand sql = new SqlCommand(query, objBD.connect);
                sql.ExecuteNonQuery();
                objBD.Cerrar();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void UpdateHorario(Horarios datoHor)
        {
            try
            {
                objBD.Abrir();
                string query = $"UPDATE Horarios SET CedulaMedico = '{@datoHor.CedulaMedico}', DiaSemana = '{@datoHor.DiaSemana}', HoraInicio = '{@datoHor.HoraInicio.ToString("yyyy-MM-dd HH:mm:ss")}', HoraFin = '{@datoHor.HoraFin.ToString("yyyy-MM-dd HH:mm:ss")}' WHERE HorarioID = '{@datoHor.HorID}'";
                SqlCommand sql = new SqlCommand(query, objBD.connect);
                sql.ExecuteNonQuery();
                objBD.Cerrar();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public Horarios SearchHorario(int id)
        {
            Horarios datoHor = new Horarios();
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
                objBD.Cerrar();
            }
            catch (Exception e)
            {
                datoHor = null;
                objBD.Cerrar();
                Console.WriteLine(e.Message);
            }
            return datoHor;
        }
    }
}