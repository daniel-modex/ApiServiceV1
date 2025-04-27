using AppServices.Helper;
using AppServices.Models.Patient;
using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppServices.DAL.RegisterationDAL
{
    public class PatientRegisteration
    {
        public static object NewPatientRegister(RegisterPatient patient)
        {
            using (var con = new SqlConnection(ConnectionStringHelper.GetConnectionString()))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand("spRegisterNewPatient", con))
                {
                    command.CommandType = CommandType.StoredProcedure;


                    command.Parameters.AddWithValue("@FirstName", patient.FirstName);
                    command.Parameters.AddWithValue("@LastName", patient.LastName);
                    command.Parameters.AddWithValue("@Gender", patient.Gender);
                    command.Parameters.AddWithValue("@DateOfBirth", patient.DateOfBirth);
                    command.Parameters.AddWithValue("@ContactNumber", (object?)patient.ContactNumber ?? DBNull.Value);
                    command.Parameters.AddWithValue("@Email", (object?)patient.Email ?? DBNull.Value);
                    command.Parameters.AddWithValue("@Address", (object?)patient.Address ?? DBNull.Value);
                    command.Parameters.AddWithValue("@City", (object?)patient.City ?? DBNull.Value);
                    command.Parameters.AddWithValue("@State", (object?)patient.State ?? DBNull.Value);
                    command.Parameters.AddWithValue("@PostalCode", (object?)patient.PostalCode ?? DBNull.Value);
                    command.Parameters.AddWithValue("@EmergencyContactName", (object?)patient.EmergencyContactName ?? DBNull.Value);
                    command.Parameters.AddWithValue("@EmergencyContactNumber", (object?)patient.EmergencyContactNumber ?? DBNull.Value);

                    command.ExecuteNonQuery();

                }
            }
            return 0;

        }
       
    }
}
