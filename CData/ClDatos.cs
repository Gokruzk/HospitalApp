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
                        ID = Convert.ToInt16(reader["MedicoID"]),
                        Nombre = Convert.ToString(reader["Nombre"]),
                        Direccion = Convert.ToInt16(reader["DireccionID"]),
                        Cedula = Convert.ToString(reader["Cedula"]),
                        NumSegSocial = Convert.ToString(reader["NumeroSeguridadSocial"]),
                        NumColegiado = Convert.ToString(reader["NumeroColegiado"]),
                        Tipo = Convert.ToString(reader["TipoMedico"]),
                        FechaA = Convert.ToString(reader["FechaAlta"]),
                        FechaB = Convert.ToString(reader["FechaBaja"]),
                        Poblacion = Convert.ToInt16(reader["Poblacion"])
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
                string query = $"INSERT INTO Medicos(MedicoID, Nombre, DireccionID, Cedula, NumeroSeguridadSocial, NumeroColegiado, TipoMedico, FechaAlta, FechaBaja, Poblacion) VALUES ('{@datoMed.ID}','{@datoMed.Nombre}','{@datoMed.Direccion}','{@datoMed.Cedula}','{@datoMed.NumSegSocial}','{@datoMed.NumColegiado}','{@datoMed.Tipo}','{@datoMed.FechaA}','{@datoMed.FechaB}','{@datoMed.Poblacion}')";
                SqlCommand sql = new SqlCommand(query, objBD.connect);
                sql.ExecuteNonQuery();
                objBD.Cerrar();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void DeleteMedico(int id)
        {
            try
            {
                objBD.Abrir();
                string query = "DELETE FROM Medicos WHERE MedicoID = '" + id + "'";
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
                string query = "UPDATE Medicos SET Nombre = '" + datoMed.Nombre + "', DireccionID = '" + datoMed.Direccion + "', Cedula = '" + datoMed.Cedula + "', NumeroSeguridadSocial = '" + datoMed.NumSegSocial + "', NumeroColegiado = '" + datoMed.NumColegiado + "', TipoMedico = '" + datoMed.Tipo + "', FechaAlta = '" + datoMed.FechaA + "', FechaBaja = '" + datoMed.FechaB + "', Poblacion = '" + datoMed.Poblacion + "' WHERE MedicoID = '" + datoMed.ID + "'";
                SqlCommand sql = new SqlCommand(query, objBD.connect);
                sql.ExecuteNonQuery();
                objBD.Cerrar();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public Medico SearchMedico(int id)
        {
            Medico datoMed = new Medico();
            try
            {
                objBD.Abrir();
                string query = "SELECT * FROM Medicos WHERE MedicoID = '" + id + "'";
                SqlCommand sql = new SqlCommand(query, objBD.connect);
                sql.ExecuteNonQuery();

                SqlDataReader reader = sql.ExecuteReader();

                if (reader.Read())
                {
                    Medico objEnt = new Medico()
                    {
                        ID = Convert.ToInt16(reader["MedicoID"]),
                        Nombre = Convert.ToString(reader["Nombre"]),
                        Direccion = Convert.ToInt16(reader["DireccionID"]),
                        Cedula = Convert.ToString(reader["Cedula"]),
                        NumSegSocial = Convert.ToString(reader["NumeroSeguridadSocial"]),
                        NumColegiado = Convert.ToString(reader["NumeroColegiado"]),
                        Tipo = Convert.ToString(reader["TipoMedico"]),
                        FechaA = Convert.ToString(reader["FechaAlta"]),
                        FechaB = Convert.ToString(reader["FechaBaja"]),
                        Poblacion = Convert.ToInt16(reader["Poblacion"])
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
                        ID = Convert.ToInt16(reader["EmpleadoID"]),
                        Nombre = Convert.ToString(reader["Nombre"]),
                        Direccion = Convert.ToInt16(reader["DireccionID"]),
                        Cedula = Convert.ToString(reader["Cedula"]),
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
                string query = $"INSERT INTO Empleados(EmpleadoID, Nombre, DireccionID, Cedula, NumeroSeguridadSocial, TipoEmpleado, Poblacion) VALUES ('{@datoEmp.ID}','{@datoEmp.Nombre}','{@datoEmp.Direccion}','{@datoEmp.Cedula}','{@datoEmp.NumSegSocial}','{@datoEmp.Tipo}','{@datoEmp.Poblacion}')";
                SqlCommand sql = new SqlCommand(query, objBD.connect);
                sql.ExecuteNonQuery();
                objBD.Cerrar();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void DeleteEmpleado(int id)
        {
            try
            {
                objBD.Abrir();
                string query = "DELETE FROM Empleados WHERE EmpleadoID = '" + id + "'";
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
                string query = "UPDATE Empleados SET Nombre = '" + datoEmp.Nombre + "', DireccionID = '" + datoEmp.Direccion + "', Cedula = '" + datoEmp.Cedula + "', NumeroSeguridadSocial = '" + datoEmp.NumSegSocial + "', Tipo = '" + datoEmp.Tipo + "', Poblacion = '" + datoEmp.Poblacion + "' WHERE EmpleadoID = '" + datoEmp.ID + "'";
                SqlCommand sql = new SqlCommand(query, objBD.connect);
                sql.ExecuteNonQuery();
                objBD.Cerrar();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public Empleado SearchEmpleado(int id)
        {
            Empleado datoEmp = new Empleado();
            try
            {
                objBD.Abrir();
                string query = "SELECT * FROM Empleados WHERE EmpleadoID = '" + id + "'";
                SqlCommand sql = new SqlCommand(query, objBD.connect);
                sql.ExecuteNonQuery();

                SqlDataReader reader = sql.ExecuteReader();

                if (reader.Read())
                {
                    Empleado objEnt = new Empleado()
                    {
                        ID = Convert.ToInt16(reader["EmpleadoID"]),
                        Nombre = Convert.ToString(reader["Nombre"]),
                        Direccion = Convert.ToInt16(reader["DireccionID"]),
                        Cedula = Convert.ToString(reader["Cedula"]),
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
                        ID = Convert.ToInt16(reader["PacienteID"]),
                        Nombre = Convert.ToString(reader["Nombre"]),
                        Direccion = Convert.ToInt16(reader["DireccionID"]),
                        Cedula = Convert.ToString(reader["Cedula"]),
                        NumSegSocial = Convert.ToString(reader["NumeroSeguridadSocial"]),
                        Medico = Convert.ToInt16(reader["MedicoID"])
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
                string query = $"INSERT INTO Pacientes(PacienteID, Nombre, DireccionID, Cedula, NumeroSeguridadSocial, MedicoID) VALUES ('{@datoPac.ID}','{@datoPac.Nombre}','{@datoPac.Direccion}','{@datoPac.Cedula}','{@datoPac.NumSegSocial}','{@datoPac.Medico}')";
                SqlCommand sql = new SqlCommand(query, objBD.connect);
                sql.ExecuteNonQuery();
                objBD.Cerrar();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void DeletePaciente(int id)
        {
            try
            {
                objBD.Abrir();
                string query = "DELETE FROM Pacientes WHERE PacienteID = '" + id + "'";
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
                string query = "UPDATE Pacientes SET Nombre = '" + datoPac.Nombre + "', DireccionID = '" + datoPac.Direccion + "', Cedula = '" + datoPac.Cedula + "', NumeroSeguridadSocial = '" + datoPac.NumSegSocial + "', MedicoID = '" + datoPac.Medico + "' WHERE PacienteID = '" + datoPac.ID + "'";
                SqlCommand sql = new SqlCommand(query, objBD.connect);
                sql.ExecuteNonQuery();
                objBD.Cerrar();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public Paciente SearchPaciente(int id)
        {
            Paciente datoPac = new Paciente();
            try
            {
                objBD.Abrir();
                string query = "SELECT * FROM Pacientes WHERE PacienteID = '" + id + "'";
                SqlCommand sql = new SqlCommand(query, objBD.connect);
                sql.ExecuteNonQuery();

                SqlDataReader reader = sql.ExecuteReader();

                if (reader.Read())
                {
                    Paciente objEnt = new Paciente()
                    {
                        ID = Convert.ToInt16(reader["PacienteID"]),
                        Nombre = Convert.ToString(reader["Nombre"]),
                        Direccion = Convert.ToInt16(reader["DireccionID"]),
                        Cedula = Convert.ToString(reader["Cedula"]),
                        NumSegSocial = Convert.ToString(reader["NumeroSeguridadSocial"]),
                        Medico = Convert.ToInt16(reader["MedicoID"])
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
    }
}
